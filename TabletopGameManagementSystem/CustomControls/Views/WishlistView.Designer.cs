namespace TabletopGameManagementSystem.CustomControls.Views
{
    partial class WishlistView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WishlistView));
            wishlist_layoutPanel = new TableLayoutPanel();
            gameCardContainer1 = new GameCardContainer();
            filterMenu1 = new FilterMenu();
            wishlist_layoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // wishlist_layoutPanel
            // 
            wishlist_layoutPanel.BackColor = Color.Transparent;
            wishlist_layoutPanel.ColumnCount = 2;
            wishlist_layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.04223F));
            wishlist_layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.95777F));
            wishlist_layoutPanel.Controls.Add(gameCardContainer1, 0, 0);
            wishlist_layoutPanel.Controls.Add(filterMenu1, 1, 0);
            wishlist_layoutPanel.Dock = DockStyle.Fill;
            wishlist_layoutPanel.Location = new Point(0, 0);
            wishlist_layoutPanel.Name = "wishlist_layoutPanel";
            wishlist_layoutPanel.RowCount = 1;
            wishlist_layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            wishlist_layoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            wishlist_layoutPanel.Size = new Size(1042, 488);
            wishlist_layoutPanel.TabIndex = 6;
            // 
            // gameCardContainer1
            // 
            gameCardContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gameCardContainer1.BackColor = Color.Transparent;
            gameCardContainer1.Location = new Point(2, 2);
            gameCardContainer1.Margin = new Padding(2, 2, 2, 2);
            gameCardContainer1.Name = "gameCardContainer1";
            gameCardContainer1.Size = new Size(705, 484);
            gameCardContainer1.TabIndex = 4;
            // 
            // filterMenu1
            // 
            filterMenu1.BackColor = Color.Transparent;
            filterMenu1.BackgroundImage = (Image)resources.GetObject("filterMenu1.BackgroundImage");
            filterMenu1.BackgroundImageLayout = ImageLayout.Stretch;
            filterMenu1.Location = new Point(711, 2);
            filterMenu1.Margin = new Padding(2, 2, 2, 2);
            filterMenu1.Name = "filterMenu1";
            filterMenu1.Size = new Size(327, 482);
            filterMenu1.TabIndex = 5;
            // 
            // WishlistView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(wishlist_layoutPanel);
            Name = "WishlistView";
            Size = new Size(1042, 488);
            wishlist_layoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel wishlist_layoutPanel;
        private GameCardContainer gameCardContainer1;
        private FilterMenu filterMenu1;
    }
}
