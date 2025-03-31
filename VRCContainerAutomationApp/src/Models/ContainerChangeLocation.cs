using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace VRCContainerAutomationApp.Models;

public class ContainerChangeLocation
{
    public int Id { get; set; }
    public string Uuid { get; set; } = string.Empty;
    public double Height { get; set; }
    public double Weight { get; set; }
    public int IdType { get; set; }
    public string Type { get; set; } = string.Empty;
    public int IdStatus { get; set; }
    public int IdCurrentLocation { get; set; }
    public string CurrentLocationZone { get; set; } = string.Empty;

}
