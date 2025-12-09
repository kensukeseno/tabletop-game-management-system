namespace TabletopGameManagementSystem.CustomControls.Views
{
    partial class AllGamesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllGamesView));
            collections_layoutPanel = new TableLayoutPanel();
            filterMenu1 = new FilterMenu();
            gameCardContainer1 = new GameCardContainer();
            collections_layoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // collections_layoutPanel
            // 
            collections_layoutPanel.BackColor = Color.Transparent;
            collections_layoutPanel.ColumnCount = 2;
            collections_layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.04223F));
            collections_layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.9577732F));
            collections_layoutPanel.Controls.Add(filterMenu1, 1, 0);
            collections_layoutPanel.Controls.Add(gameCardContainer1, 0, 0);
            collections_layoutPanel.Dock = DockStyle.Fill;
            collections_layoutPanel.Location = new Point(0, 0);
            collections_layoutPanel.Name = "collections_layoutPanel";
            collections_layoutPanel.RowCount = 1;
            collections_layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 28.57143F));
            collections_layoutPanel.Size = new Size(1042, 488);
            collections_layoutPanel.TabIndex = 5;
            // 
            // filterMenu1
            // 
            filterMenu1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            filterMenu1.BackColor = Color.Transparent;
            filterMenu1.BackgroundImage = (Image)resources.GetObject("filterMenu1.BackgroundImage");
            filterMenu1.BackgroundImageLayout = ImageLayout.Stretch;
            filterMenu1.Location = new Point(711, 2);
            filterMenu1.Margin = new Padding(2, 2, 2, 2);
            filterMenu1.Name = "filterMenu1";
            filterMenu1.Size = new Size(329, 484);
            filterMenu1.TabIndex = 0;
            // 
            // gameCardContainer1
            // 
            gameCardContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gameCardContainer1.AutoScroll = true;
            gameCardContainer1.BackColor = Color.Transparent;
            gameCardContainer1.Location = new Point(2, 2);
            gameCardContainer1.Margin = new Padding(2, 2, 2, 2);
            gameCardContainer1.Name = "gameCardContainer1";
            gameCardContainer1.Size = new Size(705, 484);
            gameCardContainer1.TabIndex = 1;
            // 
            // AllGamesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(collections_layoutPanel);
            Name = "AllGamesView";
            Size = new Size(1042, 488);
            collections_layoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel collections_layoutPanel;
        private GameCardContainer gameCardContainer1;
        private FilterMenu filterMenu1;
    }
}
