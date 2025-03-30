namespace VRCContainerAutomationApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            footerMain = new Panel();
            buttonSubmit = new Button();
            headerMain = new Panel();
            labelHeader = new Label();
            comboBoxContainerType = new ComboBox();
            labelContainerType = new Label();
            textBoxHeight = new TextBox();
            textBoxWeight = new TextBox();
            labelHeight = new Label();
            labelWeight = new Label();
            formContent = new Panel();
            panel1 = new Panel();
            buttonUUID = new Button();
            labelUUID = new Label();
            textBoxUUID = new TextBox();
            footerMain.SuspendLayout();
            headerMain.SuspendLayout();
            formContent.SuspendLayout();
            SuspendLayout();
            // 
            // footerMain
            // 
            footerMain.BackColor = Color.WhiteSmoke;
            footerMain.BorderStyle = BorderStyle.FixedSingle;
            footerMain.Controls.Add(buttonSubmit);
            footerMain.Dock = DockStyle.Bottom;
            footerMain.Location = new Point(0, 401);
            footerMain.Name = "footerMain";
            footerMain.Padding = new Padding(16, 12, 16, 12);
            footerMain.Size = new Size(784, 60);
            footerMain.TabIndex = 0;
            // 
            // buttonSubmit
            // 
            buttonSubmit.AutoSize = true;
            buttonSubmit.BackColor = Color.White;
            buttonSubmit.BackgroundImageLayout = ImageLayout.None;
            buttonSubmit.Dock = DockStyle.Right;
            buttonSubmit.FlatAppearance.BorderSize = 2;
            buttonSubmit.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSubmit.ForeColor = Color.Black;
            buttonSubmit.Image = Properties.Resources.warehouse_icon;
            buttonSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSubmit.Location = new Point(655, 12);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.RightToLeft = RightToLeft.No;
            buttonSubmit.Size = new Size(111, 34);
            buttonSubmit.TabIndex = 4;
            buttonSubmit.Text = "Armazenar";
            buttonSubmit.TextAlign = ContentAlignment.MiddleRight;
            buttonSubmit.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonSubmit.UseVisualStyleBackColor = false;
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
            headerMain.TabIndex = 1;
            // 
            // labelHeader
            // 
            labelHeader.BackColor = Color.Transparent;
            labelHeader.Dock = DockStyle.Bottom;
            labelHeader.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelHeader.Location = new Point(16, 10);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(750, 36);
            labelHeader.TabIndex = 0;
            labelHeader.Text = "Informe os dados do container para prosseguir com o armazenamento";
            labelHeader.TextAlign = ContentAlignment.MiddleLeft;
            labelHeader.Click += label1_Click_1;
            // 
            // comboBoxContainerType
            // 
            comboBoxContainerType.Font = new Font("Arial", 9.75F);
            comboBoxContainerType.ForeColor = Color.Black;
            comboBoxContainerType.FormattingEnabled = true;
            comboBoxContainerType.Location = new Point(26, 50);
            comboBoxContainerType.Name = "comboBoxContainerType";
            comboBoxContainerType.Size = new Size(416, 24);
            comboBoxContainerType.TabIndex = 0;
            // 
            // labelContainerType
            // 
            labelContainerType.AutoSize = true;
            labelContainerType.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            labelContainerType.ForeColor = Color.Black;
            labelContainerType.Location = new Point(26, 30);
            labelContainerType.Name = "labelContainerType";
            labelContainerType.Size = new Size(35, 16);
            labelContainerType.TabIndex = 3;
            labelContainerType.Text = "Tipo";
            // 
            // textBoxHeight
            // 
            textBoxHeight.Font = new Font("Arial", 9.75F);
            textBoxHeight.ForeColor = Color.Black;
            textBoxHeight.Location = new Point(26, 110);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(416, 22);
            textBoxHeight.TabIndex = 1;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Font = new Font("Arial", 9.75F);
            textBoxWeight.ForeColor = Color.Black;
            textBoxWeight.Location = new Point(26, 170);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(416, 22);
            textBoxWeight.TabIndex = 2;
            // 
            // labelHeight
            // 
            labelHeight.AutoSize = true;
            labelHeight.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            labelHeight.ForeColor = Color.Black;
            labelHeight.Location = new Point(26, 90);
            labelHeight.Name = "labelHeight";
            labelHeight.Size = new Size(45, 16);
            labelHeight.TabIndex = 6;
            labelHeight.Text = "Altura";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            labelWeight.ForeColor = Color.Black;
            labelWeight.Location = new Point(26, 150);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(38, 16);
            labelWeight.TabIndex = 7;
            labelWeight.Text = "Peso";
            // 
            // formContent
            // 
            formContent.BackColor = Color.White;
            formContent.Controls.Add(panel1);
            formContent.Controls.Add(buttonUUID);
            formContent.Controls.Add(labelUUID);
            formContent.Controls.Add(textBoxUUID);
            formContent.Controls.Add(textBoxHeight);
            formContent.Controls.Add(labelWeight);
            formContent.Controls.Add(comboBoxContainerType);
            formContent.Controls.Add(labelHeight);
            formContent.Controls.Add(labelContainerType);
            formContent.Controls.Add(textBoxWeight);
            formContent.Dock = DockStyle.Fill;
            formContent.Location = new Point(0, 60);
            formContent.Margin = new Padding(0);
            formContent.Name = "formContent";
            formContent.Size = new Size(784, 341);
            formContent.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = Properties.Resources.vrc_logo;
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Location = new Point(484, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 238);
            panel1.TabIndex = 13;
            // 
            // buttonUUID
            // 
            buttonUUID.BackColor = Color.White;
            buttonUUID.BackgroundImageLayout = ImageLayout.None;
            buttonUUID.FlatAppearance.BorderColor = Color.Red;
            buttonUUID.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUUID.ForeColor = Color.Black;
            buttonUUID.Location = new Point(362, 258);
            buttonUUID.Name = "buttonUUID";
            buttonUUID.Size = new Size(80, 30);
            buttonUUID.TabIndex = 3;
            buttonUUID.Text = "Gerar ID";
            buttonUUID.UseVisualStyleBackColor = false;
            // 
            // labelUUID
            // 
            labelUUID.AutoSize = true;
            labelUUID.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            labelUUID.ForeColor = Color.Black;
            labelUUID.Location = new Point(26, 210);
            labelUUID.Name = "labelUUID";
            labelUUID.Size = new Size(60, 16);
            labelUUID.TabIndex = 9;
            labelUUID.Text = "ID Único";
            // 
            // textBoxUUID
            // 
            textBoxUUID.Font = new Font("Arial", 9.75F);
            textBoxUUID.ForeColor = Color.Black;
            textBoxUUID.Location = new Point(26, 230);
            textBoxUUID.Name = "textBoxUUID";
            textBoxUUID.ReadOnly = true;
            textBoxUUID.Size = new Size(416, 22);
            textBoxUUID.TabIndex = 0;
            textBoxUUID.TabStop = false;
            textBoxUUID.TextChanged += textBoxUUID_TextChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(784, 461);
            Controls.Add(formContent);
            Controls.Add(headerMain);
            Controls.Add(footerMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "MainForm";
            Text = "VRC Warehouse Technologies";
            TopMost = true;
            Load += MainForm_Load;
            footerMain.ResumeLayout(false);
            footerMain.PerformLayout();
            headerMain.ResumeLayout(false);
            formContent.ResumeLayout(false);
            formContent.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel footerMain;
        private Panel headerMain;
        private ComboBox comboBoxContainerType;
        private Label labelContainerType;
        private TextBox textBoxHeight;
        private TextBox textBoxWeight;
        private Label labelHeight;
        private Label labelWeight;
        private Panel formContent;
        private Label labelUUID;
        private TextBox textBoxUUID;
        private Button buttonUUID;
        private Button buttonSubmit;
        private Label labelHeader;
        private Panel panel1;
    }
}
