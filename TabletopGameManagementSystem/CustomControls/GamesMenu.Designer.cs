namespace TabletopGameManagementSystem.CustomControls
{
    partial class GamesMenu
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
            bodyLayoutPanel = new TableLayoutPanel();
            vScrollBar1 = new VScrollBar();
            gameCardContainer1 = new GameCardContainer();
            bodyLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // bodyLayoutPanel
            // 
            bodyLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bodyLayoutPanel.ColumnCount = 2;
            bodyLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93.68132F));
            bodyLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.31868124F));
            bodyLayoutPanel.Controls.Add(vScrollBar1, 1, 0);
            bodyLayoutPanel.Controls.Add(gameCardContainer1, 0, 0);
            bodyLayoutPanel.Location = new Point(0, 0);
            bodyLayoutPanel.Margin = new Padding(2);
            bodyLayoutPanel.Name = "bodyLayoutPanel";
            bodyLayoutPanel.RowCount = 1;
            bodyLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bodyLayoutPanel.Size = new Size(764, 434);
            bodyLayoutPanel.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            vScrollBar1.Location = new Point(715, 30);
            vScrollBar1.Margin = new Padding(0, 30, 0, 30);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(25, 374);
            vScrollBar1.TabIndex = 0;
            // 
            // gameCardContainer1
            // 
            gameCardContainer1.BackColor = Color.Transparent;
            gameCardContainer1.Location = new Point(2, 2);
            gameCardContainer1.Margin = new Padding(2);
            gameCardContainer1.Name = "gameCardContainer1";
            gameCardContainer1.Size = new Size(711, 430);
            gameCardContainer1.TabIndex = 1;
            // 
            // GamesMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.grey_square;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(bodyLayoutPanel);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "GamesMenu";
            Size = new Size(764, 434);
            bodyLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel bodyLayoutPanel;
        private VScrollBar vScrollBar1;
        private GameCardContainer gameMenu1;
        private GameCardContainer gameCardContainer1;
    }
}
