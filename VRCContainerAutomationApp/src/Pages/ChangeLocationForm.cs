using System;
using System.Diagnostics;
using VRCContainerAutomationApp.Controllers;
using VRCContainerAutomationApp.Models;

namespace VRCContainerAutomationApp.src.Pages
{
    public partial class ChangeLocationForm : Form
    {
        private readonly string _uuid;
        public ChangeLocationForm(string uuid)
        {
            InitializeComponent();
            _uuid = uuid;
        }
        private bool ConfirmChangeLocation(string zone)
        {
            var confirm = MessageBox.Show(
                $"Realmente deseja mudar a localização do container? \nNovo Local: \"{zone}\"?",
                "Confirmar troca",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            return confirm == DialogResult.OK;
        }

        private void ChangeLocationForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.BringToFront();
            this.Activate();

            var containerInfo = ContainerController.GetContainerChangeLocation(_uuid);

            if (containerInfo == null)
            {
                MessageBox.Show("Erro ao carregar informações do container.");
                return;
            }

            var availableLocations = WarehouseLocationController.FindLocationsToChangeLocation(
                containerInfo.IdCurrentLocation,
                containerInfo.IdType,
                Convert.ToDecimal(containerInfo.Weight),
                Convert.ToDecimal(containerInfo.Height)
            );

            if (availableLocations == null)
            {
                MessageBox.Show("Nenhuma localização disponível para esse container.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            labelUUID.Text = _uuid;
            labelType.Text = containerInfo.Type;
            labelLocation.Text = containerInfo.CurrentLocationZone;
            InputSelectLocation.DataSource = availableLocations;
            InputSelectLocation.DisplayMember = "Zone";
            InputSelectLocation.ValueMember = "Id";
            InputSelectLocation.SelectedIndex = -1;
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (InputSelectLocation.SelectedItem == null)
            {
                MessageBox.Show("Selecione a nova localização.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedItem = InputSelectLocation.SelectedItem as WarehouseLocationChangeModel;
            string zone = selectedItem?.Zone ?? string.Empty;


            if (!ConfirmChangeLocation(zone)) return;

            int idNewLocation = Convert.ToInt32(InputSelectLocation.SelectedValue);

            bool changeLocationSuccess = ContainerController.ContainerChangeLocation(_uuid, idNewLocation);

            if (changeLocationSuccess)
            {
                MessageBox.Show("Localização do container alterada com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Falha ao trocar o localização do container. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
