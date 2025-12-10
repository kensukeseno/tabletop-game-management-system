namespace TabletopGameManagementSystem.CustomControls
{
    partial class GameCardFull
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
            gameCard_panel = new TableLayoutPanel();
            gamedetails_panel = new TableLayoutPanel();
            lblGameTitle = new Label();
            innerGamedetailsPanel = new TableLayoutPanel();
            label3 = new Label();
            label2 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            cbFavorite = new CheckBox();
            cbWishlist = new CheckBox();
            cbMyShelf = new CheckBox();
            btnRemove = new Button();
            gameCard_panel.SuspendLayout();
            gamedetails_panel.SuspendLayout();
            innerGamedetailsPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gameCard_panel
            // 
            gameCard_panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gameCard_panel.ColumnCount = 2;
            gameCard_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.6885014F));
            gameCard_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.3115F));
            gameCard_panel.Controls.Add(gamedetails_panel, 1, 0);
            gameCard_panel.Controls.Add(tableLayoutPanel1, 0, 0);
            gameCard_panel.Controls.Add(btnRemove, 0, 1);
            gameCard_panel.Location = new Point(0, 0);
            gameCard_panel.Margin = new Padding(0);
            gameCard_panel.Name = "gameCard_panel";
            gameCard_panel.Padding = new Padding(20);
            gameCard_panel.RowCount = 2;
            gameCard_panel.RowStyles.Add(new RowStyle());
            gameCard_panel.RowStyles.Add(new RowStyle());
            gameCard_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            gameCard_panel.Size = new Size(707, 303);
            gameCard_panel.TabIndex = 0;
            // 
            // gamedetails_panel
            // 
            gamedetails_panel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gamedetails_panel.ColumnCount = 1;
            gamedetails_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            gamedetails_panel.Controls.Add(lblGameTitle, 0, 0);
            gamedetails_panel.Controls.Add(innerGamedetailsPanel, 0, 1);
            gamedetails_panel.Location = new Point(167, 22);
            gamedetails_panel.Margin = new Padding(3, 2, 3, 2);
            gamedetails_panel.Name = "gamedetails_panel";
            gamedetails_panel.RowCount = 2;
            gameCard_panel.SetRowSpan(gamedetails_panel, 2);
            gamedetails_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            gamedetails_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            gamedetails_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            gamedetails_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            gamedetails_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            gamedetails_panel.Size = new Size(517, 261);
            gamedetails_panel.TabIndex = 1;
            // 
            // lblGameTitle
            // 
            lblGameTitle.Anchor = AnchorStyles.None;
            lblGameTitle.AutoSize = true;
            lblGameTitle.Font = new Font("Broadway", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGameTitle.ForeColor = SystemColors.ActiveBorder;
            lblGameTitle.Location = new Point(198, 8);
            lblGameTitle.MaximumSize = new Size(438, 0);
            lblGameTitle.Name = "lblGameTitle";
            lblGameTitle.Size = new Size(121, 21);
            lblGameTitle.TabIndex = 0;
            lblGameTitle.Text = "Game Title";
            lblGameTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // innerGamedetailsPanel
            // 
            innerGamedetailsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            innerGamedetailsPanel.AutoScroll = true;
            innerGamedetailsPanel.ColumnCount = 2;
            innerGamedetailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.3688221F));
            innerGamedetailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.63118F));
            innerGamedetailsPanel.Controls.Add(label3, 1, 0);
            innerGamedetailsPanel.Controls.Add(label2, 0, 0);
            innerGamedetailsPanel.Location = new Point(10, 48);
            innerGamedetailsPanel.Margin = new Padding(10, 10, 30, 10);
            innerGamedetailsPanel.Name = "innerGamedetailsPanel";
            innerGamedetailsPanel.RowCount = 6;
            innerGamedetailsPanel.RowStyles.Add(new RowStyle());
            innerGamedetailsPanel.RowStyles.Add(new RowStyle());
            innerGamedetailsPanel.RowStyles.Add(new RowStyle());
            innerGamedetailsPanel.RowStyles.Add(new RowStyle());
            innerGamedetailsPanel.RowStyles.Add(new RowStyle());
            innerGamedetailsPanel.RowStyles.Add(new RowStyle());
            innerGamedetailsPanel.Size = new Size(477, 203);
            innerGamedetailsPanel.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 14.25F);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(288, 0);
            label3.Name = "label3";
            label3.Size = new Size(49, 22);
            label3.TabIndex = 3;
            label3.Text = "Data";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 14.25F);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(36, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 22);
            label2.TabIndex = 2;
            label2.Text = "Heading";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackgroundImage = Properties.Resources.grey_square;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(cbFavorite, 0, 2);
            tableLayoutPanel1.Controls.Add(cbWishlist, 0, 1);
            tableLayoutPanel1.Controls.Add(cbMyShelf, 0, 0);
            tableLayoutPanel1.Location = new Point(23, 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 22, 0, 22);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new Size(138, 132);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // cbFavorite
            // 
            cbFavorite.Anchor = AnchorStyles.None;
            cbFavorite.AutoSize = true;
            cbFavorite.Font = new Font("Broadway", 14.25F);
            cbFavorite.Location = new Point(12, 87);
            cbFavorite.Name = "cbFavorite";
            cbFavorite.Size = new Size(113, 25);
            cbFavorite.TabIndex = 3;
            cbFavorite.Text = "Favorite";
            cbFavorite.UseVisualStyleBackColor = true;
            cbFavorite.CheckedChanged += cbFavorite_CheckedChanged;
            // 
            // cbWishlist
            // 
            cbWishlist.Anchor = AnchorStyles.None;
            cbWishlist.AutoSize = true;
            cbWishlist.Font = new Font("Broadway", 14.25F);
            cbWishlist.Location = new Point(14, 56);
            cbWishlist.Name = "cbWishlist";
            cbWishlist.Size = new Size(109, 25);
            cbWishlist.TabIndex = 1;
            cbWishlist.Text = "Wishlist";
            cbWishlist.UseVisualStyleBackColor = true;
            cbWishlist.CheckedChanged += cbWishlist_CheckedChanged;
            // 
            // cbMyShelf
            // 
            cbMyShelf.Anchor = AnchorStyles.None;
            cbMyShelf.AutoSize = true;
            cbMyShelf.Font = new Font("Broadway", 14.25F);
            cbMyShelf.Location = new Point(15, 25);
            cbMyShelf.Name = "cbMyShelf";
            cbMyShelf.Size = new Size(108, 25);
            cbMyShelf.TabIndex = 0;
            cbMyShelf.Text = "MyShelf";
            cbMyShelf.UseVisualStyleBackColor = true;
            cbMyShelf.Visible = false;
            cbMyShelf.CheckedChanged += cbMyShelf_CheckedChanged;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.Bottom;
            btnRemove.AutoSize = true;
            btnRemove.BackColor = Color.Transparent;
            btnRemove.BackgroundImage = Properties.Resources.grey_square;
            btnRemove.BackgroundImageLayout = ImageLayout.Stretch;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Broadway", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.Black;
            btnRemove.Location = new Point(21, 254);
            btnRemove.Margin = new Padding(0);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(141, 31);
            btnRemove.TabIndex = 16;
            btnRemove.Text = "Remove";
            btnRemove.TextAlign = ContentAlignment.BottomCenter;
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // GameCardFull
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(gameCard_panel);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "GameCardFull";
            Size = new Size(707, 303);
            gameCard_panel.ResumeLayout(false);
            gameCard_panel.PerformLayout();
            gamedetails_panel.ResumeLayout(false);
            gamedetails_panel.PerformLayout();
            innerGamedetailsPanel.ResumeLayout(false);
            innerGamedetailsPanel.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel gameCard_panel;
        private TableLayoutPanel gamedetails_panel;
        private Label lblGameTitle;
        private TableLayoutPanel innerGamedetailsPanel;
        private Label label2;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox cbWishlist;
        private CheckBox cbMyShelf;
        private CheckBox cbFavorite;
        private Button btnRemove;
    }
}
