namespace VRCContainerAutomationApp.src.Models;

public partial class ContainerController
{
    public partial class Create 
    {
        public int Id { get; set; }
        public string uuid { get; set; }
        public string IdType { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public string IdLocation { get; set; }
        public string IdStatus { get; set; }
        public DateTime ReceivedAt { get; set; }
    }
    public partial class Update
    {
        public DateTime UpdatedAt { get; set; }
    }
    public partial class Get { }
}
