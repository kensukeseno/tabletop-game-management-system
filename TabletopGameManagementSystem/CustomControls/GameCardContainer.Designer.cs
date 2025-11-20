namespace TabletopGameManagementSystem.CustomControls
{
    partial class GameCardContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameCardContainer));
            gameMenuLayoutPanel = new TableLayoutPanel();
            gameCardFull1 = new GameCardFull();
            gameCardFull2 = new GameCardFull();
            gameMenuLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // gameMenuLayoutPanel
            // 
            gameMenuLayoutPanel.ColumnCount = 1;
            gameMenuLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            gameMenuLayoutPanel.Controls.Add(gameCardFull2, 0, 0);
            gameMenuLayoutPanel.Controls.Add(gameCardFull1, 0, 1);
            gameMenuLayoutPanel.Dock = DockStyle.Fill;
            gameMenuLayoutPanel.Location = new Point(0, 0);
            gameMenuLayoutPanel.Margin = new Padding(3, 2, 3, 2);
            gameMenuLayoutPanel.Name = "gameMenuLayoutPanel";
            gameMenuLayoutPanel.RowCount = 2;
            gameMenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gameMenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            gameMenuLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            gameMenuLayoutPanel.Size = new Size(712, 430);
            gameMenuLayoutPanel.TabIndex = 0;
            // 
            // gameCardFull1
            // 
            gameCardFull1.BackColor = Color.Transparent;
            gameCardFull1.BackgroundImage = (Image)resources.GetObject("gameCardFull1.BackgroundImage");
            gameCardFull1.BackgroundImageLayout = ImageLayout.Stretch;
            gameCardFull1.Location = new Point(3, 217);
            gameCardFull1.Margin = new Padding(3, 2, 3, 2);
            gameCardFull1.Name = "gameCardFull1";
            gameCardFull1.Size = new Size(706, 211);
            gameCardFull1.TabIndex = 1;
            // 
            // gameCardFull2
            // 
            gameCardFull2.BackColor = Color.Transparent;
            gameCardFull2.BackgroundImage = (Image)resources.GetObject("gameCardFull2.BackgroundImage");
            gameCardFull2.BackgroundImageLayout = ImageLayout.Stretch;
            gameCardFull2.Location = new Point(3, 2);
            gameCardFull2.Margin = new Padding(3, 2, 3, 2);
            gameCardFull2.Name = "gameCardFull2";
            gameCardFull2.Size = new Size(706, 206);
            gameCardFull2.TabIndex = 2;
            // 
            // GameCardContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(gameMenuLayoutPanel);
            Margin = new Padding(2);
            Name = "GameCardContainer";
            Size = new Size(712, 430);
            gameMenuLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel gameMenuLayoutPanel;
        private GameCardFull gameCardFull1;
        private GameCardFull gameCardFull2;
    }
}
