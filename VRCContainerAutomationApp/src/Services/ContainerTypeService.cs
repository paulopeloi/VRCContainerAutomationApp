using VRCContainerAutomationApp.Models;
using VRCContainerAutomationApp.Database;
using VRCContainerAutomationApp.SQLs;
using VRCContainerAutomationApp.Mappers;

namespace VRCContainerAutomationApp.Services;

public static class ContainerTypeService
{
    public static List<ContainerTypeModel> GetAllContainerTypes()
    {
        var sql = ContainerTypeSql.GetContainersTypes;

        var result = SQLiteService.ExecuteQuery(sql);

        return result.Select(ContainerTypeMapper.FromRow).ToList();
    }
}
