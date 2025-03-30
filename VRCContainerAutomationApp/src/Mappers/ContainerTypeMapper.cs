using VRCContainerAutomationApp.Models;

namespace VRCContainerAutomationApp.Mappers;
public static class ContainerTypeMapper
{
    public static ContainerTypeModel FromRow(Dictionary<string, object> row)
    {
        return new ContainerTypeModel
        {
            Id = Convert.ToInt32(row["id"]),
            Type = Convert.ToString(row["type"]) ?? string.Empty,
            Description = Convert.ToString(row["description"]) ?? string.Empty
        };
    }
}