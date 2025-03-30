namespace VRCContainerAutomationApp.Utils;

public static class UuidGenerator
{
    public static string Generate()
    {
        return Guid.NewGuid().ToString();
    }
}