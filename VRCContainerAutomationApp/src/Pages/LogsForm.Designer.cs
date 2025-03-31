namespace VRCContainerAutomationApp.src.Pages
{
    partial class LogsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogsForm));
            ListLogs = new ListBox();
            headerMain = new Panel();
            label1 = new Label();
            labelUUID = new Label();
            labelHeader = new Label();
            footerMain = new Panel();
            buttonExit = new Button();
            panelContent = new Panel();
            headerMain.SuspendLayout();
            footerMain.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // ListLogs
            // 
            ListLogs.Dock = DockStyle.Fill;
            ListLogs.FormattingEnabled = true;
            ListLogs.Location = new Point(3, 3);
            ListLogs.Name = "ListLogs";
            ListLogs.ScrollAlwaysVisible = true;
            ListLogs.SelectionMode = SelectionMode.None;
            ListLogs.Size = new Size(778, 358);
            ListLogs.TabIndex = 0;
            // 
            // headerMain
            // 
            headerMain.BackColor = Color.WhiteSmoke;
            headerMain.BorderStyle = BorderStyle.FixedSingle;
            headerMain.Controls.Add(label1);
            headerMain.Controls.Add(labelUUID);
            headerMain.Controls.Add(labelHeader);
            headerMain.Dock = DockStyle.Top;
            headerMain.Location = new Point(0, 0);
            headerMain.Margin = new Padding(0);
            headerMain.Name = "headerMain";
            headerMain.Padding = new Padding(16, 13, 16, 13);
            headerMain.Size = new Size(784, 64);
            headerMain.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Right;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(713, 13);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 3;
            label1.Text = "UUID: ";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelUUID
            // 
            labelUUID.AutoSize = true;
            labelUUID.BackColor = Color.Transparent;
            labelUUID.Dock = DockStyle.Right;
            labelUUID.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUUID.Location = new Point(766, 13);
            labelUUID.Name = "labelUUID";
            labelUUID.Size = new Size(0, 18);
            labelUUID.TabIndex = 2;
            labelUUID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelHeader
            // 
            labelHeader.AutoSize = true;
            labelHeader.BackColor = Color.Transparent;
            labelHeader.Font = new Font("Arial", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            labelHeader.Location = new Point(11, 23);
            labelHeader.Name = "labelHeader";
            labelHeader.Size = new Size(209, 17);
            labelHeader.TabIndex = 1;
            labelHeader.Text = "LOG de operação do container";
            labelHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // footerMain
            // 
            footerMain.BackColor = Color.WhiteSmoke;
            footerMain.BorderStyle = BorderStyle.FixedSingle;
            footerMain.Controls.Add(buttonExit);
            footerMain.Dock = DockStyle.Bottom;
            footerMain.Location = new Point(0, 428);
            footerMain.Name = "footerMain";
            footerMain.Padding = new Padding(16, 13, 16, 13);
            footerMain.Size = new Size(784, 64);
            footerMain.TabIndex = 5;
            // 
            // buttonExit
            // 
            buttonExit.AutoSize = true;
            buttonExit.BackColor = Color.White;
            buttonExit.BackgroundImageLayout = ImageLayout.None;
            buttonExit.Dock = DockStyle.Right;
            buttonExit.FlatAppearance.BorderSize = 2;
            buttonExit.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonExit.ForeColor = Color.Black;
            buttonExit.Image = Properties.Resources.cancel_icon;
            buttonExit.ImageAlign = ContentAlignment.MiddleLeft;
            buttonExit.Location = new Point(694, 13);
            buttonExit.Name = "buttonExit";
            buttonExit.RightToLeft = RightToLeft.No;
            buttonExit.Size = new Size(72, 36);
            buttonExit.TabIndex = 2;
            buttonExit.Text = "Sair";
            buttonExit.TextAlign = ContentAlignment.MiddleRight;
            buttonExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(ListLogs);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 64);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(3);
            panelContent.Size = new Size(784, 364);
            panelContent.TabIndex = 6;
            // 
            // LogsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(784, 492);
            Controls.Add(panelContent);
            Controls.Add(footerMain);
            Controls.Add(headerMain);
            Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(800, 531);
            MinimizeBox = false;
            MinimumSize = new Size(800, 531);
            Name = "LogsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VRC Warehouse Technologies";
            Load += LogsForm_Load;
            headerMain.ResumeLayout(false);
            headerMain.PerformLayout();
            footerMain.ResumeLayout(false);
            footerMain.PerformLayout();
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox ListLogs;
        private Panel headerMain;
        private Label labelHeader;
        private Panel footerMain;
        private Button buttonExit;
        private Panel panelContent;
        private Label labelUUID;
        private Label label1;
    }
}