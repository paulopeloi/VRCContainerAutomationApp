namespace VRCContainerAutomationApp.SQLs;

public static class ContainerLogSql
{
    public static string GetContainerLogs =>
        @"
           SELECT containers_logs.id AS idLog,
                  containers_logs.uuid_container AS uuidContainer,
                  containers_logs.id_status_operation AS idStatusOperation,
                  containers_status.status AS statusOperation,
                  containers_status.description AS statusDescription,
                  containers_logs.ocurred_at AS ocurredAt,
                  ws_old_location.id AS idOldZone,
                  ws_old_location.zone AS oldZone,
                  ws_new_location.id AS idNewZone,
                  ws_new_location.zone AS newZone
             FROM containers_logs
             JOIN containers_status                   ON (containers_status.id = containers_logs.id_status_operation)
        LEFT JOIN warehouse_locations ws_old_location ON (ws_old_location.id   = containers_logs.id_old_location)
        LEFT JOIN warehouse_locations ws_new_location ON (ws_new_location.id   = containers_logs.id_new_location)
            WHERE containers_logs.uuid_container = @uuid
            ORDER BY containers_logs.ocurred_at ASC
        ";
}