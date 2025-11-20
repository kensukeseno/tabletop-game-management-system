namespace TabletopGameManagementSystem.CustomControls
{
    partial class SelectorMenu
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
            filterLayoutPanel = new TableLayoutPanel();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            gameTypes_select_btn = new Button();
            categories_select_btn = new Button();
            filterLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // filterLayoutPanel
            // 
            filterLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            filterLayoutPanel.ColumnCount = 1;
            filterLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            filterLayoutPanel.Controls.Add(label1, 0, 0);
            filterLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 1);
            filterLayoutPanel.Location = new Point(0, 27);
            filterLayoutPanel.Margin = new Padding(2);
            filterLayoutPanel.Name = "filterLayoutPanel";
            filterLayoutPanel.RowCount = 2;
            filterLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4241648F));
            filterLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 84.5758362F));
            filterLayoutPanel.Size = new Size(279, 389);
            filterLayoutPanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 192, 223);
            label1.Location = new Point(69, 16);
            label1.Name = "label1";
            label1.Size = new Size(140, 27);
            label1.TabIndex = 0;
            label1.Text = "Spin Deck";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.8828468F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.1171532F));
            tableLayoutPanel1.Controls.Add(categories_select_btn, 1, 4);
            tableLayoutPanel1.Controls.Add(gameTypes_select_btn, 1, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 4);
            tableLayoutPanel1.Controls.Add(numericUpDown1, 1, 2);
            tableLayoutPanel1.Controls.Add(numericUpDown2, 1, 3);
            tableLayoutPanel1.Controls.Add(numericUpDown3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 63);
            tableLayoutPanel1.Margin = new Padding(20, 3, 20, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(239, 323);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 14.25F);
            label2.ForeColor = Color.FromArgb(12, 192, 223);
            label2.Location = new Point(3, 21);
            label2.Name = "label2";
            label2.Size = new Size(118, 22);
            label2.TabIndex = 1;
            label2.Text = "Players";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Calisto MT", 14.25F);
            label8.ForeColor = Color.FromArgb(12, 192, 223);
            label8.Location = new Point(3, 85);
            label8.Name = "label8";
            label8.Size = new Size(118, 22);
            label8.TabIndex = 7;
            label8.Text = "Game Types";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Calisto MT", 14.25F);
            label6.ForeColor = Color.FromArgb(12, 192, 223);
            label6.Location = new Point(3, 202);
            label6.Name = "label6";
            label6.Size = new Size(118, 44);
            label6.TabIndex = 5;
            label6.Text = "Number of Games";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Calisto MT", 14.25F);
            label4.ForeColor = Color.FromArgb(12, 192, 223);
            label4.Location = new Point(3, 149);
            label4.Name = "label4";
            label4.Size = new Size(118, 22);
            label4.TabIndex = 3;
            label4.Text = "Max Time";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 14.25F);
            label3.ForeColor = Color.FromArgb(12, 192, 223);
            label3.Location = new Point(3, 278);
            label3.Name = "label3";
            label3.Size = new Size(118, 22);
            label3.TabIndex = 8;
            label3.Text = "Categories";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.None;
            numericUpDown1.BackColor = SystemColors.ControlDarkDark;
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.Location = new Point(127, 148);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(109, 23);
            numericUpDown1.TabIndex = 11;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Anchor = AnchorStyles.None;
            numericUpDown2.BackColor = SystemColors.ControlDarkDark;
            numericUpDown2.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown2.Location = new Point(127, 212);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(109, 23);
            numericUpDown2.TabIndex = 12;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Anchor = AnchorStyles.None;
            numericUpDown3.BackColor = SystemColors.ControlDarkDark;
            numericUpDown3.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown3.Location = new Point(127, 20);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(109, 23);
            numericUpDown3.TabIndex = 13;
            // 
            // gameTypes_select_btn
            // 
            gameTypes_select_btn.Anchor = AnchorStyles.None;
            gameTypes_select_btn.BackColor = Color.Transparent;
            gameTypes_select_btn.BackgroundImage = Properties.Resources.grey_square;
            gameTypes_select_btn.BackgroundImageLayout = ImageLayout.Stretch;
            gameTypes_select_btn.FlatAppearance.BorderSize = 0;
            gameTypes_select_btn.FlatStyle = FlatStyle.Flat;
            gameTypes_select_btn.Font = new Font("Broadway", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gameTypes_select_btn.ForeColor = Color.Black;
            gameTypes_select_btn.Location = new Point(124, 83);
            gameTypes_select_btn.Margin = new Padding(0, 12, 0, 0);
            gameTypes_select_btn.Name = "gameTypes_select_btn";
            gameTypes_select_btn.Size = new Size(115, 37);
            gameTypes_select_btn.TabIndex = 14;
            gameTypes_select_btn.Text = "Select";
            gameTypes_select_btn.UseVisualStyleBackColor = false;
            // 
            // categories_select_btn
            // 
            categories_select_btn.Anchor = AnchorStyles.None;
            categories_select_btn.BackColor = Color.Transparent;
            categories_select_btn.BackgroundImage = Properties.Resources.grey_square;
            categories_select_btn.BackgroundImageLayout = ImageLayout.Stretch;
            categories_select_btn.FlatAppearance.BorderSize = 0;
            categories_select_btn.FlatStyle = FlatStyle.Flat;
            categories_select_btn.Font = new Font("Broadway", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categories_select_btn.ForeColor = Color.Black;
            categories_select_btn.Location = new Point(124, 277);
            categories_select_btn.Margin = new Padding(0, 12, 0, 0);
            categories_select_btn.Name = "categories_select_btn";
            categories_select_btn.Size = new Size(115, 37);
            categories_select_btn.TabIndex = 15;
            categories_select_btn.Text = "Select";
            categories_select_btn.UseVisualStyleBackColor = false;
            // 
            // SelectorMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.dk_grey_square;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(filterLayoutPanel);
            DoubleBuffered = true;
            Name = "SelectorMenu";
            Size = new Size(279, 443);
            filterLayoutPanel.ResumeLayout(false);
            filterLayoutPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel filterLayoutPanel;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label6;
        private Label label4;
        private Label label2;
        private Label label8;
        private Label label3;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Button categories_select_btn;
        private Button gameTypes_select_btn;
    }
}
