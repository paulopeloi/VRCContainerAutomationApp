using VRCContainerAutomationApp.Models;
using VRCContainerAutomationApp.Database;
using VRCContainerAutomationApp.SQLs;
using VRCContainerAutomationApp.Mappers;

namespace VRCContainerAutomationApp.Services;

public static class ContainerLogService
{
    public static List<ContainerLogModel> GetContainerLogs(string uuid)
    {
        var sql = ContainerLogSql.GetContainerLogs;

        var parameters = new Dictionary<string, object>{["@uuid"] = uuid};

        var result = SQLiteService.ExecuteQuery(sql, parameters);

        return result.Select(ContainerLogMapper.FromRow).ToList();
    }
}
