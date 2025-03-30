namespace VRCContainerAutomationApp.Models;

public class ContainerLogModel
{
    public int Id { get; set; }
    public int IdContainer { get; set; }
    public string UuidContainer { get; set; } = string.Empty;
    public int IdLocation { get; set; }
    public string Operation { get; set; } = string.Empty;
    public DateTime Timestamp { get; set; }
}