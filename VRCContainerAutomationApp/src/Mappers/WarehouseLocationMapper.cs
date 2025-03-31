using VRCContainerAutomationApp.Models;

namespace VRCContainerAutomationApp.Mappers;

public static class WarehouseLocationMapper
{
    public static WarehouseLocationModel FromRow(Dictionary<string, object> row)
    {
        return new WarehouseLocationModel
        {
            Id = Convert.ToInt32(row["id"]),
            Zone = Convert.ToString(row["zone"]) ?? string.Empty,
            PermittedType = Convert.ToInt32(row["permitted_type"]),
            MaxWeight = Convert.ToDouble(row["max_weight"]),
            MaxHeight = Convert.ToDouble(row["max_height"]),
            MaxQuantityContainers = Convert.ToInt32(row["max_quantity_containers"]),
            ContainerCount = Convert.ToInt32(row["container_count"])
        };
    }
}
