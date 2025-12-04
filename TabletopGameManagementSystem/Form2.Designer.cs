namespace TabletopGameManagementSystem
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            form2Panel = new TableLayoutPanel();
            headerPanel = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            titleLabel = new Label();
            navMenu1 = new TabletopGameManagementSystem.CustomControls.NavMenu();
            panelMain = new Panel();
            form2Panel.SuspendLayout();
            headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // form2Panel
            // 
            form2Panel.ColumnCount = 2;
            form2Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.6047573F));
            form2Panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.39524F));
            form2Panel.Controls.Add(headerPanel, 1, 0);
            form2Panel.Controls.Add(navMenu1, 0, 1);
            form2Panel.Controls.Add(panelMain, 1, 1);
            form2Panel.Dock = DockStyle.Fill;
            form2Panel.Location = new Point(0, 0);
            form2Panel.Margin = new Padding(3, 4, 3, 4);
            form2Panel.Name = "form2Panel";
            form2Panel.RowCount = 2;
            form2Panel.RowStyles.Add(new RowStyle(SizeType.Percent, 26.0586319F));
            form2Panel.RowStyles.Add(new RowStyle(SizeType.Percent, 73.94137F));
            form2Panel.Size = new Size(1249, 819);
            form2Panel.TabIndex = 0;
            // 
            // headerPanel
            // 
            headerPanel.ColumnCount = 2;
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.31001F));
            headerPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.6899872F));
            headerPanel.Controls.Add(pictureBox1, 1, 0);
            headerPanel.Controls.Add(titleLabel, 0, 0);
            headerPanel.Dock = DockStyle.Fill;
            headerPanel.Location = new Point(297, 4);
            headerPanel.Margin = new Padding(3, 4, 3, 4);
            headerPanel.Name = "headerPanel";
            headerPanel.RowCount = 1;
            headerPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            headerPanel.Size = new Size(949, 205);
            headerPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackgroundImage = Properties.Resources.record_logo_teal;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(640, 3);
            pictureBox1.Margin = new Padding(2, 3, 2, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 199);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Broadway", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleLabel.ForeColor = Color.FromArgb(12, 192, 223);
            titleLabel.Location = new Point(314, 137);
            titleLabel.Margin = new Padding(2, 0, 40, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(284, 68);
            titleLabel.TabIndex = 5;
            titleLabel.Text = "MyShelf";
            // 
            // navMenu1
            // 
            navMenu1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            navMenu1.BackColor = Color.Transparent;
            navMenu1.BackgroundImage = (Image)resources.GetObject("navMenu1.BackgroundImage");
            navMenu1.BackgroundImageLayout = ImageLayout.Stretch;
            navMenu1.Location = new Point(2, 216);
            navMenu1.Margin = new Padding(2, 3, 2, 3);
            navMenu1.Name = "navMenu1";
            navMenu1.Size = new Size(290, 600);
            navMenu1.TabIndex = 1;
            // 
            // panelMain
            // 
            panelMain.Location = new Point(297, 216);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(949, 600);
            panelMain.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1249, 819);
            Controls.Add(form2Panel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "TurnTable";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            form2Panel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel form2Panel;
        private TableLayoutPanel headerPanel;
        private Label titleLabel;
        private PictureBox pictureBox1;
        private CustomControls.NavMenu navMenu1;
        private Panel panelMain;
    }
}