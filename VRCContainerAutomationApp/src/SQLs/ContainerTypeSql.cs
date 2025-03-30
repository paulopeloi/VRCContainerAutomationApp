namespace VRCContainerAutomationApp.SQLs;

public static class ContainerTypeSql
{
    public static string GetContainersTypes =>
        @"
        SELECT containers_types.id,
               containers_types.type,
               containers_types.description
          FROM containers_types
         ORDER BY containers_types.type ASC;
        ";
}
