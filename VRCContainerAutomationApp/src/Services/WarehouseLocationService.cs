using VRCContainerAutomationApp.Models;
using VRCContainerAutomationApp.Database;
using VRCContainerAutomationApp.SQLs;
using VRCContainerAutomationApp.Mappers;

namespace VRCContainerAutomationApp.Services;

public static class WarehouseLocationService
{
    public static WarehouseLocationModel? FindAvailableLocation(int idTypeValue, decimal weightValue, decimal heightValue)
    {
        var sql = WarehouseLocationSql.FindAvailableLocation;

        var parameters = new Dictionary<string, object>
        {
            ["@typeId"] = idTypeValue,
            ["@weight"] = weightValue,
            ["@height"] = heightValue
        };

        var result = SQLiteService.ExecuteQuery(sql, parameters);
        if (result.Count == 0) return null;

        return WarehouseLocationMapper.FromRow(result[0]);
    }
}
