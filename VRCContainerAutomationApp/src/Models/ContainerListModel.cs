namespace VRCContainerAutomationApp.Models;

public class ContainerListModel
{
    public string Uuid { get; set; } = string.Empty;
    public double Height { get; set; }
    public double Weight { get; set; }
    public string Type { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string LocationZone { get; set; } = string.Empty;
    public DateTime ReceivedAt { get; set; }
    public DateTime LastOperationAt { get; set; }
}
