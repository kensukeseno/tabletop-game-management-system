namespace TabletopGameManagementSystem.CustomControls
{
    partial class NavMenu
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
            navLayoutPanel = new TableLayoutPanel();
            btnMyShelf = new Button();
            btnCollections = new Button();
            btnWishlist = new Button();
            btnGames = new Button();
            btnSpin = new Button();
            navLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // navLayoutPanel
            // 
            navLayoutPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            navLayoutPanel.ColumnCount = 1;
            navLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            navLayoutPanel.Controls.Add(btnMyShelf, 0, 0);
            navLayoutPanel.Controls.Add(btnCollections, 0, 1);
            navLayoutPanel.Controls.Add(btnWishlist, 0, 2);
            navLayoutPanel.Controls.Add(btnGames, 0, 3);
            navLayoutPanel.Controls.Add(btnSpin, 0, 4);
            navLayoutPanel.Location = new Point(0, 45);
            navLayoutPanel.Margin = new Padding(2, 3, 2, 3);
            navLayoutPanel.Name = "navLayoutPanel";
            navLayoutPanel.RowCount = 5;
            navLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.3846188F));
            navLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.3846159F));
            navLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.3846159F));
            navLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.3846159F));
            navLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23.0769234F));
            navLayoutPanel.Size = new Size(319, 519);
            navLayoutPanel.TabIndex = 0;
            // 
            // btnMyShelf
            // 
            btnMyShelf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnMyShelf.BackColor = Color.Transparent;
            btnMyShelf.FlatAppearance.BorderSize = 0;
            btnMyShelf.FlatStyle = FlatStyle.Flat;
            btnMyShelf.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMyShelf.ForeColor = SystemColors.ActiveBorder;
            btnMyShelf.Location = new Point(0, 16);
            btnMyShelf.Margin = new Padding(0, 16, 0, 0);
            btnMyShelf.Name = "btnMyShelf";
            btnMyShelf.Size = new Size(319, 78);
            btnMyShelf.TabIndex = 3;
            btnMyShelf.Text = "My Shelf";
            btnMyShelf.UseVisualStyleBackColor = false;
            btnMyShelf.Click += btnMyShelf_Click;
            // 
            // btnCollections
            // 
            btnCollections.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCollections.BackColor = Color.Transparent;
            btnCollections.FlatAppearance.BorderSize = 0;
            btnCollections.FlatStyle = FlatStyle.Flat;
            btnCollections.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCollections.ForeColor = SystemColors.ActiveBorder;
            btnCollections.Location = new Point(0, 110);
            btnCollections.Margin = new Padding(0, 16, 0, 0);
            btnCollections.Name = "btnCollections";
            btnCollections.Size = new Size(319, 78);
            btnCollections.TabIndex = 4;
            btnCollections.Text = "Collections";
            btnCollections.UseVisualStyleBackColor = false;
            btnCollections.Click += btnCollections_Click;
            // 
            // btnWishlist
            // 
            btnWishlist.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnWishlist.BackColor = Color.Transparent;
            btnWishlist.FlatAppearance.BorderSize = 0;
            btnWishlist.FlatStyle = FlatStyle.Flat;
            btnWishlist.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnWishlist.ForeColor = SystemColors.ActiveBorder;
            btnWishlist.Location = new Point(0, 204);
            btnWishlist.Margin = new Padding(0, 16, 0, 0);
            btnWishlist.Name = "btnWishlist";
            btnWishlist.Size = new Size(319, 78);
            btnWishlist.TabIndex = 6;
            btnWishlist.Text = "Wishlist";
            btnWishlist.UseVisualStyleBackColor = false;
            btnWishlist.Click += btnWishlist_Click;
            // 
            // btnGames
            // 
            btnGames.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnGames.BackColor = Color.Transparent;
            btnGames.FlatAppearance.BorderSize = 0;
            btnGames.FlatStyle = FlatStyle.Flat;
            btnGames.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGames.ForeColor = SystemColors.ActiveBorder;
            btnGames.Location = new Point(0, 298);
            btnGames.Margin = new Padding(0, 16, 0, 0);
            btnGames.Name = "btnGames";
            btnGames.Size = new Size(319, 78);
            btnGames.TabIndex = 11;
            btnGames.Text = "Games";
            btnGames.UseVisualStyleBackColor = false;
            btnGames.Click += btnGames_Click;
            // 
            // btnSpin
            // 
            btnSpin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnSpin.BackgroundImage = Properties.Resources.record_logo_purple;
            btnSpin.BackgroundImageLayout = ImageLayout.Zoom;
            btnSpin.FlatAppearance.BorderSize = 0;
            btnSpin.FlatStyle = FlatStyle.Flat;
            btnSpin.Font = new Font("Broadway", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSpin.Location = new Point(3, 380);
            btnSpin.Margin = new Padding(3, 4, 3, 4);
            btnSpin.Name = "btnSpin";
            btnSpin.Size = new Size(312, 135);
            btnSpin.TabIndex = 10;
            btnSpin.Text = "Spin";
            btnSpin.UseVisualStyleBackColor = true;
            btnSpin.Click += btnSpin_Click;
            // 
            // NavMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.dk_grey_square;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(navLayoutPanel);
            DoubleBuffered = true;
            Margin = new Padding(2, 3, 2, 3);
            Name = "NavMenu";
            Size = new Size(319, 591);
            Load += NavMenu_Load;
            navLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel navLayoutPanel;
        private Button btnCollections;
        private Button btnMyShelf;
        private Button btnWishlist;
        private Button btnSpin;
        private Button btnGames;
    }
}
