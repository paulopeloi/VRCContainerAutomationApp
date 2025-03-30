namespace VRCContainerAutomationApp.Dtos.WarehouseLocation;

public class GetWarehouseLocationDto
{
    public int Id { get; set; }
    public string Zone { get; set; } = string.Empty;
    public string PermittedTypeName { get; set; } = string.Empty;
    public double MaxWeight { get; set; }
    public double MaxHeight { get; set; }
    public int MaxQuantityContainers { get; set; }
    public int ContainerCount { get; set; }
    public DateTime LastOperationAt { get; set; }
}