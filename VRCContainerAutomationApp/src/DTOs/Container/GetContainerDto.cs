namespace VRCContainerAutomationApp.Dtos.Container;

public class GetContainerDto
{
    public string Uuid { get; set; } = string.Empty;
    public string TypeName { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public string Zone { get; set; } = string.Empty;
    public double Height { get; set; }
    public double Weight { get; set; }
}