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
            SuspendLayout();
            // 
            // collectionContainer
            // 
            collectionContainer.BackColor = Color.Transparent;
            collectionContainer.Location = new Point(2, 132);
            collectionContainer.Margin = new Padding(2, 3, 2, 3);
            collectionContainer.Name = "collectionContainer";
            collectionContainer.Size = new Size(847, 594);
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
            btnAddCollection.Location = new Point(427, 83);
            btnAddCollection.Margin = new Padding(0, 150, 0, 0);
            btnAddCollection.Name = "btnAddCollection";
            btnAddCollection.Size = new Size(209, 37);
            btnAddCollection.TabIndex = 17;
            btnAddCollection.Text = "New Collection";
            btnAddCollection.TextAlign = ContentAlignment.BottomCenter;
            btnAddCollection.UseVisualStyleBackColor = false;
            btnAddCollection.Click += btnAddCollection_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.None;
            btnRefresh.AutoSize = true;
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.BackgroundImage = Properties.Resources.grey_square;
            btnRefresh.BackgroundImageLayout = ImageLayout.Stretch;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Broadway", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(636, 83);
            btnRefresh.Margin = new Padding(0, 150, 0, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(209, 37);
            btnRefresh.TabIndex = 18;
            btnRefresh.Text = "Refresh";
            btnRefresh.TextAlign = ContentAlignment.BottomCenter;
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // CollectionsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(btnRefresh);
            Controls.Add(collectionContainer);
            Controls.Add(btnAddCollection);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CollectionsView";
            Size = new Size(959, 729);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CollectionsContainer collectionContainer;
        private Button btnAddCollection;
        private Button btnRefresh;
    }
}
