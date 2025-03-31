using System.Diagnostics;
using VRCContainerAutomationApp.Models;
using VRCContainerAutomationApp.Services;

namespace VRCContainerAutomationApp.Controllers;

public static class ContainerController
{
    public static bool ContainerStorage(string uuidValue, decimal heightValue, decimal weightValue, object? selectedTypeValue, int idLocationValue)
    {
        if (string.IsNullOrWhiteSpace(uuidValue))
            return false;

        if (selectedTypeValue == null || !int.TryParse(selectedTypeValue.ToString(), out int idTypeValue))
            return false;

        if (weightValue <= 0 || heightValue <= 0)
            return false;

        try
        {
            ContainerService.ContainerStorage(uuidValue, heightValue, weightValue, idTypeValue, idLocationValue);
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"[ERRO] Falha ao armazenar container: {ex.Message}");
            return false;
        }
    }

    public static List<ContainerListModel> GetAllContainers()
    {
        return ContainerService.GetAllContainers();
    }
}