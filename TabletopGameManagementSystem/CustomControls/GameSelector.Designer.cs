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
            spinCardPanel = new TableLayoutPanel();
            spin_btn = new Button();
            selectorLayoutPanel.SuspendLayout();
            spinCardPanel.SuspendLayout();
            SuspendLayout();
            // 
            // selectorLayoutPanel
            // 
            selectorLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            selectorLayoutPanel.BackgroundImage = Properties.Resources.spinner1;
            selectorLayoutPanel.BackgroundImageLayout = ImageLayout.Zoom;
            selectorLayoutPanel.ColumnCount = 1;
            selectorLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            selectorLayoutPanel.Controls.Add(spinCardPanel, 0, 0);
            selectorLayoutPanel.Location = new Point(0, 0);
            selectorLayoutPanel.Name = "selectorLayoutPanel";
            selectorLayoutPanel.RowCount = 1;
            selectorLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            selectorLayoutPanel.Size = new Size(430, 430);
            selectorLayoutPanel.TabIndex = 0;
            // 
            // spinCardPanel
            // 
            spinCardPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            spinCardPanel.BackgroundImageLayout = ImageLayout.Stretch;
            spinCardPanel.ColumnCount = 3;
            spinCardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            spinCardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            spinCardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            spinCardPanel.Controls.Add(spin_btn, 1, 1);
            spinCardPanel.Location = new Point(0, 0);
            spinCardPanel.Margin = new Padding(0);
            spinCardPanel.Name = "spinCardPanel";
            spinCardPanel.RowCount = 3;
            spinCardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            spinCardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            spinCardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            spinCardPanel.Size = new Size(430, 430);
            spinCardPanel.TabIndex = 2;
            // 
            // spin_btn
            // 
            spin_btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            spin_btn.AutoSize = true;
            spin_btn.BackColor = Color.Black;
            spin_btn.BackgroundImageLayout = ImageLayout.Zoom;
            spin_btn.FlatAppearance.BorderColor = Color.Cyan;
            spin_btn.FlatAppearance.BorderSize = 2;
            spin_btn.FlatStyle = FlatStyle.Flat;
            spin_btn.Font = new Font("Broadway", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            spin_btn.ForeColor = SystemColors.ButtonFace;
            spin_btn.Location = new Point(146, 146);
            spin_btn.Name = "spin_btn";
            spin_btn.Size = new Size(137, 137);
            spin_btn.TabIndex = 0;
            spin_btn.Text = "Spin";
            spin_btn.UseCompatibleTextRendering = true;
            spin_btn.UseVisualStyleBackColor = false;
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
            Size = new Size(430, 430);
            selectorLayoutPanel.ResumeLayout(false);
            spinCardPanel.ResumeLayout(false);
            spinCardPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel selectorLayoutPanel;
        private TableLayoutPanel spinCardPanel;
        private Button spin_btn;
    }
}
