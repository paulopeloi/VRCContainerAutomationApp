﻿namespace VRCContainerAutomationApp.Models;

public class ContainerStatusModel
{
    public int Id { get; set; }
    public string Status { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}