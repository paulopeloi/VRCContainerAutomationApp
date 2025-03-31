namespace VRCContainerAutomationApp.SQLs;

public static class ContainerSql
{
    public static string GetAllContainers =>
        @"
            SELECT containers.uuid,
                   containers.height,
                   containers.weight,
                   containers_types.type,
                   containers_status.status,
                   warehouse_locations.zone AS locationZone,
                   containers.received_at,
                   containers.last_operation_at
              FROM containers
              JOIN containers_types    ON (containers_types.id    = containers.id_type)
              JOIN containers_status   ON (containers_status.id   = containers.id_status)
              JOIN warehouse_locations ON (warehouse_locations.id = containers.id_location)
        ";
}