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
            numericUpDownAge = new NumericUpDown();
            label5 = new Label();
            label2 = new Label();
            numericUpDownPlayers = new NumericUpDown();
            label3 = new Label();
            label6 = new Label();
            numericUpDownGameCount = new NumericUpDown();
            label4 = new Label();
            numericUpDownPlayTime = new NumericUpDown();
            label8 = new Label();
            categoryCheckedListBox = new CheckedListBox();
            collectionCheckedListBox = new CheckedListBox();
            filterLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGameCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPlayTime).BeginInit();
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
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.88285F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.1171532F));
            tableLayoutPanel1.Controls.Add(numericUpDownAge, 1, 1);
            tableLayoutPanel1.Controls.Add(label5, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(numericUpDownPlayers, 1, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 5);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(numericUpDownGameCount, 1, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(numericUpDownPlayTime, 1, 3);
            tableLayoutPanel1.Controls.Add(label8, 0, 2);
            tableLayoutPanel1.Controls.Add(categoryCheckedListBox, 1, 2);
            tableLayoutPanel1.Controls.Add(collectionCheckedListBox, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 63);
            tableLayoutPanel1.Margin = new Padding(20, 3, 20, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(239, 323);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Anchor = AnchorStyles.None;
            numericUpDownAge.BackColor = SystemColors.ControlDarkDark;
            numericUpDownAge.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownAge.Location = new Point(127, 68);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(109, 23);
            numericUpDownAge.TabIndex = 17;
            numericUpDownAge.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Calisto MT", 14.25F);
            label5.ForeColor = Color.FromArgb(12, 192, 223);
            label5.Location = new Point(3, 57);
            label5.Name = "label5";
            label5.Size = new Size(118, 44);
            label5.TabIndex = 16;
            label5.Text = "Minimum Age";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 14.25F);
            label2.ForeColor = Color.FromArgb(12, 192, 223);
            label2.Location = new Point(3, 15);
            label2.Name = "label2";
            label2.Size = new Size(118, 22);
            label2.TabIndex = 1;
            label2.Text = "Players";
            // 
            // numericUpDownPlayers
            // 
            numericUpDownPlayers.Anchor = AnchorStyles.None;
            numericUpDownPlayers.BackColor = SystemColors.ControlDarkDark;
            numericUpDownPlayers.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownPlayers.Location = new Point(127, 15);
            numericUpDownPlayers.Name = "numericUpDownPlayers";
            numericUpDownPlayers.Size = new Size(109, 23);
            numericUpDownPlayers.TabIndex = 13;
            numericUpDownPlayers.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 14.25F);
            label3.ForeColor = Color.FromArgb(12, 192, 223);
            label3.Location = new Point(3, 283);
            label3.Name = "label3";
            label3.Size = new Size(118, 22);
            label3.TabIndex = 8;
            label3.Text = "Collections";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Calisto MT", 14.25F);
            label6.ForeColor = Color.FromArgb(12, 192, 223);
            label6.Location = new Point(3, 216);
            label6.Name = "label6";
            label6.Size = new Size(118, 44);
            label6.TabIndex = 5;
            label6.Text = "Number of Games";
            // 
            // numericUpDownGameCount
            // 
            numericUpDownGameCount.Anchor = AnchorStyles.None;
            numericUpDownGameCount.BackColor = SystemColors.ControlDarkDark;
            numericUpDownGameCount.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownGameCount.Location = new Point(127, 227);
            numericUpDownGameCount.Name = "numericUpDownGameCount";
            numericUpDownGameCount.Size = new Size(109, 23);
            numericUpDownGameCount.TabIndex = 12;
            numericUpDownGameCount.Value = new decimal(new int[] { 4, 0, 0, 0 });
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Calisto MT", 14.25F);
            label4.ForeColor = Color.FromArgb(12, 192, 223);
            label4.Location = new Point(3, 174);
            label4.Name = "label4";
            label4.Size = new Size(118, 22);
            label4.TabIndex = 3;
            label4.Text = "Play Time";
            // 
            // numericUpDownPlayTime
            // 
            numericUpDownPlayTime.Anchor = AnchorStyles.None;
            numericUpDownPlayTime.BackColor = SystemColors.ControlDarkDark;
            numericUpDownPlayTime.BorderStyle = BorderStyle.FixedSingle;
            numericUpDownPlayTime.Location = new Point(127, 174);
            numericUpDownPlayTime.Name = "numericUpDownPlayTime";
            numericUpDownPlayTime.Size = new Size(109, 23);
            numericUpDownPlayTime.TabIndex = 11;
            numericUpDownPlayTime.Value = new decimal(new int[] { 60, 0, 0, 0 });
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Calisto MT", 14.25F);
            label8.ForeColor = Color.FromArgb(12, 192, 223);
            label8.Location = new Point(3, 121);
            label8.Name = "label8";
            label8.Size = new Size(118, 22);
            label8.TabIndex = 7;
            label8.Text = "Categories";
            // 
            // categoryCheckedListBox
            // 
            categoryCheckedListBox.FormattingEnabled = true;
            categoryCheckedListBox.Location = new Point(127, 109);
            categoryCheckedListBox.Name = "categoryCheckedListBox";
            categoryCheckedListBox.Size = new Size(109, 40);
            categoryCheckedListBox.TabIndex = 18;
            // 
            // collectionCheckedListBox
            // 
            collectionCheckedListBox.FormattingEnabled = true;
            collectionCheckedListBox.Location = new Point(127, 268);
            collectionCheckedListBox.Name = "collectionCheckedListBox";
            collectionCheckedListBox.Size = new Size(109, 40);
            collectionCheckedListBox.TabIndex = 19;
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
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownGameCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPlayTime).EndInit();
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
        private NumericUpDown numericUpDownPlayTime;
        private NumericUpDown numericUpDownGameCount;
        private NumericUpDown numericUpDownPlayers;
        private NumericUpDown numericUpDownAge;
        private Label label5;
        private CheckedListBox categoryCheckedListBox;
        private CheckedListBox collectionCheckedListBox;
    }
}
