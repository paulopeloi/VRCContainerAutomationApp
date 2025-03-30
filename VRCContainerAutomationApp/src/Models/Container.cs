namespace VRCContainerAutomationApp.Models;

public class Container
{
    public int Id { get; set; }
    public string Uuid { get; set; } = string.Empty;
    public double Height { get; set; }
    public double Weight { get; set; }
    public int IdType { get; set; }
    public int IdStatus { get; set; }
    public int IdLocation { get; set; }
    public DateTime ReceivedAt { get; set; }
    public DateTime LastOperationAt { get; set; }
}