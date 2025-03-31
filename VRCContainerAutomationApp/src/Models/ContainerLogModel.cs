namespace VRCContainerAutomationApp.Models;

public class ContainerLogModel
{
    public int IdLog { get; set; }
    public string UuidContainer { get; set; } = string.Empty;
    public int IdStatusOperation { get; set; }
    public string StatusOperation { get; set; } = string.Empty;
    public string StatusDescription { get; set; } = string.Empty;
    public DateTime OcurredAt { get; set; }
    public int? IdOldZone { get; set; }
    public string OldZone { get; set; } = string.Empty;
    public int IdNewZone { get; set; }
    public string NewZone { get; set; } = string.Empty;
}
