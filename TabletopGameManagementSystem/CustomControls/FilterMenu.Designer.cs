namespace TabletopGameManagementSystem.CustomControls
{
    partial class FilterMenu
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
            apply_filters_btn = new Button();
            button2 = new Button();
            filter_text_box = new TextBox();
            sample_radio_btn = new RadioButton();
            filterLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // filterLayoutPanel
            // 
            filterLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            filterLayoutPanel.ColumnCount = 1;
            filterLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            filterLayoutPanel.Controls.Add(apply_filters_btn, 0, 7);
            filterLayoutPanel.Controls.Add(button2, 0, 0);
            filterLayoutPanel.Controls.Add(filter_text_box, 0, 1);
            filterLayoutPanel.Controls.Add(sample_radio_btn, 0, 2);
            filterLayoutPanel.Location = new Point(0, 27);
            filterLayoutPanel.Margin = new Padding(2);
            filterLayoutPanel.Name = "filterLayoutPanel";
            filterLayoutPanel.RowCount = 8;
            filterLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            filterLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            filterLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            filterLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            filterLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            filterLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            filterLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            filterLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            filterLayoutPanel.Size = new Size(279, 389);
            filterLayoutPanel.TabIndex = 2;
            // 
            // apply_filters_btn
            // 
            apply_filters_btn.Anchor = AnchorStyles.Top;
            apply_filters_btn.BackColor = Color.Transparent;
            apply_filters_btn.BackgroundImage = Properties.Resources.grey_square;
            apply_filters_btn.BackgroundImageLayout = ImageLayout.Stretch;
            apply_filters_btn.FlatAppearance.BorderSize = 0;
            apply_filters_btn.FlatStyle = FlatStyle.Flat;
            apply_filters_btn.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            apply_filters_btn.ForeColor = Color.Black;
            apply_filters_btn.Location = new Point(57, 348);
            apply_filters_btn.Margin = new Padding(0, 12, 0, 0);
            apply_filters_btn.Name = "apply_filters_btn";
            apply_filters_btn.Size = new Size(164, 37);
            apply_filters_btn.TabIndex = 9;
            apply_filters_btn.Text = "Apply";
            apply_filters_btn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(12, 192, 223);
            button2.Location = new Point(0, 12);
            button2.Margin = new Padding(0, 12, 0, 0);
            button2.Name = "button2";
            button2.Size = new Size(279, 36);
            button2.TabIndex = 3;
            button2.Text = "Filter";
            button2.UseVisualStyleBackColor = false;
            // 
            // filter_text_box
            // 
            filter_text_box.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            filter_text_box.BackColor = SystemColors.ActiveBorder;
            filter_text_box.BorderStyle = BorderStyle.None;
            filter_text_box.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            filter_text_box.Location = new Point(20, 50);
            filter_text_box.Margin = new Padding(20, 2, 20, 2);
            filter_text_box.Name = "filter_text_box";
            filter_text_box.Size = new Size(239, 28);
            filter_text_box.TabIndex = 12;
            // 
            // sample_radio_btn
            // 
            sample_radio_btn.Anchor = AnchorStyles.Top;
            sample_radio_btn.AutoSize = true;
            sample_radio_btn.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sample_radio_btn.ForeColor = SystemColors.ActiveBorder;
            sample_radio_btn.Location = new Point(74, 98);
            sample_radio_btn.Margin = new Padding(2);
            sample_radio_btn.Name = "sample_radio_btn";
            sample_radio_btn.Size = new Size(130, 31);
            sample_radio_btn.TabIndex = 13;
            sample_radio_btn.TabStop = true;
            sample_radio_btn.Text = "Sample";
            sample_radio_btn.UseVisualStyleBackColor = true;
            // 
            // FilterMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.dk_grey_square;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(filterLayoutPanel);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "FilterMenu";
            Size = new Size(279, 443);
            filterLayoutPanel.ResumeLayout(false);
            filterLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel filterLayoutPanel;
        private Button apply_filters_btn;
        private Button button2;
        private TextBox filter_text_box;
        private RadioButton sample_radio_btn;
    }
}
