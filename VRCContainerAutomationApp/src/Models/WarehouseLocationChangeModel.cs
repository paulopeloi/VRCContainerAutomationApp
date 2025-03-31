namespace VRCContainerAutomationApp.Models;

public class WarehouseLocationChangeModel
{
    public int Id { get; set; }
    public string Zone { get; set; } = string.Empty;
    public int PermittedType { get; set; }
    public decimal MaxWeight { get; set; }
    public decimal MaxHeight { get; set; }
    public int MaxQuantityContainers { get; set; }
    public int ContainerCount { get; set; }
    public DateTime LastOperationAt { get; set; }
}
