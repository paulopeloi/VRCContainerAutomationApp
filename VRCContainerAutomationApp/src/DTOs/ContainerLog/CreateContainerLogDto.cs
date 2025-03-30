namespace VRCContainerAutomationApp.Dtos.ContainerLog;

public class CreateContainerLogDto
{
    public int IdContainer { get; set; }
    public string UuidContainer { get; set; } = string.Empty;
    public int IdLocation { get; set; }
    public string Operation { get; set; } = string.Empty;
}