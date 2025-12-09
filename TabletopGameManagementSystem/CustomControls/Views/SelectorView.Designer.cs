namespace TabletopGameManagementSystem.CustomControls.Views
{
    partial class SelectorView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectorView));
            selector_layoutPanel = new TableLayoutPanel();
            gameSelector1 = new GameSelector(_gameLibrary);
            selectorMenu1 = new SelectorMenu();
            selector_layoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // selector_layoutPanel
            // 
            selector_layoutPanel.BackColor = Color.Transparent;
            selector_layoutPanel.ColumnCount = 2;
            selector_layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.04223F));
            selector_layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.9577732F));
            selector_layoutPanel.Controls.Add(gameSelector1, 0, 0);
            selector_layoutPanel.Controls.Add(selectorMenu1, 1, 0);
            selector_layoutPanel.Dock = DockStyle.Fill;
            selector_layoutPanel.Location = new Point(0, 0);
            selector_layoutPanel.Name = "selector_layoutPanel";
            selector_layoutPanel.RowCount = 1;
            selector_layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 28.57143F));
            selector_layoutPanel.Size = new Size(1042, 488);
            selector_layoutPanel.TabIndex = 5;
            // 
            // gameSelector1
            // 
            gameSelector1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gameSelector1.BackColor = Color.Transparent;
            gameSelector1.BackgroundImageLayout = ImageLayout.Zoom;
            gameSelector1.Location = new Point(3, 3);
            gameSelector1.Name = "gameSelector1";
            gameSelector1.Size = new Size(703, 482);
            gameSelector1.TabIndex = 0;
            // 
            // selectorMenu1
            // 
            selectorMenu1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            selectorMenu1.BackColor = Color.Transparent;
            selectorMenu1.BackgroundImage = (Image)resources.GetObject("selectorMenu1.BackgroundImage");
            selectorMenu1.BackgroundImageLayout = ImageLayout.Stretch;
            selectorMenu1.Location = new Point(712, 3);
            selectorMenu1.Name = "selectorMenu1";
            selectorMenu1.Size = new Size(327, 482);
            selectorMenu1.TabIndex = 1;
            // 
            // SelectorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(selector_layoutPanel);
            Name = "SelectorView";
            Size = new Size(1042, 488);
            selector_layoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel selector_layoutPanel;
        private GameSelector gameSelector1;
        private SelectorMenu selectorMenu1;
    }
}
