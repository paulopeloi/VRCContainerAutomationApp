namespace VRCContainerAutomationApp.Dtos.WarehouseLocation;

public class CreateWarehouseLocationDto
{
    public string Zone { get; set; } = string.Empty;
    public int PermittedType { get; set; }
    public double MaxWeight { get; set; }
    public double MaxHeight { get; set; }
    public int MaxQuantityContainers { get; set; }
}