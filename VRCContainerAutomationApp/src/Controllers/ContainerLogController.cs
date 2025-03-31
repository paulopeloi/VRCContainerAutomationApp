using VRCContainerAutomationApp.Models;
using VRCContainerAutomationApp.Services;

namespace VRCContainerAutomationApp.Controllers;

public static class ContainerLogController
{
    public static List<ContainerLogModel> GetContainerLogs(string uuid)
    {
        return ContainerLogService.GetContainerLogs(uuid);
    }
}
