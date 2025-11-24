namespace TabletopGameManagementSystem.CustomControls
{
    partial class myShelfMenu
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
            tableLayoutPanel1 = new TableLayoutPanel();
            bodyLayoutPanel = new TableLayoutPanel();
            vScrollBar1 = new VScrollBar();
            gameCardContainer1 = new GameCardContainer();
            button1 = new Button();
            tableLayoutPanel1.SuspendLayout();
            bodyLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(bodyLayoutPanel, 0, 0);
            tableLayoutPanel1.Controls.Add(button1, 0, 1);
            tableLayoutPanel1.Location = new Point(8, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.2580643F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.7419357F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(764, 434);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // bodyLayoutPanel
            // 
            bodyLayoutPanel.ColumnCount = 2;
            bodyLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93.68132F));
            bodyLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.31868124F));
            bodyLayoutPanel.Controls.Add(vScrollBar1, 1, 0);
            bodyLayoutPanel.Controls.Add(gameCardContainer1, 0, 0);
            bodyLayoutPanel.Dock = DockStyle.Fill;
            bodyLayoutPanel.Location = new Point(2, 2);
            bodyLayoutPanel.Margin = new Padding(2);
            bodyLayoutPanel.Name = "bodyLayoutPanel";
            bodyLayoutPanel.RowCount = 1;
            bodyLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bodyLayoutPanel.Size = new Size(760, 353);
            bodyLayoutPanel.TabIndex = 2;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            vScrollBar1.Location = new Point(711, 35);
            vScrollBar1.Margin = new Padding(0, 35, 0, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(25, 318);
            vScrollBar1.TabIndex = 0;
            // 
            // gameCardContainer1
            // 
            gameCardContainer1.BackColor = Color.Transparent;
            gameCardContainer1.Dock = DockStyle.Fill;
            gameCardContainer1.Location = new Point(2, 2);
            gameCardContainer1.Margin = new Padding(2);
            gameCardContainer1.Name = "gameCardContainer1";
            gameCardContainer1.Size = new Size(707, 349);
            gameCardContainer1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.dk_grey_square;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(545, 375);
            button1.Margin = new Padding(0, 12, 55, 15);
            button1.Name = "button1";
            button1.Size = new Size(164, 37);
            button1.TabIndex = 14;
            button1.Text = "Add Game";
            button1.UseVisualStyleBackColor = false;
            // 
            // myShelfMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.grey_square;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Name = "myShelfMenu";
            Size = new Size(764, 434);
            tableLayoutPanel1.ResumeLayout(false);
            bodyLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel bodyLayoutPanel;
        private VScrollBar vScrollBar1;
        private GameCardContainer gameCardContainer1;
        private Button button1;
    }
}
