namespace TabletopGameManagementSystem.CustomControls
{
    partial class CollectionCard
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
            tableLayoutPanel1 = new TableLayoutPanel();
            collectionLabel = new Label();
            CollectionIcon = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CollectionIcon).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 14F));
            tableLayoutPanel1.Controls.Add(collectionLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(CollectionIcon, 0, 0);
            tableLayoutPanel1.Location = new Point(27, 27);
            tableLayoutPanel1.Margin = new Padding(2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.51282F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.4871788F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 12F));
            tableLayoutPanel1.Size = new Size(178, 164);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // collectionLabel
            // 
            collectionLabel.Anchor = AnchorStyles.None;
            collectionLabel.AutoSize = true;
            collectionLabel.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            collectionLabel.ForeColor = SystemColors.ActiveBorder;
            collectionLabel.Location = new Point(54, 134);
            collectionLabel.Margin = new Padding(2, 0, 2, 0);
            collectionLabel.Name = "collectionLabel";
            collectionLabel.Size = new Size(70, 27);
            collectionLabel.TabIndex = 2;
            collectionLabel.Text = "NEW";
            // 
            // CollectionIcon
            // 
            CollectionIcon.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            CollectionIcon.Location = new Point(15, 2);
            CollectionIcon.Margin = new Padding(2);
            CollectionIcon.Name = "CollectionIcon";
            CollectionIcon.Size = new Size(147, 128);
            CollectionIcon.TabIndex = 1;
            CollectionIcon.TabStop = false;
            // 
            // CollectionCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.dk_grey_square;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Margin = new Padding(2);
            Name = "CollectionCard";
            Size = new Size(232, 212);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CollectionIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox CollectionIcon;
        private Label collectionLabel;
    }
}
