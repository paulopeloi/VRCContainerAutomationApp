namespace VRCContainerAutomationApp.SQLs;

public static class WarehouseLocationSql
{
    public static string FindAvailableLocation =>
        @"
        SELECT warehouse_locations.id,
               warehouse_locations.zone,
               warehouse_locations.permitted_type,
               warehouse_locations.max_weight,
               warehouse_locations.max_height,
               warehouse_locations.max_quantity_containers,
               warehouse_locations.container_count,
               warehouse_locations.last_operation_at
          FROM warehouse_locations
         WHERE permitted_type = @typeId
           AND max_weight >= @weight
           AND max_height >= @height
           AND container_count < max_quantity_containers
         ORDER BY container_count ASC
         LIMIT 1;
        ";
}
