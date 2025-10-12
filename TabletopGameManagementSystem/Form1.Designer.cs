namespace TabletopGameManagementSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox2 = new PictureBox();
            startBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.TurnTableLogo_Sq;
            pictureBox2.Location = new Point(13, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(775, 480);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // startBtn
            // 
            startBtn.Anchor = AnchorStyles.Top;
            startBtn.BackColor = Color.Black;
            startBtn.FlatAppearance.BorderColor = Color.DarkSlateBlue;
            startBtn.FlatAppearance.MouseDownBackColor = Color.DarkSlateBlue;
            startBtn.FlatAppearance.MouseOverBackColor = Color.MediumSlateBlue;
            startBtn.FlatStyle = FlatStyle.Flat;
            startBtn.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            startBtn.ForeColor = Color.LightSkyBlue;
            startBtn.Location = new Point(349, 497);
            startBtn.Name = "startBtn";
            startBtn.Size = new Size(102, 54);
            startBtn.TabIndex = 2;
            startBtn.Text = "START";
            startBtn.UseVisualStyleBackColor = false;
            startBtn.Click += startBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.2642225F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.73578F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.Controls.Add(pictureBox2, 1, 1);
            tableLayoutPanel1.Controls.Add(startBtn, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.6227181F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 98.37728F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 145F));
            tableLayoutPanel1.Size = new Size(800, 640);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 640);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TurnTable Start";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox2;
        private Button startBtn;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
