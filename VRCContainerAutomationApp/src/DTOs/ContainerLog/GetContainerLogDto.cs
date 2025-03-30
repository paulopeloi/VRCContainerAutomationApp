namespace VRCContainerAutomationApp.Dtos.ContainerLog;

public class GetContainerLogDto
{
    public string UuidContainer { get; set; } = string.Empty;
    public string Operation { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
}