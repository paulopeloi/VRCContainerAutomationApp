using VRCContainerAutomationApp.Models;
using VRCContainerAutomationApp.Services;

namespace VRCContainerAutomationApp.Controllers;

public static class ContainerTypeController
{
    public static List<ContainerTypeModel> GetAllContainerTypes()
    {
        return ContainerTypeService.GetAllContainerTypes();
    }
}