namespace TabletopGameManagementSystem.CustomControls.Views
{
    partial class GameSelector
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
            selectorLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            spin_btn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            selectorLayoutPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // selectorLayoutPanel
            // 
            selectorLayoutPanel.BackgroundImage = Properties.Resources.record_logo_purple;
            selectorLayoutPanel.BackgroundImageLayout = ImageLayout.Zoom;
            selectorLayoutPanel.ColumnCount = 1;
            selectorLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            selectorLayoutPanel.Controls.Add(tableLayoutPanel3, 0, 2);
            selectorLayoutPanel.Controls.Add(tableLayoutPanel2, 0, 1);
            selectorLayoutPanel.Controls.Add(tableLayoutPanel1, 0, 0);
            selectorLayoutPanel.Dock = DockStyle.Fill;
            selectorLayoutPanel.Location = new Point(0, 0);
            selectorLayoutPanel.Name = "selectorLayoutPanel";
            selectorLayoutPanel.RowCount = 3;
            selectorLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            selectorLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            selectorLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            selectorLayoutPanel.Size = new Size(764, 434);
            selectorLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Location = new Point(242, 291);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(279, 140);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel2.BackgroundImageLayout = ImageLayout.Stretch;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(spin_btn, 1, 0);
            tableLayoutPanel2.Location = new Point(162, 147);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(439, 138);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // spin_btn
            // 
            spin_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            spin_btn.BackColor = Color.Black;
            spin_btn.BackgroundImageLayout = ImageLayout.Zoom;
            spin_btn.FlatAppearance.BorderColor = Color.Cyan;
            spin_btn.FlatAppearance.BorderSize = 2;
            spin_btn.FlatStyle = FlatStyle.Flat;
            spin_btn.Font = new Font("Broadway", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            spin_btn.ForeColor = SystemColors.ButtonFace;
            spin_btn.Location = new Point(150, 3);
            spin_btn.Name = "spin_btn";
            spin_btn.Size = new Size(137, 132);
            spin_btn.TabIndex = 0;
            spin_btn.Text = "Spin";
            spin_btn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(238, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(287, 138);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // GameSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(selectorLayoutPanel);
            DoubleBuffered = true;
            Name = "GameSelector";
            Size = new Size(764, 434);
            selectorLayoutPanel.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel selectorLayoutPanel;
        private TableLayoutPanel tableLayoutPanel3;
        //private Button button7;
        //private Button button4;
        private TableLayoutPanel tableLayoutPanel2;
        //private Button button6;
        private Button spin_btn;
        //private Button button5;
        private TableLayoutPanel tableLayoutPanel1;
        //private Button button3;
        //private Button button2;
    }
}
