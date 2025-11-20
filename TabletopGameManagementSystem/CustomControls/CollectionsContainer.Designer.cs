namespace TabletopGameManagementSystem.CustomControls
{
    partial class CollectionsContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionsContainer));
            ColelctionContainer = new TableLayoutPanel();
            collectionCard1 = new CollectionCard();
            ColelctionContainer.SuspendLayout();
            SuspendLayout();
            // 
            // ColelctionContainer
            // 
            ColelctionContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ColelctionContainer.ColumnCount = 3;
            ColelctionContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            ColelctionContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            ColelctionContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            ColelctionContainer.Controls.Add(collectionCard1, 0, 0);
            ColelctionContainer.Location = new Point(0, 0);
            ColelctionContainer.Margin = new Padding(2, 2, 2, 2);
            ColelctionContainer.Name = "ColelctionContainer";
            ColelctionContainer.RowCount = 2;
            ColelctionContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ColelctionContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            ColelctionContainer.Size = new Size(712, 431);
            ColelctionContainer.TabIndex = 0;
            // 
            // collectionCard1
            // 
            collectionCard1.BackColor = Color.Transparent;
            collectionCard1.BackgroundImage = (Image)resources.GetObject("collectionCard1.BackgroundImage");
            collectionCard1.BackgroundImageLayout = ImageLayout.Stretch;
            collectionCard1.Location = new Point(10, 10);
            collectionCard1.Margin = new Padding(10);
            collectionCard1.Name = "collectionCard1";
            collectionCard1.Size = new Size(217, 195);
            collectionCard1.TabIndex = 0;
            // 
            // CollectionsContainer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(ColelctionContainer);
            Margin = new Padding(2, 2, 2, 2);
            Name = "CollectionsContainer";
            Size = new Size(712, 431);
            ColelctionContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel ColelctionContainer;
        private CollectionCard collectionCard1;
    }
}
