using VRCContainerAutomationApp.Models;

namespace VRCContainerAutomationApp.Mappers;

public static class ContainerListMapper
{
    public static ContainerListModel FromRow(Dictionary<string, object> row)
    {
        return new ContainerListModel
        {
            Id = Convert.ToInt32(row["id"]),
            Uuid = Convert.ToString(row["uuid"]) ?? string.Empty,
            Height = Convert.ToDouble(row["height"]),
            Weight = Convert.ToDouble(row["weight"]),
            IdType = Convert.ToInt32(row["idType"]),
            Type = Convert.ToString(row["type"]) ?? string.Empty,
            IdStatus = Convert.ToInt32(row["idStatus"]),
            Status = Convert.ToString(row["status"]) ?? string.Empty,
            LocationZone = Convert.ToString(row["locationZone"]) ?? string.Empty,
            ReceivedAt = DateTime.Parse(row["receivedAt"].ToString() ?? string.Empty),
            LastOperationAt = DateTime.Parse(row["lastOperationAt"].ToString() ?? string.Empty)
        };
    }
}
