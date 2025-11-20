namespace TabletopGameManagementSystem.CustomControls
{
    partial class CollectionsView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionsView));
            collections_layoutPanel = new TableLayoutPanel();
            collectionsMenu1 = new CollectionsMenu();
            collectionDetailsMenu1 = new CollectionDetailsMenu();
            collections_layoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // collections_layoutPanel
            // 
            collections_layoutPanel.BackColor = Color.Transparent;
            collections_layoutPanel.ColumnCount = 2;
            collections_layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.04223F));
            collections_layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.9577732F));
            collections_layoutPanel.Controls.Add(collectionsMenu1, 0, 0);
            collections_layoutPanel.Controls.Add(collectionDetailsMenu1, 1, 0);
            collections_layoutPanel.Dock = DockStyle.Fill;
            collections_layoutPanel.Location = new Point(0, 0);
            collections_layoutPanel.Name = "collections_layoutPanel";
            collections_layoutPanel.RowCount = 1;
            collections_layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 28.57143F));
            collections_layoutPanel.Size = new Size(1042, 488);
            collections_layoutPanel.TabIndex = 4;
            // 
            // collectionsMenu1
            // 
            collectionsMenu1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            collectionsMenu1.BackColor = Color.Transparent;
            collectionsMenu1.BackgroundImage = (Image)resources.GetObject("collectionsMenu1.BackgroundImage");
            collectionsMenu1.BackgroundImageLayout = ImageLayout.Stretch;
            collectionsMenu1.Location = new Point(3, 3);
            collectionsMenu1.Name = "collectionsMenu1";
            collectionsMenu1.Size = new Size(703, 482);
            collectionsMenu1.TabIndex = 0;
            // 
            // collectionDetailsMenu1
            // 
            collectionDetailsMenu1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            collectionDetailsMenu1.BackColor = Color.Transparent;
            collectionDetailsMenu1.BackgroundImage = (Image)resources.GetObject("collectionDetailsMenu1.BackgroundImage");
            collectionDetailsMenu1.BackgroundImageLayout = ImageLayout.Stretch;
            collectionDetailsMenu1.Location = new Point(712, 3);
            collectionDetailsMenu1.Name = "collectionDetailsMenu1";
            collectionDetailsMenu1.Size = new Size(327, 482);
            collectionDetailsMenu1.TabIndex = 1;
            // 
            // CollectionsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(collections_layoutPanel);
            Name = "CollectionsView";
            Size = new Size(1042, 488);
            collections_layoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel collections_layoutPanel;
        private CollectionsMenu collectionsMenu1;
        private CollectionDetailsMenu collectionDetailsMenu1;
    }
}
