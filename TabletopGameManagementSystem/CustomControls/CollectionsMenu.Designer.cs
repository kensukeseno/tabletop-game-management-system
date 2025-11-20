namespace TabletopGameManagementSystem.CustomControls
{
    partial class CollectionsMenu
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
            collectionsContainer1 = new CollectionsContainer();
            bodyLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // bodyLayoutPanel
            // 
            bodyLayoutPanel.ColumnCount = 2;
            bodyLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 93.68132F));
            bodyLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.31868124F));
            bodyLayoutPanel.Controls.Add(vScrollBar1, 1, 0);
            bodyLayoutPanel.Controls.Add(collectionsContainer1, 0, 0);
            bodyLayoutPanel.Dock = DockStyle.Fill;
            bodyLayoutPanel.Location = new Point(0, 0);
            bodyLayoutPanel.Margin = new Padding(2);
            bodyLayoutPanel.Name = "bodyLayoutPanel";
            bodyLayoutPanel.RowCount = 1;
            bodyLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            bodyLayoutPanel.Size = new Size(764, 434);
            bodyLayoutPanel.TabIndex = 1;
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
            // collectionsContainer1
            // 
            collectionsContainer1.BackColor = Color.Transparent;
            collectionsContainer1.Location = new Point(2, 2);
            collectionsContainer1.Margin = new Padding(2);
            collectionsContainer1.Name = "collectionsContainer1";
            collectionsContainer1.Size = new Size(711, 430);
            collectionsContainer1.TabIndex = 1;
            // 
            // CollectionsMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.grey_square;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(bodyLayoutPanel);
            DoubleBuffered = true;
            Name = "CollectionsMenu";
            Size = new Size(764, 434);
            bodyLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel bodyLayoutPanel;
        private VScrollBar vScrollBar1;
        private CollectionsContainer collectionsContainer1;
    }
}
