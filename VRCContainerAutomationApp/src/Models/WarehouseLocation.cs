namespace VRCContainerAutomationApp.Models;

public class WarehouseLocation
{
    public int Id { get; set; }
    public string Zone { get; set; } = string.Empty;
    public int PermittedType { get; set; }
    public double MaxWeight { get; set; }
    public double MaxHeight { get; set; }
    public int MaxQuantityContainers { get; set; }
    public int ContainerCount { get; set; }
    public DateTime LastOperationAt { get; set; }
}