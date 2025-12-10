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
            collectionContainer = new CollectionsContainer();
            btnAddCollection = new Button();
            btnRefresh = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // collectionContainer
            // 
            collectionContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            collectionContainer.BackColor = Color.Transparent;
            collectionContainer.Location = new Point(2, 2);
            collectionContainer.Margin = new Padding(2, 2, 2, 2);
            collectionContainer.Name = "collectionContainer";
            collectionContainer.Size = new Size(701, 484);
            collectionContainer.TabIndex = 0;
            // 
            // btnAddCollection
            // 
            btnAddCollection.Anchor = AnchorStyles.None;
            btnAddCollection.AutoSize = true;
            btnAddCollection.BackColor = Color.Transparent;
            btnAddCollection.BackgroundImage = Properties.Resources.grey_square;
            btnAddCollection.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddCollection.FlatAppearance.BorderSize = 0;
            btnAddCollection.FlatStyle = FlatStyle.Flat;
            btnAddCollection.Font = new Font("Broadway", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCollection.ForeColor = Color.Black;
            btnAddCollection.Location = new Point(74, 22);
            btnAddCollection.Margin = new Padding(0);
            btnAddCollection.Name = "btnAddCollection";
            btnAddCollection.Size = new Size(183, 31);
            btnAddCollection.TabIndex = 17;
            btnAddCollection.Text = "New Collection";
            btnAddCollection.TextAlign = ContentAlignment.BottomCenter;
            btnAddCollection.UseVisualStyleBackColor = false;
            btnAddCollection.Click += btnAddCollection_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top;
            btnRefresh.AutoSize = true;
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BackgroundImage = Properties.Resources.grey_square;
            btnRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Broadway", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(74, 75);
            btnRefresh.Margin = new Padding(0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(183, 31);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.BottomCenter;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.65835F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.3416519F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(collectionContainer, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1042, 488);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnRefresh, 0, 1);
            tableLayoutPanel2.Controls.Add(btnAddCollection, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(708, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5601664F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 84.4398346F));
            tableLayoutPanel2.Size = new Size(331, 482);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // CollectionsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(tableLayoutPanel1);
            Name = "CollectionsView";
            Size = new Size(1042, 488);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private CollectionsContainer collectionContainer;
        private Button btnAddCollection;
        private Button btnRefresh;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
