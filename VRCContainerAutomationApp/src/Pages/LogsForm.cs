using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using VRCContainerAutomationApp.Controllers;
using VRCContainerAutomationApp.Models;
using VRCContainerAutomationApp.Services;

namespace VRCContainerAutomationApp.src.Pages;

public partial class LogsForm : Form
{
    private readonly string _uuid;
    public LogsForm(string uuid)
    {
        InitializeComponent();
        _uuid = uuid;
    }

    private void LoadLogs(string uuid)
    {
        try
        {
            var containerLogs = ContainerLogController.GetContainerLogs(uuid);

            Debug.WriteLine(containerLogs);

            if (containerLogs.Count == 0)
            {
                ListLogs.Items.Add("Nenhuma movimentação registrada.");
                return;
            }

            foreach (var log in containerLogs)
            {
                string msg = $"[{log.OcurredAt:dd/MM/yyyy HH:mm}] {log.StatusDescription}";

                if (log.IdOldZone != log.IdNewZone && log.IdOldZone > 0)
                {
                    msg += $" | {log.OldZone} → {log.NewZone}";
                }
                else if (log.IdOldZone == 0)
                {
                    msg += $" | Armazenado em {log.NewZone}";
                }
                else
                {
                    msg += $" | {log.NewZone}";
                }

                ListLogs.Items.Add(msg);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Erro ao carregar logs: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void LogsForm_Load(object sender, EventArgs e)
    {
        this.TopMost = true;
        this.BringToFront();
        this.Activate();
        labelUUID.Text = _uuid;
        LoadLogs(_uuid);
    }

    private void buttonExit_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
