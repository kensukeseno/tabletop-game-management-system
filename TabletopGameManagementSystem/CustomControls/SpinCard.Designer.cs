namespace TabletopGameManagementSystem.CustomControls
{
    partial class SpinCard
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
            titleLabel = new Label();
            details_btn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            titleLabel.AutoSize = true;
            titleLabel.ForeColor = Color.FromArgb(12, 192, 223);
            titleLabel.Location = new Point(3, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(120, 60);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "game title";
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // details_btn
            // 
            details_btn.Anchor = AnchorStyles.None;
            details_btn.FlatStyle = FlatStyle.Flat;
            details_btn.ForeColor = Color.FromArgb(12, 192, 223);
            details_btn.Location = new Point(23, 69);
            details_btn.Name = "details_btn";
            details_btn.Size = new Size(79, 42);
            details_btn.TabIndex = 1;
            details_btn.Text = "Details";
            details_btn.UseVisualStyleBackColor = true;
            details_btn.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(titleLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(details_btn, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 16);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(126, 120);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // SpinCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.grey_square;
            BackgroundImageLayout = ImageLayout.Zoom;
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Name = "SpinCard";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label titleLabel;
        private Button details_btn;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
