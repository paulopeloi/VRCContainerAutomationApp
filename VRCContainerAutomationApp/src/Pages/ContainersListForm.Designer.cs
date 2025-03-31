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
            headerMain.Padding = new Padding(16, 12, 16, 12);
            headerMain.Size = new Size(784, 60);
            headerMain.TabIndex = 2;
            // 
            // labelHeader
            // 
            labelHeader.BackColor = Color.Transparent;
            labelHeader.Dock = DockStyle.Bottom;
            labelHeader.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelHeader.Location = new Point(16, 10);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(750, 36);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "Containers armazenados";
            labelHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // footerMain
            // 
            footerMain.BackColor = Color.WhiteSmoke;
            footerMain.BorderStyle = BorderStyle.FixedSingle;
            footerMain.Controls.Add(ButtonDispatch);
            footerMain.Controls.Add(ButtonLocation);
            footerMain.Dock = DockStyle.Bottom;
            footerMain.Location = new Point(0, 401);
            footerMain.Name = "footerMain";
            footerMain.Padding = new Padding(16, 12, 16, 12);
            footerMain.Size = new Size(784, 60);
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
            ButtonDispatch.Location = new Point(531, 12);
            ButtonDispatch.Name = "ButtonDispatch";
            ButtonDispatch.RightToLeft = RightToLeft.No;
            ButtonDispatch.Size = new Size(111, 34);
            ButtonDispatch.TabIndex = 0;
            ButtonDispatch.Text = "Despachar";
            ButtonDispatch.TextAlign = ContentAlignment.MiddleRight;
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
            ButtonLocation.Location = new Point(648, 12);
            ButtonLocation.Name = "ButtonLocation";
            ButtonLocation.RightToLeft = RightToLeft.No;
            ButtonLocation.Size = new Size(118, 34);
            ButtonLocation.TabIndex = 1;
            ButtonLocation.Text = "Localização";
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
            dataGridContainers.Location = new Point(0, 60);
            dataGridContainers.Name = "dataGridContainers";
            dataGridContainers.Size = new Size(784, 341);
            dataGridContainers.TabIndex = 4;
            // 
            // ContainersListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 461);
            Controls.Add(dataGridContainers);
            Controls.Add(footerMain);
            Controls.Add(headerMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(800, 500);
            MinimumSize = new Size(800, 500);
            Name = "ContainersListForm";
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
    }
}