﻿using VRCContainerAutomationApp.Models;
using VRCContainerAutomationApp.Database;
using VRCContainerAutomationApp.SQLs;
using VRCContainerAutomationApp.Mappers;
using System.Diagnostics;

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

    public static List<WarehouseLocationChangeModel> FindLocationsToChangeLocation(int idCurrentLocation, int idTypeValue, decimal weightValue, decimal heightValue)
    {
        var sql = WarehouseLocationSql.FindLocationsToChangeLocation;

        var parameters = new Dictionary<string, object>{
            ["@id"] = idCurrentLocation,
            ["@typeId"] = idTypeValue,
            ["@weight"] = weightValue,
            ["@height"] = heightValue
        };

        var result = SQLiteService.ExecuteQuery(sql, parameters);

        return result.Select(WarehouseLocationChangeMapper.FromRow).ToList();
    }
}
