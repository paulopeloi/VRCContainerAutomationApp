using VRCContainerAutomationApp.Models;

public static class ContainerTypeMapper
{
    public static ContainerType FromRow(Dictionary<string, object> row)
    {
        return new ContainerType
        {
            Id = Convert.ToInt32(row["id"]),
            Type = row["type"].ToString() ?? string.Empty,
            Description = row["description"].ToString() ?? string.Empty
        };
    }
}