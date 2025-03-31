using VRCContainerAutomationApp.Controllers;
using VRCContainerAutomationApp.src.Pages;

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
        private void ContainersListForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.BringToFront();
            this.Activate();
            dataGridContainers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridContainers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            LoadDataGrid();
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
                var rowIndex = dataGridContainers.SelectedCells[0].RowIndex;
                var idStatus = Convert.ToInt32(dataGridContainers.Rows[rowIndex].Cells["idStatus"].Value);

                if (idStatus == 2)
                {
                    MessageBox.Show("Container já despachado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var uuid = dataGridContainers.Rows[rowIndex].Cells["uuid"].Value?.ToString() ?? string.Empty;

                new ChangeLocationForm(uuid).ShowDialog();
                LoadDataGrid();
            }
            else
            {
                MessageBox.Show("Nenhum container foi selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonLogs_Click(object sender, EventArgs e)
        {
            if (dataGridContainers.SelectedCells.Count > 0)
            {
                var rowIndex = dataGridContainers.SelectedCells[0].RowIndex;
                var uuid = dataGridContainers.Rows[rowIndex].Cells["uuid"].Value?.ToString() ?? string.Empty;
                new LogsForm(uuid).ShowDialog();
            }
            else
            {
                MessageBox.Show("Nenhum container foi selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
