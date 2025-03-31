using VRCContainerAutomationApp.Models;

namespace VRCContainerAutomationApp.Mappers;

public static class ContainerChangeLocationMapper
{
    public static ContainerChangeLocation FromRow(Dictionary<string, object> row)
    {
        return new ContainerChangeLocation
        {
            Id = Convert.ToInt32(row["id"]),
            Uuid = Convert.ToString(row["uuid"]) ?? string.Empty,
            Height = Convert.ToDouble(row["height"]),
            Weight = Convert.ToDouble(row["weight"]),
            IdType = Convert.ToInt32(row["idType"]),
            Type = Convert.ToString(row["type"]) ?? string.Empty,
            IdStatus = Convert.ToInt32(row["idStatus"]),
            IdCurrentLocation = Convert.ToInt32(row["idCurrentLocation"]),
            CurrentLocationZone = Convert.ToString(row["currentLocationZone"]) ?? string.Empty
        };
    }
}
