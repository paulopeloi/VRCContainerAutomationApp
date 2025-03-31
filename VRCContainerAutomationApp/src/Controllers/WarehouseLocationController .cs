using System.Diagnostics;
using VRCContainerAutomationApp.Models;
using VRCContainerAutomationApp.Services;

namespace VRCContainerAutomationApp.Controllers;

public static class WarehouseLocationController
{
    public static WarehouseLocationModel? FindAvailableLocation(object? selectedTypeValue, decimal weightValue, decimal heightValue)
    {
        if (selectedTypeValue == null || !int.TryParse(selectedTypeValue.ToString(), out int idTypeValue))
            return null;

        if (weightValue <= 0 || heightValue <= 0)
            return null;

        return WarehouseLocationService.FindAvailableLocation(idTypeValue, weightValue, heightValue);
    }
}