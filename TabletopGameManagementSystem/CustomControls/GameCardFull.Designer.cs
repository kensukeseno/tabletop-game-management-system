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
            gameCard_panel.ColumnCount = 2;
            gameCard_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.79703F));
            gameCard_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.20297F));
            gameCard_panel.Controls.Add(gamedetails_panel, 1, 0);
            gameCard_panel.Controls.Add(tableLayoutPanel1, 0, 0);
            gameCard_panel.Controls.Add(btnRemove, 0, 1);
            gameCard_panel.Dock = DockStyle.Fill;
            gameCard_panel.Location = new Point(0, 0);
            gameCard_panel.Name = "gameCard_panel";
            gameCard_panel.RowCount = 2;
            gameCard_panel.RowStyles.Add(new RowStyle());
            gameCard_panel.RowStyles.Add(new RowStyle());
            gameCard_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            gameCard_panel.Size = new Size(808, 404);
            gameCard_panel.TabIndex = 0;
            // 
            // gamedetails_panel
            // 
            gamedetails_panel.ColumnCount = 1;
            gamedetails_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            gamedetails_panel.Controls.Add(lblGameTitle, 0, 0);
            gamedetails_panel.Controls.Add(innerGamedetailsPanel, 0, 1);
            gamedetails_panel.Dock = DockStyle.Fill;
            gamedetails_panel.Location = new Point(268, 29);
            gamedetails_panel.Margin = new Padding(3, 29, 3, 3);
            gamedetails_panel.Name = "gamedetails_panel";
            gamedetails_panel.RowCount = 2;
            gameCard_panel.SetRowSpan(gamedetails_panel, 2);
            gamedetails_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 51F));
            gamedetails_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            gamedetails_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            gamedetails_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            gamedetails_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            gamedetails_panel.Size = new Size(537, 372);
            gamedetails_panel.TabIndex = 1;
            // 
            // lblGameTitle
            // 
            lblGameTitle.Anchor = AnchorStyles.None;
            lblGameTitle.AutoSize = true;
            lblGameTitle.Font = new Font("Broadway", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGameTitle.ForeColor = SystemColors.ActiveBorder;
            lblGameTitle.Location = new Point(194, 12);
            lblGameTitle.MaximumSize = new Size(500, 0);
            lblGameTitle.Name = "lblGameTitle";
            lblGameTitle.Size = new Size(148, 26);
            lblGameTitle.TabIndex = 0;
            lblGameTitle.Text = "Game Title";
            lblGameTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // innerGamedetailsPanel
            // 
            innerGamedetailsPanel.ColumnCount = 2;
            innerGamedetailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            innerGamedetailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            innerGamedetailsPanel.Controls.Add(label3, 1, 0);
            innerGamedetailsPanel.Controls.Add(label2, 0, 0);
            innerGamedetailsPanel.Dock = DockStyle.Fill;
            innerGamedetailsPanel.Location = new Point(3, 54);
            innerGamedetailsPanel.Margin = new Padding(3, 3, 20, 3);
            innerGamedetailsPanel.Name = "innerGamedetailsPanel";
            innerGamedetailsPanel.RowCount = 6;
            innerGamedetailsPanel.RowStyles.Add(new RowStyle());
            innerGamedetailsPanel.RowStyles.Add(new RowStyle());
            innerGamedetailsPanel.RowStyles.Add(new RowStyle());
            innerGamedetailsPanel.RowStyles.Add(new RowStyle());
            innerGamedetailsPanel.RowStyles.Add(new RowStyle());
            innerGamedetailsPanel.RowStyles.Add(new RowStyle());
            innerGamedetailsPanel.Size = new Size(514, 315);
            innerGamedetailsPanel.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Calisto MT", 14.25F);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(302, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 28);
            label3.TabIndex = 3;
            label3.Text = "Data";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Calisto MT", 14.25F);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(27, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 2;
            label2.Text = "Heading";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackgroundImage = Properties.Resources.grey_square;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.Zoom;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(cbFavorite, 0, 2);
            tableLayoutPanel1.Controls.Add(cbWishlist, 0, 1);
            tableLayoutPanel1.Controls.Add(cbMyShelf, 0, 0);
            tableLayoutPanel1.Location = new Point(19, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 30, 0, 30);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(226, 156);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // cbFavorite
            // 
            cbFavorite.Anchor = AnchorStyles.None;
            cbFavorite.AutoSize = true;
            cbFavorite.Font = new Font("Broadway", 14.25F);
            cbFavorite.Location = new Point(42, 112);
            cbFavorite.Margin = new Padding(3, 4, 3, 4);
            cbFavorite.Name = "cbFavorite";
            cbFavorite.Size = new Size(142, 31);
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
            cbWishlist.Location = new Point(44, 73);
            cbWishlist.Margin = new Padding(3, 4, 3, 4);
            cbWishlist.Name = "cbWishlist";
            cbWishlist.Size = new Size(137, 31);
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
            cbMyShelf.Location = new Point(45, 34);
            cbMyShelf.Margin = new Padding(3, 4, 3, 4);
            cbMyShelf.Name = "cbMyShelf";
            cbMyShelf.Size = new Size(135, 31);
            cbMyShelf.TabIndex = 0;
            cbMyShelf.Text = "MyShelf";
            cbMyShelf.UseVisualStyleBackColor = true;
            cbMyShelf.Visible = false;
            cbMyShelf.CheckedChanged += cbMyShelf_CheckedChanged;
            // 
            // btnRemove
            // 
            btnRemove.Anchor = AnchorStyles.None;
            btnRemove.AutoSize = true;
            btnRemove.BackColor = Color.Transparent;
            btnRemove.BackgroundImage = Properties.Resources.grey_square;
            btnRemove.BackgroundImageLayout = ImageLayout.Stretch;
            btnRemove.FlatAppearance.BorderSize = 0;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Broadway", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.ForeColor = Color.Black;
            btnRemove.Location = new Point(67, 340);
            btnRemove.Margin = new Padding(0, 150, 0, 0);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(131, 37);
            btnRemove.TabIndex = 16;
            btnRemove.Text = "Remove";
            btnRemove.TextAlign = ContentAlignment.BottomCenter;
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // GameCardFull
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(gameCard_panel);
            DoubleBuffered = true;
            Name = "GameCardFull";
            Size = new Size(808, 404);
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
