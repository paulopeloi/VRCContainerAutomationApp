namespace VRCContainerAutomationApp.Dtos.WarehouseLocation;

public class UpdateWarehouseLocationDto
{
    public int Id { get; set; }
    public int ContainerCount { get; set; }
    public DateTime LastOperationAt { get; set; }
}