namespace VRCContainerAutomationApp
{
    partial class ContainersListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContainersListForm));
            headerMain = new Panel();
            labelHeader = new Label();
            footerMain = new Panel();
            ButtonDispatch = new Button();
            ButtonLocation = new Button();
            dataGridContainers = new DataGridView();
            ButtonLogs = new Button();
            headerMain.SuspendLayout();
            footerMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridContainers).BeginInit();
            SuspendLayout();
            // 
            // headerMain
            // 
            headerMain.BackColor = Color.WhiteSmoke;
            headerMain.BorderStyle = BorderStyle.FixedSingle;
            headerMain.Controls.Add(labelHeader);
            headerMain.Dock = DockStyle.Top;
            headerMain.Location = new Point(0, 0);
            headerMain.Margin = new Padding(0);
            headerMain.Name = "headerMain";
            headerMain.Padding = new Padding(16, 13, 16, 13);
            headerMain.Size = new Size(784, 64);
            headerMain.TabIndex = 2;
            // 
            // labelHeader
            // 
            labelHeader.BackColor = Color.Transparent;
            labelHeader.Dock = DockStyle.Bottom;
            labelHeader.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelHeader.Location = new Point(16, 11);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(750, 38);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "Containers armazenados";
            labelHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // footerMain
            // 
            footerMain.BackColor = Color.WhiteSmoke;
            footerMain.BorderStyle = BorderStyle.FixedSingle;
            footerMain.Controls.Add(ButtonLogs);
            footerMain.Controls.Add(ButtonDispatch);
            footerMain.Controls.Add(ButtonLocation);
            footerMain.Dock = DockStyle.Bottom;
            footerMain.Location = new Point(0, 428);
            footerMain.Name = "footerMain";
            footerMain.Padding = new Padding(16, 13, 16, 13);
            footerMain.Size = new Size(784, 64);
            footerMain.TabIndex = 3;
            // 
            // ButtonDispatch
            // 
            ButtonDispatch.AutoSize = true;
            ButtonDispatch.BackColor = Color.White;
            ButtonDispatch.BackgroundImageLayout = ImageLayout.None;
            ButtonDispatch.FlatAppearance.BorderSize = 2;
            ButtonDispatch.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonDispatch.ForeColor = Color.Black;
            ButtonDispatch.Image = Properties.Resources.dispatch_icon;
            ButtonDispatch.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonDispatch.Location = new Point(520, 13);
            ButtonDispatch.Name = "ButtonDispatch";
            ButtonDispatch.RightToLeft = RightToLeft.No;
            ButtonDispatch.Size = new Size(120, 36);
            ButtonDispatch.TabIndex = 0;
            ButtonDispatch.Text = "Despachar";
            ButtonDispatch.TextImageRelation = TextImageRelation.ImageBeforeText;
            ButtonDispatch.UseVisualStyleBackColor = false;
            ButtonDispatch.Click += ButtonDispatch_Click;
            // 
            // ButtonLocation
            // 
            ButtonLocation.AutoSize = true;
            ButtonLocation.BackColor = Color.White;
            ButtonLocation.BackgroundImageLayout = ImageLayout.None;
            ButtonLocation.Dock = DockStyle.Right;
            ButtonLocation.FlatAppearance.BorderSize = 2;
            ButtonLocation.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonLocation.ForeColor = Color.Black;
            ButtonLocation.Image = Properties.Resources.location_icon;
            ButtonLocation.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonLocation.Location = new Point(646, 13);
            ButtonLocation.Name = "ButtonLocation";
            ButtonLocation.RightToLeft = RightToLeft.No;
            ButtonLocation.Size = new Size(120, 36);
            ButtonLocation.TabIndex = 1;
            ButtonLocation.Text = "Trocar Local";
            ButtonLocation.TextAlign = ContentAlignment.MiddleRight;
            ButtonLocation.TextImageRelation = TextImageRelation.ImageBeforeText;
            ButtonLocation.UseVisualStyleBackColor = false;
            ButtonLocation.Click += ButtonLocation_Click;
            // 
            // dataGridContainers
            // 
            dataGridContainers.BackgroundColor = Color.White;
            dataGridContainers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridContainers.Dock = DockStyle.Fill;
            dataGridContainers.Location = new Point(0, 64);
            dataGridContainers.Name = "dataGridContainers";
            dataGridContainers.Size = new Size(784, 364);
            dataGridContainers.TabIndex = 4;
            // 
            // ButtonLogs
            // 
            ButtonLogs.AutoSize = true;
            ButtonLogs.BackColor = Color.White;
            ButtonLogs.BackgroundImageLayout = ImageLayout.None;
            ButtonLogs.Dock = DockStyle.Left;
            ButtonLogs.FlatAppearance.BorderSize = 2;
            ButtonLogs.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonLogs.ForeColor = Color.Black;
            ButtonLogs.Image = Properties.Resources.logs_icon;
            ButtonLogs.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonLogs.Location = new Point(16, 13);
            ButtonLogs.Name = "ButtonLogs";
            ButtonLogs.RightToLeft = RightToLeft.No;
            ButtonLogs.Size = new Size(73, 36);
            ButtonLogs.TabIndex = 2;
            ButtonLogs.Text = "LOG";
            ButtonLogs.TextImageRelation = TextImageRelation.ImageBeforeText;
            ButtonLogs.UseVisualStyleBackColor = false;
            ButtonLogs.Click += ButtonLogs_Click;
            // 
            // ContainersListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 492);
            Controls.Add(dataGridContainers);
            Controls.Add(footerMain);
            Controls.Add(headerMain);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(800, 531);
            MinimizeBox = false;
            MinimumSize = new Size(800, 531);
            Name = "ContainersListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VRC Warehouse Technologies";
            Load += ContainersListForm_Load;
            headerMain.ResumeLayout(false);
            footerMain.ResumeLayout(false);
            footerMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridContainers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel headerMain;
        private Panel footerMain;
        private Label labelHeader;
        private DataGridView dataGridContainers;
        private Button ButtonDispatch;
        private Button ButtonLocation;
        private Button ButtonLogs;
    }
}