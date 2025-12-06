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
            myShelfMenu1 = new myShelfMenu();
            myShelf_layoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // myShelf_layoutPanel
            // 
            myShelf_layoutPanel.BackColor = Color.Transparent;
            myShelf_layoutPanel.ColumnCount = 2;
            myShelf_layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.04223F));
            myShelf_layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.9577732F));
            myShelf_layoutPanel.Controls.Add(filterMenu1, 1, 0);
            myShelf_layoutPanel.Controls.Add(myShelfMenu1, 0, 0);
            myShelf_layoutPanel.Dock = DockStyle.Fill;
            myShelf_layoutPanel.Location = new Point(0, 0);
            myShelf_layoutPanel.Name = "myShelf_layoutPanel";
            myShelf_layoutPanel.RowCount = 1;
            myShelf_layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 28.57143F));
            myShelf_layoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            myShelf_layoutPanel.Size = new Size(1042, 488);
            myShelf_layoutPanel.TabIndex = 3;
            // 
            // filterMenu1
            // 
            filterMenu1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            filterMenu1.BackColor = Color.Transparent;
            filterMenu1.BackgroundImage = (Image)resources.GetObject("filterMenu1.BackgroundImage");
            filterMenu1.BackgroundImageLayout = ImageLayout.Stretch;
            filterMenu1.Location = new Point(711, 2);
            filterMenu1.Margin = new Padding(2);
            filterMenu1.Name = "filterMenu1";
            filterMenu1.Size = new Size(329, 484);
            filterMenu1.TabIndex = 1;
            // 
            // myShelfMenu1
            // 
            myShelfMenu1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            myShelfMenu1.BackColor = Color.Transparent;
            myShelfMenu1.BackgroundImage = (Image)resources.GetObject("myShelfMenu1.BackgroundImage");
            myShelfMenu1.BackgroundImageLayout = ImageLayout.Stretch;
            myShelfMenu1.Location = new Point(3, 3);
            myShelfMenu1.Name = "myShelfMenu1";
            myShelfMenu1.Size = new Size(703, 482);
            myShelfMenu1.TabIndex = 2;
            // 
            // MyShelfView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(myShelf_layoutPanel);
            Name = "MyShelfView";
            Size = new Size(1042, 488);
            myShelf_layoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel myShelf_layoutPanel;
        private FilterMenu filterMenu1;
        private myShelfMenu myShelfMenu1;
    }
}
