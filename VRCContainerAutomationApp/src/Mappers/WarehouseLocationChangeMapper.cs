using VRCContainerAutomationApp.Models;

namespace VRCContainerAutomationApp.Mappers;

public static class WarehouseLocationChangeMapper
{
    public static WarehouseLocationChangeModel FromRow(Dictionary<string, object> row)
    {
        return new WarehouseLocationChangeModel
        {
            Id = Convert.ToInt32(row["id"]),
            Zone = Convert.ToString(row["zone"]) ?? string.Empty,
            PermittedType = Convert.ToInt32(row["permitted_type"]),
            MaxWeight = Convert.ToDecimal(row["max_weight"]),
            MaxHeight = Convert.ToDecimal(row["max_height"]),
            MaxQuantityContainers = Convert.ToInt32(row["max_quantity_containers"]),
            ContainerCount = Convert.ToInt32(row["container_count"]),
            LastOperationAt = DateTime.Parse(row["last_operation_at"].ToString() ?? string.Empty)
        };
    }
}
