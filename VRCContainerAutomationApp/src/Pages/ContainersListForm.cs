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
                var selectedRowIndex = dataGridContainers.SelectedCells[0].RowIndex;
                var selectedContainerId = dataGridContainers.Rows[selectedRowIndex].Cells["uuid"].Value;

                Debug.WriteLine($"Dispatch container: {selectedContainerId}");
            }
            else
            {
                MessageBox.Show("Selecione um container primeiro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                MessageBox.Show("Selecione um container primeiro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
