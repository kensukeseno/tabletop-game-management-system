namespace TabletopGameManagementSystem.CustomControls
{
    partial class NavMenu
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
            navLayoutPanel = new TableLayoutPanel();
            button5 = new Button();
            button3 = new Button();
            button2 = new Button();
            button8 = new Button();
            button9 = new Button();
            navLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navLayoutPanel
            // 
            navLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            navLayoutPanel.ColumnCount = 1;
            navLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            navLayoutPanel.Controls.Add(button2, 0, 0);
            navLayoutPanel.Controls.Add(button3, 0, 1);
            navLayoutPanel.Controls.Add(button5, 0, 2);
            navLayoutPanel.Controls.Add(button9, 0, 3);
            navLayoutPanel.Controls.Add(button8, 0, 4);
            navLayoutPanel.Location = new Point(0, 34);
            navLayoutPanel.Margin = new Padding(2);
            navLayoutPanel.Name = "navLayoutPanel";
            navLayoutPanel.RowCount = 5;
            navLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.3846188F));
            navLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.3846159F));
            navLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.3846159F));
            navLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.3846159F));
            navLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23.0769234F));
            navLayoutPanel.Size = new Size(279, 389);
            navLayoutPanel.TabIndex = 0;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = SystemColors.ActiveBorder;
            button5.Location = new Point(0, 152);
            button5.Margin = new Padding(0, 12, 0, 0);
            button5.Name = "button5";
            button5.Size = new Size(279, 58);
            button5.TabIndex = 6;
            button5.Text = "Wishlist";
            button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveBorder;
            button3.Location = new Point(0, 82);
            button3.Margin = new Padding(0, 12, 0, 0);
            button3.Name = "button3";
            button3.Size = new Size(279, 58);
            button3.TabIndex = 4;
            button3.Text = "Collections";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveBorder;
            button2.Location = new Point(0, 12);
            button2.Margin = new Padding(0, 12, 0, 0);
            button2.Name = "button2";
            button2.Size = new Size(279, 58);
            button2.TabIndex = 3;
            button2.Text = "My Shelf";
            button2.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button8.BackgroundImage = Properties.Resources.record_logo_purple;
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Broadway", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(3, 283);
            button8.Name = "button8";
            button8.Size = new Size(273, 103);
            button8.TabIndex = 10;
            button8.Text = "Spin";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button9.BackColor = Color.Transparent;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.ForeColor = SystemColors.ActiveBorder;
            button9.Location = new Point(0, 222);
            button9.Margin = new Padding(0, 12, 0, 0);
            button9.Name = "button9";
            button9.Size = new Size(279, 58);
            button9.TabIndex = 11;
            button9.Text = "Games";
            button9.UseVisualStyleBackColor = false;
            // 
            // NavMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.dk_grey_square;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(navLayoutPanel);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "NavMenu";
            Size = new Size(279, 443);
            Load += NavMenu_Load;
            navLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel navLayoutPanel;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button8;
        private Button button9;
    }
}
