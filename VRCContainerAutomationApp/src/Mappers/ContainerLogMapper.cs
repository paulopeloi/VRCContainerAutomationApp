using VRCContainerAutomationApp.Models;

namespace VRCContainerAutomationApp.Mappers;

public static class ContainerLogMapper
{
    public static ContainerLogModel FromRow(Dictionary<string, object> row)
    {
        return new ContainerLogModel
        {
            Id = Convert.ToInt32(row["id"]),
            IdContainer = Convert.ToInt32(row["id_container"]),
            UuidContainer = Convert.ToString(row["uuid_container"]) ?? string.Empty,
            IdOldLocation = row["id_old_location"] == DBNull.Value ? null : Convert.ToInt32(row["id_old_location"]),
            IdNewLocation = Convert.ToInt32(row["id_new_location"]),
            IdStatusOperation = Convert.ToInt32(row["id_status_operation"]),
            OcurredAt = Convert.ToDateTime(row["ocurred_at"])
        };
    }
}
