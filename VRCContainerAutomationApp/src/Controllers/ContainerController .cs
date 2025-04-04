﻿using System;
using System.Diagnostics;
using VRCContainerAutomationApp.Models;
using VRCContainerAutomationApp.Services;

namespace VRCContainerAutomationApp.Controllers;

public static class ContainerController
{
    public static bool ContainerStorage(string uuid, decimal height, decimal weight, object? selectedType, int idLocation)
    {
        if (string.IsNullOrWhiteSpace(uuid))
            return false;

        if (selectedType == null || !int.TryParse(selectedType.ToString(), out int idTypeValue))
            return false;

        if (weight <= 0 || height <= 0)
            return false;

        try
        {
            ContainerService.ContainerStorage(uuid, height, weight, idTypeValue, idLocation);
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"[ERRO] Falha ao armazenar container: {ex.Message}");
            return false;
        }
    }

    public static bool ContainerDispatch(string uuid)
    {
        try
        {
            ContainerService.ContainerDispatch(uuid);
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"[ERRO] Falha ao despachar container: {ex.Message}");
            return false;
        }
    }

    public static bool ContainerChangeLocation(string uuid, int idNewLocation)
    {
        try
        {
            ContainerService.ContainerChangeLocation(uuid, idNewLocation);
            return true;
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"[ERRO] Falha ao trocar container de local: {ex.Message}");
            return false;
        }
    }

    public static List<ContainerListModel> GetAllContainers()
    {
        return ContainerService.GetAllContainers();
    }

    public static ContainerChangeLocation? GetContainerChangeLocation(string uuid)
    {
        try
        {
            return ContainerService.GetContainerChangeLocation(uuid);
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"[ERRO] Falha ao buscar container para troca de local: {ex.Message}");
            return null;
        }
    }
}