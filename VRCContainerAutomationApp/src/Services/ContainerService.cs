using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;
using VRCContainerAutomationApp.Database;
using VRCContainerAutomationApp.Mappers;
using VRCContainerAutomationApp.Models;
using VRCContainerAutomationApp.SQLs;

namespace VRCContainerAutomationApp.Services;

public static class ContainerService
{
    public static void ContainerStorage(string uuid, decimal height, decimal weight, int idType, int idLocation)
    {
        SQLiteService.ExecuteTransaction((connection, transaction) =>
        {
            var insertContainerCmd = connection.CreateCommand();
            insertContainerCmd.Transaction = transaction;
            insertContainerCmd.CommandText = @"
                INSERT INTO containers (uuid, height, weight, id_type, id_status, id_location)
                     VALUES (@uuid,
                             @height,
                             @weight,
                             @idType,
                             1,
                             @idLocation);
                      SELECT last_insert_rowid();";
            insertContainerCmd.Parameters.AddWithValue("@uuid", uuid);
            insertContainerCmd.Parameters.AddWithValue("@height", height);
            insertContainerCmd.Parameters.AddWithValue("@weight", weight);
            insertContainerCmd.Parameters.AddWithValue("@idType", idType);
            insertContainerCmd.Parameters.AddWithValue("@idLocation", idLocation);

            var idContainer = Convert.ToInt32(insertContainerCmd.ExecuteScalar());

            var insertLogCmd = connection.CreateCommand();
            insertLogCmd.Transaction = transaction;
            insertLogCmd.CommandText = @"
                INSERT INTO containers_logs (id_container, uuid_container, id_new_location, id_status_operation)
                     VALUES (@idContainer,
                             @uuidContainer,
                             @idLocation,
                             1)";

            insertLogCmd.Parameters.AddWithValue("@idContainer", idContainer);
            insertLogCmd.Parameters.AddWithValue("@uuidContainer", uuid);
            insertLogCmd.Parameters.AddWithValue("@idLocation", idLocation);
            insertLogCmd.ExecuteNonQuery();

            var updateLocationCountCmd = connection.CreateCommand();
            updateLocationCountCmd.Transaction = transaction;
            updateLocationCountCmd.CommandText = @"
                UPDATE warehouse_locations
                   SET container_count = container_count + 1,
                       last_operation_at = CURRENT_TIMESTAMP
                 WHERE id = @idLocation";
            updateLocationCountCmd.Parameters.AddWithValue("@idLocation", idLocation);
            updateLocationCountCmd.ExecuteNonQuery();
        });
    }

    public static List<ContainerListModel> GetAllContainers()
    {
        var sql = ContainerSql.GetAllContainers;

        var result = SQLiteService.ExecuteQuery(sql);

        return result.Select(ContainerListMapper.FromRow).ToList();
    }

    public static void ContainerDispatch(string uuid)
    {
        SQLiteService.ExecuteTransaction((connection, transaction) =>
        {
            var getContainerCmd = connection.CreateCommand();
            getContainerCmd.Transaction = transaction;
            getContainerCmd.CommandText = @"
                SELECT containers.id,
                       containers.id_location
                  FROM containers
                 WHERE containers.uuid = @uuid";
            getContainerCmd.Parameters.AddWithValue("@uuid", uuid);

            using var reader = getContainerCmd.ExecuteReader();
            if (!reader.Read())
                throw new Exception($"[SQLite] Container com UUID {uuid} não encontrado.");

            int idContainer = Convert.ToInt32(reader["id"]);
            int idLocation = Convert.ToInt32(reader["id_location"]);

            var updateContainerStatusCmd = connection.CreateCommand();
            updateContainerStatusCmd.Transaction = transaction;
            updateContainerStatusCmd.CommandText = @"
                UPDATE containers
                   SET id_status = 2,
                       last_operation_at = CURRENT_TIMESTAMP
                 WHERE uuid = @uuid;";

            updateContainerStatusCmd.Parameters.AddWithValue("@uuid", uuid);
            updateContainerStatusCmd.ExecuteNonQuery();

            var insertLogCmd = connection.CreateCommand();
            insertLogCmd.Transaction = transaction;
            insertLogCmd.CommandText = @"
                INSERT INTO containers_logs (id_container, uuid_container, id_old_location, id_new_location, id_status_operation)
                     VALUES (@idContainer,
                            @uuidContainer,
                            @idLocation,
                            @idLocation,
                            2)";

            insertLogCmd.Parameters.AddWithValue("@idContainer", idContainer);
            insertLogCmd.Parameters.AddWithValue("@uuidContainer", uuid);
            insertLogCmd.Parameters.AddWithValue("@idLocation", idLocation);
            insertLogCmd.ExecuteNonQuery();

            var updateLocationCountCmd = connection.CreateCommand();
            updateLocationCountCmd.Transaction = transaction;
            updateLocationCountCmd.CommandText = @"
                UPDATE warehouse_locations
                   SET container_count = container_count - 1,
                       last_operation_at = CURRENT_TIMESTAMP
                 WHERE id = @idLocation";
            updateLocationCountCmd.Parameters.AddWithValue("@idLocation", idLocation);
            updateLocationCountCmd.ExecuteNonQuery();
        });
    }
}