namespace VRCContainerAutomationApp.Models;

public class ContainerLogModel
{
    public int Id { get; set; }
    public int IdContainer { get; set; }
    public string UuidContainer { get; set; } = string.Empty;
    public int? IdOldLocation { get; set; }
    public int IdNewLocation { get; set; }
    public int IdStatusOperation { get; set; }
    public DateTime OcurredAt { get; set; }
}