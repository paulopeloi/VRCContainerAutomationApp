namespace VRCContainerAutomationApp.src.Pages
{
    partial class ChangeLocationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeLocationForm));
            headerMain = new Panel();
            labelHeader = new Label();
            footerMain = new Panel();
            buttonCancel = new Button();
            ButtonConfirm = new Button();
            InputSelectLocation = new ComboBox();
            labelInput = new Label();
            labelData1 = new Label();
            labelData2 = new Label();
            labelData3 = new Label();
            labelUUID = new Label();
            labelDesc = new Label();
            labelType = new Label();
            labelLocation = new Label();
            headerMain.SuspendLayout();
            footerMain.SuspendLayout();
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
            headerMain.Size = new Size(509, 64);
            headerMain.TabIndex = 3;
            // 
            // labelHeader
            // 
            labelHeader.BackColor = Color.Transparent;
            labelHeader.Dock = DockStyle.Bottom;
            labelHeader.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelHeader.Location = new Point(16, 11);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(475, 38);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "Selecione uma nova localização para o container";
            labelHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // footerMain
            // 
            footerMain.BackColor = Color.WhiteSmoke;
            footerMain.BorderStyle = BorderStyle.FixedSingle;
            footerMain.Controls.Add(buttonCancel);
            footerMain.Controls.Add(ButtonConfirm);
            footerMain.Dock = DockStyle.Bottom;
            footerMain.Location = new Point(0, 317);
            footerMain.Name = "footerMain";
            footerMain.Padding = new Padding(16, 13, 16, 13);
            footerMain.Size = new Size(509, 64);
            footerMain.TabIndex = 4;
            // 
            // buttonCancel
            // 
            buttonCancel.AutoSize = true;
            buttonCancel.BackColor = Color.White;
            buttonCancel.BackgroundImageLayout = ImageLayout.None;
            buttonCancel.FlatAppearance.BorderSize = 2;
            buttonCancel.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCancel.ForeColor = Color.Black;
            buttonCancel.Image = Properties.Resources.cancel_icon;
            buttonCancel.ImageAlign = ContentAlignment.MiddleLeft;
            buttonCancel.Location = new Point(282, 13);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.RightToLeft = RightToLeft.No;
            buttonCancel.Size = new Size(100, 36);
            buttonCancel.TabIndex = 2;
            buttonCancel.Text = "Cancelar";
            buttonCancel.TextAlign = ContentAlignment.MiddleRight;
            buttonCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // ButtonConfirm
            // 
            ButtonConfirm.AutoSize = true;
            ButtonConfirm.BackColor = Color.White;
            ButtonConfirm.BackgroundImageLayout = ImageLayout.None;
            ButtonConfirm.Dock = DockStyle.Right;
            ButtonConfirm.FlatAppearance.BorderSize = 2;
            ButtonConfirm.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ButtonConfirm.ForeColor = Color.Black;
            ButtonConfirm.Image = Properties.Resources.check_icon;
            ButtonConfirm.ImageAlign = ContentAlignment.MiddleLeft;
            ButtonConfirm.Location = new Point(387, 13);
            ButtonConfirm.Name = "ButtonConfirm";
            ButtonConfirm.RightToLeft = RightToLeft.No;
            ButtonConfirm.Size = new Size(104, 36);
            ButtonConfirm.TabIndex = 1;
            ButtonConfirm.Text = "Confirmar";
            ButtonConfirm.TextAlign = ContentAlignment.MiddleRight;
            ButtonConfirm.TextImageRelation = TextImageRelation.ImageBeforeText;
            ButtonConfirm.UseVisualStyleBackColor = false;
            ButtonConfirm.Click += ButtonConfirm_Click;
            // 
            // InputSelectLocation
            // 
            InputSelectLocation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InputSelectLocation.FlatStyle = FlatStyle.System;
            InputSelectLocation.Font = new Font("Arial", 9.75F);
            InputSelectLocation.ForeColor = SystemColors.WindowText;
            InputSelectLocation.FormattingEnabled = true;
            InputSelectLocation.Location = new Point(24, 258);
            InputSelectLocation.Name = "InputSelectLocation";
            InputSelectLocation.Size = new Size(468, 24);
            InputSelectLocation.TabIndex = 6;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelInput.Location = new Point(24, 239);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(120, 16);
            labelInput.TabIndex = 7;
            labelInput.Text = "Nova Localização";
            // 
            // labelData1
            // 
            labelData1.AutoSize = true;
            labelData1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelData1.Location = new Point(24, 130);
            labelData1.Name = "labelData1";
            labelData1.Size = new Size(64, 16);
            labelData1.TabIndex = 8;
            labelData1.Text = "ID Único:";
            // 
            // labelData2
            // 
            labelData2.AutoSize = true;
            labelData2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelData2.Location = new Point(24, 160);
            labelData2.Name = "labelData2";
            labelData2.Size = new Size(39, 16);
            labelData2.TabIndex = 9;
            labelData2.Text = "Tipo:";
            // 
            // labelData3
            // 
            labelData3.AutoSize = true;
            labelData3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelData3.Location = new Point(24, 190);
            labelData3.Name = "labelData3";
            labelData3.Size = new Size(125, 16);
            labelData3.TabIndex = 10;
            labelData3.Text = "Localização Atual:";
            // 
            // labelUUID
            // 
            labelUUID.AutoSize = true;
            labelUUID.Font = new Font("Arial", 9.75F);
            labelUUID.Location = new Point(94, 130);
            labelUUID.Name = "labelUUID";
            labelUUID.Size = new Size(11, 16);
            labelUUID.TabIndex = 11;
            labelUUID.Text = " ";
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDesc.Location = new Point(24, 92);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(132, 16);
            labelDesc.TabIndex = 12;
            labelDesc.Text = "Dados do Container";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Arial", 9.75F);
            labelType.Location = new Point(69, 160);
            labelType.Name = "labelType";
            labelType.Size = new Size(11, 16);
            labelType.TabIndex = 13;
            labelType.Text = " ";
            // 
            // labelLocation
            // 
            labelLocation.AutoSize = true;
            labelLocation.Font = new Font("Arial", 9.75F);
            labelLocation.Location = new Point(155, 190);
            labelLocation.Name = "labelLocation";
            labelLocation.Size = new Size(11, 16);
            labelLocation.TabIndex = 14;
            labelLocation.Text = " ";
            // 
            // ChangeLocationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(509, 381);
            Controls.Add(labelLocation);
            Controls.Add(labelType);
            Controls.Add(labelDesc);
            Controls.Add(labelUUID);
            Controls.Add(labelData3);
            Controls.Add(labelData2);
            Controls.Add(labelData1);
            Controls.Add(labelInput);
            Controls.Add(InputSelectLocation);
            Controls.Add(footerMain);
            Controls.Add(headerMain);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(525, 420);
            MinimizeBox = false;
            MinimumSize = new Size(525, 420);
            Name = "ChangeLocationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VRC Warehouse Technologies";
            Load += ChangeLocationForm_Load;
            headerMain.ResumeLayout(false);
            footerMain.ResumeLayout(false);
            footerMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel headerMain;
        private Label labelHeader;
        private Panel footerMain;
        private Button ButtonConfirm;
        private Button buttonCancel;
        private ComboBox InputSelectLocation;
        private Label labelInput;
        private Label labelData1;
        private Label labelData2;
        private Label labelData3;
        private Label labelUUID;
        private Label labelDesc;
        private Label labelType;
        private Label labelLocation;
    }
}