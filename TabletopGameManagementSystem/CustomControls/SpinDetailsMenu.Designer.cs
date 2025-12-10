namespace TabletopGameManagementSystem.CustomControls
{
    partial class SpinDetailsMenu
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
            label3 = new Label();
            back_btn = new Button();
            filterLayoutPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // filterLayoutPanel
            // 
            filterLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            filterLayoutPanel.ColumnCount = 1;
            filterLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            filterLayoutPanel.Controls.Add(label1, 0, 0);
            filterLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 1);
            filterLayoutPanel.Location = new Point(2, 2);
            filterLayoutPanel.Margin = new Padding(2);
            filterLayoutPanel.Name = "filterLayoutPanel";
            filterLayoutPanel.RowCount = 2;
            filterLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.4241648F));
            filterLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 84.5758362F));
            filterLayoutPanel.Size = new Size(275, 389);
            filterLayoutPanel.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(12, 192, 223);
            label1.Location = new Point(60, 16);
            label1.Name = "label1";
            label1.Size = new Size(154, 27);
            label1.TabIndex = 0;
            label1.Text = "Game Title";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.4933929F));
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(back_btn, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(20, 63);
            tableLayoutPanel1.Margin = new Padding(20, 3, 20, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.23529F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 269F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel1.Size = new Size(235, 323);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 12F);
            label3.ForeColor = Color.FromArgb(12, 192, 223);
            label3.Location = new Point(72, 0);
            label3.Name = "label3";
            label3.Size = new Size(90, 19);
            label3.TabIndex = 21;
            label3.Text = "Description";
            // 
            // back_btn
            // 
            back_btn.Anchor = AnchorStyles.None;
            back_btn.Location = new Point(67, 295);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(100, 23);
            back_btn.TabIndex = 22;
            back_btn.Text = "Back";
            back_btn.UseVisualStyleBackColor = true;
            // 
            // SpinDetailsMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(filterLayoutPanel);
            Name = "SpinDetailsMenu";
            Size = new Size(279, 389);
            filterLayoutPanel.ResumeLayout(false);
            filterLayoutPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel filterLayoutPanel;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label3;
        private Button back_btn;
    }
}
