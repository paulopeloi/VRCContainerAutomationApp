namespace VRCContainerAutomationApp.Models;

public class ContainerType
{
    public int Id { get; set; }
    public string Type { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string DisplayText => $"{Type} - ({Description})";

}