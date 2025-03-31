using VRCContainerAutomationApp.Utils;
using VRCContainerAutomationApp.Controllers;
using VRCContainerAutomationApp.Models;
using System.Diagnostics;

namespace VRCContainerAutomationApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var typesDataset = ContainerTypeController.GetAllContainerTypes();

            InputSelectType.DataSource = typesDataset;
            InputSelectType.DisplayMember = "DisplayText";
            InputSelectType.ValueMember = "Id";
            InputSelectType.SelectedIndex = -1;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            InputSelectType.Focus();
            if (InputWeight.Controls.Count > 0)
            {
                InputWeight.Controls[0].Visible = false;
            }

            if (InputHeight.Controls.Count > 0)
            {
                InputHeight.Controls[0].Visible = false;
            }
        }

        private void ButtonUUID_MouseClick(object sender, MouseEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(InputUUID.Text))
                return;

            string uuid = UuidGenerator.Generate();
            InputUUID.Text = uuid;
            ButtonUUID.Enabled = false;
        }

        private void ButtonSubmit_MouseClick(object sender, MouseEventArgs e)
        {
            if (!ValidateForm()) return;

            var selectedTypeValue = InputSelectType.SelectedValue;
            var weightValue = InputWeight.Value;
            var heightValue = InputHeight.Value;

            var availableLocation = WarehouseLocationController.FindAvailableLocation(selectedTypeValue, weightValue, heightValue);
      
            if (availableLocation == null)
            {
                MessageBox.Show("Nenhuma localização disponível para esse container.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ConfirmStorage(availableLocation)) return;

            var uuidValue = InputUUID.Text;
            bool storageSuccess = ContainerController.ContainerStorage(uuidValue, heightValue, weightValue, selectedTypeValue, availableLocation.Id);

            if (storageSuccess)
            {
                InputSelectType.SelectedIndex = -1;
                InputHeight.Value = 0;
                InputWeight.Value = 0;
                InputUUID.Text = string.Empty;
                ButtonUUID.Enabled = true;
                MessageBox.Show("Container armazenado com sucesso!");
            }
            else
            {
                MessageBox.Show("Falha ao armazenar container. Verifique os dados.");
            }
        }

        private bool ValidateForm()
        {
            if (InputSelectType.SelectedItem == null)
            {
                MessageBox.Show("Selecione um tipo de container.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (InputHeight.Value <= 0 || InputWeight.Value <= 0)
            {
                MessageBox.Show("Altura e peso devem ser maiores que zero.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(InputUUID.Text))
            {
                MessageBox.Show("ID Único não foi gerado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ConfirmStorage(WarehouseLocationModel location)
        {
            var confirm = MessageBox.Show(
                $"Local disponível: {location.Zone}\nConfirma o armazenamento?",
                "Confirmar Armazenagem",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            return confirm == DialogResult.OK;
        }
    }
}
