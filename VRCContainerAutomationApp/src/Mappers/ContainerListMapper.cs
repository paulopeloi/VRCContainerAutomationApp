using VRCContainerAutomationApp.Models;

namespace VRCContainerAutomationApp.Mappers;

public static class ContainerListMapper
{
    public static ContainerListModel FromRow(Dictionary<string, object> row)
    {
        return new ContainerListModel
        {
            Uuid = Convert.ToString(row["uuid"]) ?? string.Empty,
            Height = Convert.ToDouble(row["height"]),
            Weight = Convert.ToDouble(row["weight"]),
            Type = Convert.ToString(row["type"]) ?? string.Empty,
            Status = Convert.ToString(row["status"]) ?? string.Empty,
            LocationZone = Convert.ToString(row["locationZone"]) ?? string.Empty,
            ReceivedAt = DateTime.Parse(row["received_at"].ToString() ?? string.Empty),
            LastOperationAt = DateTime.Parse(row["last_operation_at"].ToString() ?? string.Empty)
        };
    }
}
