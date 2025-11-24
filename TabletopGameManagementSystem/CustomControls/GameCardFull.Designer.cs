namespace TabletopGameManagementSystem.CustomControls
{
    partial class GameCardFull
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gameCard_panel = new TableLayoutPanel();
            gamedetails_panel = new TableLayoutPanel();
            label1 = new Label();
            innerGamedetailsPanel = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            gameCard_panel.SuspendLayout();
            gamedetails_panel.SuspendLayout();
            innerGamedetailsPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gameCard_panel
            // 
            gameCard_panel.ColumnCount = 2;
            gameCard_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gameCard_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            gameCard_panel.Controls.Add(gamedetails_panel, 1, 0);
            gameCard_panel.Controls.Add(tableLayoutPanel1, 0, 0);
            gameCard_panel.Dock = DockStyle.Fill;
            gameCard_panel.Location = new Point(0, 0);
            gameCard_panel.Margin = new Padding(3, 2, 3, 2);
            gameCard_panel.Name = "gameCard_panel";
            gameCard_panel.RowCount = 1;
            gameCard_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gameCard_panel.Size = new Size(707, 200);
            gameCard_panel.TabIndex = 0;
            // 
            // gamedetails_panel
            // 
            gamedetails_panel.ColumnCount = 1;
            gamedetails_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            gamedetails_panel.Controls.Add(label1, 0, 0);
            gamedetails_panel.Controls.Add(innerGamedetailsPanel, 0, 1);
            gamedetails_panel.Dock = DockStyle.Fill;
            gamedetails_panel.Location = new Point(356, 22);
            gamedetails_panel.Margin = new Padding(3, 22, 3, 2);
            gamedetails_panel.Name = "gamedetails_panel";
            gamedetails_panel.RowCount = 2;
            gamedetails_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            gamedetails_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            gamedetails_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            gamedetails_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            gamedetails_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            gamedetails_panel.Size = new Size(348, 176);
            gamedetails_panel.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(97, 5);
            label1.Name = "label1";
            label1.Size = new Size(154, 27);
            label1.TabIndex = 0;
            label1.Text = "Game Title";
            // 
            // innerGamedetailsPanel
            // 
            innerGamedetailsPanel.ColumnCount = 2;
            innerGamedetailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            innerGamedetailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            innerGamedetailsPanel.Controls.Add(label3, 1, 0);
            innerGamedetailsPanel.Controls.Add(label2, 0, 0);
            innerGamedetailsPanel.Dock = DockStyle.Fill;
            innerGamedetailsPanel.Location = new Point(3, 40);
            innerGamedetailsPanel.Margin = new Padding(3, 2, 3, 2);
            innerGamedetailsPanel.Name = "innerGamedetailsPanel";
            innerGamedetailsPanel.RowCount = 6;
            innerGamedetailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            innerGamedetailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            innerGamedetailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            innerGamedetailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            innerGamedetailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            innerGamedetailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            innerGamedetailsPanel.Size = new Size(342, 134);
            innerGamedetailsPanel.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 14.25F);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(232, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 22);
            label3.TabIndex = 3;
            label3.Text = "Data";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 14.25F);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(47, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 22);
            label2.TabIndex = 2;
            label2.Text = "Heading";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.BackgroundImage = Properties.Resources.grey_square;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(checkBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(76, 25);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(200, 150);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // checkBox2
            // 
            checkBox2.Anchor = AnchorStyles.Top;
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Broadway", 14.25F);
            checkBox2.Location = new Point(45, 78);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(109, 25);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Wishlist";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.Bottom;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Broadway", 14.25F);
            checkBox1.Location = new Point(46, 47);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 25);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "MyShelf";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // GameCardFull
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.dk_grey_square;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(gameCard_panel);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "GameCardFull";
            Size = new Size(707, 200);
            gameCard_panel.ResumeLayout(false);
            gamedetails_panel.ResumeLayout(false);
            gamedetails_panel.PerformLayout();
            innerGamedetailsPanel.ResumeLayout(false);
            innerGamedetailsPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel gameCard_panel;
        private TableLayoutPanel gamedetails_panel;
        private Label label1;
        private TableLayoutPanel innerGamedetailsPanel;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
    }
}
