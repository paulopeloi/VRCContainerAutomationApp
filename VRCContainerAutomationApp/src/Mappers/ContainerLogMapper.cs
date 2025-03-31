using VRCContainerAutomationApp.Models;

namespace VRCContainerAutomationApp.Mappers;

public static class ContainerLogMapper
{
    public static ContainerLogModel FromRow(Dictionary<string, object> row)
    {
        return new ContainerLogModel
        {
            IdLog = Convert.ToInt32(row["idLog"]),
            UuidContainer = Convert.ToString(row["uuidContainer"]) ?? string.Empty,
            IdStatusOperation = Convert.ToInt32(row["idStatusOperation"]),
            StatusOperation = Convert.ToString(row["statusOperation"]) ?? string.Empty,
            StatusDescription = Convert.ToString(row["statusDescription"]) ?? string.Empty,
            OcurredAt = DateTime.Parse(row["ocurredAt"].ToString() ?? string.Empty),
            IdOldZone = row["idOldZone"] != DBNull.Value ? Convert.ToInt32(row["idOldZone"]) : null,
            OldZone = Convert.ToString(row["oldZone"]) ?? string.Empty,
            IdNewZone = Convert.ToInt32(row["idNewZone"]),
            NewZone = Convert.ToString(row["newZone"]) ?? string.Empty
        };
    }
}
