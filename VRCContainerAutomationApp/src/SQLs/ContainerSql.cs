namespace VRCContainerAutomationApp.SQLs;

public static class ContainerSql
{
    public static string GetAllContainers =>
        @"
            SELECT containers.id,
                   containers.uuid,
                   containers.height,
                   containers.weight,
                   containers.id_type AS idType,
                   containers_types.type,
                   containers.id_status AS idStatus,
                   containers_status.status,
                   warehouse_locations.zone AS locationZone,
                   containers.received_at AS receivedAt,
                   containers.last_operation_at AS lastOperationAt
              FROM containers
              JOIN containers_types    ON (containers_types.id    = containers.id_type)
              JOIN containers_status   ON (containers_status.id   = containers.id_status)
              JOIN warehouse_locations ON (warehouse_locations.id = containers.id_location)
        ";

    public static string GetContainerChangeLocation =>
        @"
            SELECT containers.id,
                   containers.uuid,
                   containers.height,
                   containers.weight,
                   containers.id_type AS idType,
                   containers_types.type,
                   containers.id_status AS idStatus,
                   warehouse_locations.id AS idCurrentLocation,
                   warehouse_locations.zone AS currentLocationZone
              FROM containers
              JOIN containers_types    ON (containers_types.id    = containers.id_type)
              JOIN warehouse_locations ON (warehouse_locations.id = containers.id_location)
             WHERE containers.uuid = @uuid
        ";
}