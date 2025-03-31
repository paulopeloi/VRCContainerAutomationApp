using VRCContainerAutomationApp.Database;
using VRCContainerAutomationApp.Mappers;
using VRCContainerAutomationApp.Models;
using VRCContainerAutomationApp.SQLs;

namespace VRCContainerAutomationApp.Services;

public static class ContainerService
{
    public static void ContainerStorage(string uuidValue, decimal heightValue, decimal weightValue, int idTypeValue, int idLocationValue)
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
            insertContainerCmd.Parameters.AddWithValue("@uuid", uuidValue);
            insertContainerCmd.Parameters.AddWithValue("@height", heightValue);
            insertContainerCmd.Parameters.AddWithValue("@weight", weightValue);
            insertContainerCmd.Parameters.AddWithValue("@idType", idTypeValue);
            insertContainerCmd.Parameters.AddWithValue("@idLocation", idLocationValue);

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
            insertLogCmd.Parameters.AddWithValue("@uuidContainer", uuidValue);
            insertLogCmd.Parameters.AddWithValue("@idLocation", idLocationValue);
            insertLogCmd.ExecuteNonQuery();

            var updateLocationCountCmd = connection.CreateCommand();
            updateLocationCountCmd.Transaction = transaction;
            updateLocationCountCmd.CommandText = @"
                UPDATE warehouse_locations
                   SET container_count = container_count + 1,
                       last_operation_at = CURRENT_TIMESTAMP
                 WHERE id = @idLocation";
            updateLocationCountCmd.Parameters.AddWithValue("@idLocation", idLocationValue);
            updateLocationCountCmd.ExecuteNonQuery();
        });
    }

    public static List<ContainerListModel> GetAllContainers()
    {
        var sql = ContainerSql.GetAllContainers;

        var result = SQLiteService.ExecuteQuery(sql);

        return result.Select(ContainerListMapper.FromRow).ToList();
    }
}