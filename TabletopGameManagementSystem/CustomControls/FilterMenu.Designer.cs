namespace TabletopGameManagementSystem.CustomControls
{
    partial class FilterMenu
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
            label1 = new Label();
            txtTitleFilter = new TextBox();
            button2 = new Button();
            btnApply = new Button();
            chkOwned = new CheckBox();
            chkWishlist = new CheckBox();
            chkFavorite = new CheckBox();
            numMinPlayers = new NumericUpDown();
            label2 = new Label();
            label3 = new Label();
            numMaxPlayers = new NumericUpDown();
            label4 = new Label();
            numPlayingTime = new NumericUpDown();
            label5 = new Label();
            numAge = new NumericUpDown();
            clbCategories = new CheckedListBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numMinPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPlayingTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(27, 85);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 14;
            label1.Text = "Name Contains";
            // 
            // txtTitleFilter
            // 
            txtTitleFilter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtTitleFilter.BackColor = SystemColors.ActiveBorder;
            txtTitleFilter.BorderStyle = BorderStyle.None;
            txtTitleFilter.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitleFilter.Location = new Point(27, 108);
            txtTitleFilter.Margin = new Padding(23, 3, 23, 3);
            txtTitleFilter.Name = "txtTitleFilter";
            txtTitleFilter.Size = new Size(257, 34);
            txtTitleFilter.TabIndex = 12;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(12, 192, 223);
            button2.Location = new Point(27, 33);
            button2.Margin = new Padding(0, 16, 0, 0);
            button2.Name = "button2";
            button2.Size = new Size(257, 53);
            button2.TabIndex = 3;
            button2.Text = "Filter";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnApply
            // 
            btnApply.Anchor = AnchorStyles.Top;
            btnApply.BackColor = Color.Transparent;
            btnApply.BackgroundImage = Properties.Resources.grey_square;
            btnApply.BackgroundImageLayout = ImageLayout.Stretch;
            btnApply.FlatAppearance.BorderSize = 0;
            btnApply.FlatStyle = FlatStyle.Flat;
            btnApply.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnApply.ForeColor = Color.Black;
            btnApply.Location = new Point(55, 534);
            btnApply.Margin = new Padding(0, 16, 0, 0);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(187, 40);
            btnApply.TabIndex = 9;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = false;
            btnApply.Click += btnApply_Click;
            // 
            // chkOwned
            // 
            chkOwned.AutoSize = true;
            chkOwned.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkOwned.ForeColor = Color.LightGray;
            chkOwned.Location = new Point(27, 155);
            chkOwned.Name = "chkOwned";
            chkOwned.Size = new Size(95, 24);
            chkOwned.TabIndex = 15;
            chkOwned.Text = "Owned";
            chkOwned.UseVisualStyleBackColor = true;
            // 
            // chkWishlist
            // 
            chkWishlist.AutoSize = true;
            chkWishlist.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkWishlist.ForeColor = Color.LightGray;
            chkWishlist.Location = new Point(27, 185);
            chkWishlist.Name = "chkWishlist";
            chkWishlist.Size = new Size(102, 24);
            chkWishlist.TabIndex = 16;
            chkWishlist.Text = "Wishlist";
            chkWishlist.UseVisualStyleBackColor = true;
            // 
            // chkFavorite
            // 
            chkFavorite.AutoSize = true;
            chkFavorite.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkFavorite.ForeColor = Color.LightGray;
            chkFavorite.Location = new Point(27, 215);
            chkFavorite.Name = "chkFavorite";
            chkFavorite.Size = new Size(107, 24);
            chkFavorite.TabIndex = 17;
            chkFavorite.Text = "Favorite";
            chkFavorite.UseVisualStyleBackColor = true;
            // 
            // numMinPlayers
            // 
            numMinPlayers.Location = new Point(182, 248);
            numMinPlayers.Name = "numMinPlayers";
            numMinPlayers.Size = new Size(55, 27);
            numMinPlayers.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(55, 251);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 19;
            label2.Text = "Min. Players";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(50, 283);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 21;
            label3.Text = "Max. Players";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numMaxPlayers
            // 
            numMaxPlayers.Location = new Point(183, 281);
            numMaxPlayers.Name = "numMaxPlayers";
            numMaxPlayers.Size = new Size(55, 27);
            numMaxPlayers.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(46, 316);
            label4.Name = "label4";
            label4.Size = new Size(131, 20);
            label4.TabIndex = 23;
            label4.Text = "Playing Time";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numPlayingTime
            // 
            numPlayingTime.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numPlayingTime.Location = new Point(183, 315);
            numPlayingTime.Name = "numPlayingTime";
            numPlayingTime.Size = new Size(55, 27);
            numPlayingTime.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(71, 351);
            label5.Name = "label5";
            label5.Size = new Size(106, 20);
            label5.TabIndex = 25;
            label5.Text = "Player Age";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numAge
            // 
            numAge.Location = new Point(183, 349);
            numAge.Name = "numAge";
            numAge.Size = new Size(55, 27);
            numAge.TabIndex = 24;
            // 
            // clbCategories
            // 
            clbCategories.BackColor = SystemColors.ActiveBorder;
            clbCategories.FormattingEnabled = true;
            clbCategories.Location = new Point(27, 408);
            clbCategories.Name = "clbCategories";
            clbCategories.Size = new Size(257, 114);
            clbCategories.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LightGray;
            label6.Location = new Point(27, 385);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 27;
            label6.Text = "Categories";
            // 
            // FilterMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.dk_grey_square;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label6);
            Controls.Add(clbCategories);
            Controls.Add(label5);
            Controls.Add(numAge);
            Controls.Add(label4);
            Controls.Add(numPlayingTime);
            Controls.Add(label3);
            Controls.Add(numMaxPlayers);
            Controls.Add(label2);
            Controls.Add(numMinPlayers);
            Controls.Add(chkFavorite);
            Controls.Add(chkWishlist);
            Controls.Add(btnApply);
            Controls.Add(chkOwned);
            Controls.Add(button2);
            Controls.Add(txtTitleFilter);
            Controls.Add(label1);
            DoubleBuffered = true;
            Margin = new Padding(2, 3, 2, 3);
            Name = "FilterMenu";
            Size = new Size(319, 625);
            ((System.ComponentModel.ISupportInitialize)numMinPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPlayingTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitleFilter;
        private Button button2;
        private Button btnApply;
        private CheckBox chkOwned;
        private CheckBox chkWishlist;
        private CheckBox chkFavorite;
        private NumericUpDown numMinPlayers;
        private Label label2;
        private Label label3;
        private NumericUpDown numMaxPlayers;
        private Label label4;
        private NumericUpDown numPlayingTime;
        private Label label5;
        private NumericUpDown numAge;
        private CheckedListBox clbCategories;
        private Label label6;
    }
}
