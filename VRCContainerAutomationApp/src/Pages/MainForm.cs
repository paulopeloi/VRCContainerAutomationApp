using System.Diagnostics;
using VRCContainerAutomationApp.Database;
using VRCContainerAutomationApp.Utils;

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
            string sql = @"
                SELECT containers_types.id,
                       containers_types.type,
                       containers_types.description
                  FROM containers_types";

            var rows = SQLiteService.ExecuteQuery(sql);
            var typesDataset = rows.Select(ContainerTypeMapper.FromRow).ToList();

            for (int i = 0; i < typesDataset.Count; i++)
            {
                Debug.WriteLine($"TIPO ----->> {typesDataset[i]}");
            }

            InputSelectType.DataSource = typesDataset;
            InputSelectType.DisplayMember = "DisplayText";
            InputSelectType.ValueMember = "Id";
            InputSelectType.SelectedIndex = -1;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            InputSelectType.Focus();
        }

        private void ButtonUUID_MouseClick(object sender, MouseEventArgs e)
        {
            string uuid = UuidGenerator.Generate();
            InputUUID.Text = uuid;
        }
    }
}
