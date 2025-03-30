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
            ButtonSubmit = new Button();
            headerMain = new Panel();
            labelHeader = new Label();
            InputSelectType = new ComboBox();
            labelContainerType = new Label();
            labelHeight = new Label();
            labelWeight = new Label();
            formContent = new Panel();
            InputHeight = new NumericUpDown();
            InputWeight = new NumericUpDown();
            logoVRC = new Panel();
            ButtonUUID = new Button();
            labelUUID = new Label();
            InputUUID = new TextBox();
            footerMain.SuspendLayout();
            headerMain.SuspendLayout();
            formContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InputWeight).BeginInit();
            SuspendLayout();
            // 
            // footerMain
            // 
            footerMain.BackColor = Color.WhiteSmoke;
            footerMain.BorderStyle = BorderStyle.FixedSingle;
            footerMain.Controls.Add(ButtonSubmit);
            footerMain.Dock = DockStyle.Bottom;
            footerMain.Location = new Point(0, 401);
            footerMain.Name = "footerMain";
            footerMain.Padding = new Padding(16, 12, 16, 12);
            footerMain.Size = new Size(784, 60);
            footerMain.TabIndex = 0;
            // 
            // ButtonSubmit
            // 
            ButtonSubmit.AutoSize = true;
            ButtonSubmit.BackColor = Color.White;
            ButtonSubmit.BackgroundImageLayout = ImageLayout.None;
            ButtonSubmit.Dock = DockStyle.Right;
            ButtonSubmit.FlatAppearance.BorderSize = 2;
            ButtonSubmit.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonSubmit.ForeColor = Color.Black;
            ButtonSubmit.Image = Properties.Resources.warehouse_icon;
            ButtonSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonSubmit.Location = new Point(655, 12);
            ButtonSubmit.Name = "ButtonSubmit";
            ButtonSubmit.RightToLeft = RightToLeft.No;
            ButtonSubmit.Size = new Size(111, 34);
            ButtonSubmit.TabIndex = 4;
            ButtonSubmit.Text = "Armazenar";
            ButtonSubmit.TextAlign = ContentAlignment.MiddleRight;
            ButtonSubmit.TextImageRelation = TextImageRelation.ImageBeforeText;
            ButtonSubmit.UseVisualStyleBackColor = false;
            ButtonSubmit.MouseClick += ButtonSubmit_MouseClick;
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
            // 
            // InputSelectType
            // 
            InputSelectType.FlatStyle = FlatStyle.System;
            InputSelectType.Font = new Font("Arial", 9.75F);
            InputSelectType.ForeColor = SystemColors.WindowText;
            InputSelectType.FormattingEnabled = true;
            InputSelectType.Location = new Point(26, 50);
            InputSelectType.Name = "InputSelectType";
            InputSelectType.Size = new Size(416, 24);
            InputSelectType.TabIndex = 0;
            // 
            // labelContainerType
            // 
            labelContainerType.AutoSize = true;
            labelContainerType.BackColor = Color.Transparent;
            labelContainerType.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            labelContainerType.ForeColor = Color.Black;
            labelContainerType.Location = new Point(26, 30);
            labelContainerType.Name = "labelContainerType";
            labelContainerType.Size = new Size(35, 16);
            labelContainerType.TabIndex = 3;
            labelContainerType.Text = "Tipo";
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
            formContent.Controls.Add(InputHeight);
            formContent.Controls.Add(InputWeight);
            formContent.Controls.Add(logoVRC);
            formContent.Controls.Add(ButtonUUID);
            formContent.Controls.Add(labelUUID);
            formContent.Controls.Add(InputUUID);
            formContent.Controls.Add(labelWeight);
            formContent.Controls.Add(InputSelectType);
            formContent.Controls.Add(labelHeight);
            formContent.Controls.Add(labelContainerType);
            formContent.Dock = DockStyle.Fill;
            formContent.Location = new Point(0, 60);
            formContent.Margin = new Padding(0);
            formContent.Name = "formContent";
            formContent.Size = new Size(784, 341);
            formContent.TabIndex = 8;
            // 
            // InputHeight
            // 
            InputHeight.DecimalPlaces = 2;
            InputHeight.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputHeight.ImeMode = ImeMode.NoControl;
            InputHeight.Location = new Point(26, 110);
            InputHeight.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            InputHeight.Name = "InputHeight";
            InputHeight.Size = new Size(416, 22);
            InputHeight.TabIndex = 1;
            InputHeight.ThousandsSeparator = true;
            // 
            // InputWeight
            // 
            InputWeight.DecimalPlaces = 2;
            InputWeight.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InputWeight.ImeMode = ImeMode.NoControl;
            InputWeight.Location = new Point(26, 170);
            InputWeight.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            InputWeight.Name = "InputWeight";
            InputWeight.Size = new Size(416, 22);
            InputWeight.TabIndex = 2;
            InputWeight.ThousandsSeparator = true;
            // 
            // logoVRC
            // 
            logoVRC.BackColor = Color.White;
            logoVRC.BackgroundImage = Properties.Resources.vrc_logo;
            logoVRC.BackgroundImageLayout = ImageLayout.Center;
            logoVRC.Location = new Point(484, 50);
            logoVRC.Name = "logoVRC";
            logoVRC.Size = new Size(259, 238);
            logoVRC.TabIndex = 13;
            // 
            // ButtonUUID
            // 
            ButtonUUID.BackColor = Color.White;
            ButtonUUID.BackgroundImageLayout = ImageLayout.None;
            ButtonUUID.FlatAppearance.BorderColor = Color.Red;
            ButtonUUID.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonUUID.ForeColor = Color.Black;
            ButtonUUID.Location = new Point(362, 258);
            ButtonUUID.Name = "ButtonUUID";
            ButtonUUID.Size = new Size(80, 30);
            ButtonUUID.TabIndex = 3;
            ButtonUUID.Text = "Gerar ID";
            ButtonUUID.UseVisualStyleBackColor = false;
            ButtonUUID.MouseClick += ButtonUUID_MouseClick;
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
            // InputUUID
            // 
            InputUUID.Enabled = false;
            InputUUID.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InputUUID.ForeColor = Color.Black;
            InputUUID.Location = new Point(26, 230);
            InputUUID.Name = "InputUUID";
            InputUUID.ReadOnly = true;
            InputUUID.Size = new Size(416, 22);
            InputUUID.TabIndex = 0;
            InputUUID.TabStop = false;
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
            MinimumSize = new Size(800, 500);
            Name = "MainForm";
            Text = "VRC Warehouse Technologies";
            TopMost = true;
            Load += MainForm_Load;
            Shown += MainForm_Shown;
            footerMain.ResumeLayout(false);
            footerMain.PerformLayout();
            headerMain.ResumeLayout(false);
            formContent.ResumeLayout(false);
            formContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InputHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)InputWeight).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel footerMain;
        private Panel headerMain;
        private ComboBox InputSelectType;
        private Label labelContainerType;
        private Label labelHeight;
        private Label labelWeight;
        private Panel formContent;
        private Label labelUUID;
        private TextBox InputUUID;
        private Button ButtonUUID;
        private Button ButtonSubmit;
        private Label labelHeader;
        private Panel logoVRC;
        private NumericUpDown InputWeight;
        private NumericUpDown InputHeight;
    }
}
