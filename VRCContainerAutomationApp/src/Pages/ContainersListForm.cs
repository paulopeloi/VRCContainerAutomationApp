using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VRCContainerAutomationApp.Controllers;
using VRCContainerAutomationApp.Models;

namespace VRCContainerAutomationApp
{
    public partial class ContainersListForm : Form
    {
        public ContainersListForm()
        {
            InitializeComponent();
        }

        public void LoadDataGrid()
        {
            try
            {
                var containers = ContainerController.GetAllContainers();

                dataGridContainers.DataSource = containers;

                dataGridContainers.Columns["Id"].Visible = false;
                dataGridContainers.Columns["IdType"].Visible = false;
                dataGridContainers.Columns["idStatus"].Visible = false;

                dataGridContainers.Columns["Uuid"].HeaderText = "ID Único";
                dataGridContainers.Columns["Height"].HeaderText = "Altura (m)";
                dataGridContainers.Columns["Weight"].HeaderText = "Peso (kg)";
                dataGridContainers.Columns["Type"].HeaderText = "Tipo";
                dataGridContainers.Columns["Status"].HeaderText = "Status";
                dataGridContainers.Columns["LocationZone"].HeaderText = "Localização";
                dataGridContainers.Columns["ReceivedAt"].HeaderText = "Recebido em";
                dataGridContainers.Columns["LastOperationAt"].HeaderText = "Última operação";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Falha ao carregar os dados: {ex.Message}!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ConfirmDispatch(string uuid)
        {
            var confirm = MessageBox.Show(
                $"Realmente deseja despachar o container de ID \"{uuid}\"?",
                "Confirmar Despache",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            return confirm == DialogResult.OK;
        }

        private void ContainersListForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.BringToFront();
            this.Activate();
            LoadDataGrid();
        }

        private void ButtonDispatch_Click(object sender, EventArgs e)
        {
            if (dataGridContainers.SelectedCells.Count > 0)
            {
                var rowIndex = dataGridContainers.SelectedCells[0].RowIndex;
                var idStatus = Convert.ToInt32(dataGridContainers.Rows[rowIndex].Cells["idStatus"].Value);

                if (idStatus == 2)
                {
                    MessageBox.Show("Container já despachado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var uuid = dataGridContainers.Rows[rowIndex].Cells["uuid"].Value?.ToString() ?? string.Empty;

                if (!ConfirmDispatch(uuid)) return;

                bool dispatchSuccess = ContainerController.ContainerDispatch(uuid);

                if (dispatchSuccess)
                {
                    MessageBox.Show("Container despachado com sucesso!");
                    LoadDataGrid();
                }
                else
                {
                    MessageBox.Show("Falha ao despachar container. Tente novamente.");
                }
            }
            else
            {
                MessageBox.Show("Nenhum container foi selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonLocation_Click(object sender, EventArgs e)
        {
            if (dataGridContainers.SelectedCells.Count > 0)
            {
                var selectedRowIndex = dataGridContainers.SelectedCells[0].RowIndex;
                var selectedContainerId = dataGridContainers.Rows[selectedRowIndex].Cells["uuid"].Value;

                Debug.WriteLine($"Location container: {selectedContainerId}");
            }
            else
            {
                MessageBox.Show("Nenhum container foi selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
