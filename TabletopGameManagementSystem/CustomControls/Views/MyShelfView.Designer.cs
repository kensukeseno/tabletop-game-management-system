namespace TabletopGameManagementSystem.CustomControls.Views
{
    partial class MyShelfView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyShelfView));
            myShelf_layoutPanel = new TableLayoutPanel();
            filterMenu1 = new FilterMenu();
            gameCardContainer1 = new GameCardContainer();
            myShelf_layoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // myShelf_layoutPanel
            // 
            myShelf_layoutPanel.BackColor = Color.Transparent;
            myShelf_layoutPanel.ColumnCount = 2;
            myShelf_layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.04223F));
            myShelf_layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.95777F));
            myShelf_layoutPanel.Controls.Add(filterMenu1, 1, 1);
            myShelf_layoutPanel.Controls.Add(gameCardContainer1, 0, 0);
            myShelf_layoutPanel.Dock = DockStyle.Fill;
            myShelf_layoutPanel.Location = new Point(0, 0);
            myShelf_layoutPanel.Margin = new Padding(3, 4, 3, 4);
            myShelf_layoutPanel.Name = "myShelf_layoutPanel";
            myShelf_layoutPanel.RowCount = 2;
            myShelf_layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            myShelf_layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            myShelf_layoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            myShelf_layoutPanel.Size = new Size(1191, 651);
            myShelf_layoutPanel.TabIndex = 3;
            // 
            // filterMenu1
            // 
            filterMenu1.BackColor = Color.Transparent;
            filterMenu1.BackgroundImage = (Image)resources.GetObject("filterMenu1.BackgroundImage");
            filterMenu1.BackgroundImageLayout = ImageLayout.Stretch;
            filterMenu1.Dock = DockStyle.Fill;
            filterMenu1.Location = new Point(812, 68);
            filterMenu1.Margin = new Padding(2, 3, 2, 3);
            filterMenu1.Name = "filterMenu1";
            filterMenu1.Size = new Size(377, 580);
            filterMenu1.TabIndex = 1;
            // 
            // gameCardContainer1
            // 
            gameCardContainer1.AutoScroll = true;
            gameCardContainer1.BackColor = Color.Transparent;
            gameCardContainer1.Location = new Point(2, 3);
            gameCardContainer1.Margin = new Padding(2, 3, 2, 3);
            gameCardContainer1.Name = "gameCardContainer1";
            myShelf_layoutPanel.SetRowSpan(gameCardContainer1, 2);
            gameCardContainer1.Size = new Size(806, 645);
            gameCardContainer1.TabIndex = 2;
            // 
            // MyShelfView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(myShelf_layoutPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MyShelfView";
            Size = new Size(1191, 651);
            myShelf_layoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel myShelf_layoutPanel;
        private FilterMenu filterMenu1;
        private GameCardContainer gameCardContainer1;
    }
}
