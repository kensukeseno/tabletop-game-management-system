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
            label1.Location = new Point(24, 64);
            label1.Name = "label1";
            label1.Size = new Size(123, 16);
            label1.TabIndex = 14;
            label1.Text = "Name Contains";
            // 
            // txtTitleFilter
            // 
            txtTitleFilter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            txtTitleFilter.BackColor = SystemColors.ActiveBorder;
            txtTitleFilter.BorderStyle = BorderStyle.None;
            txtTitleFilter.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitleFilter.Location = new Point(24, 81);
            txtTitleFilter.Margin = new Padding(20, 2, 20, 2);
            txtTitleFilter.Name = "txtTitleFilter";
            txtTitleFilter.Size = new Size(225, 28);
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
            button2.Location = new Point(24, 12);
            button2.Margin = new Padding(0, 12, 0, 0);
            button2.Name = "button2";
            button2.Size = new Size(225, 40);
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
            btnApply.Location = new Point(51, 378);
            btnApply.Margin = new Padding(0, 12, 0, 0);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(164, 30);
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
            chkOwned.Location = new Point(24, 116);
            chkOwned.Margin = new Padding(3, 2, 3, 2);
            chkOwned.Name = "chkOwned";
            chkOwned.Size = new Size(78, 20);
            chkOwned.TabIndex = 15;
            chkOwned.Text = "Owned";
            chkOwned.UseVisualStyleBackColor = true;
            // 
            // chkWishlist
            // 
            chkWishlist.AutoSize = true;
            chkWishlist.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkWishlist.ForeColor = Color.LightGray;
            chkWishlist.Location = new Point(24, 139);
            chkWishlist.Margin = new Padding(3, 2, 3, 2);
            chkWishlist.Name = "chkWishlist";
            chkWishlist.Size = new Size(86, 20);
            chkWishlist.TabIndex = 16;
            chkWishlist.Text = "Wishlist";
            chkWishlist.UseVisualStyleBackColor = true;
            // 
            // chkFavorite
            // 
            chkFavorite.AutoSize = true;
            chkFavorite.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkFavorite.ForeColor = Color.LightGray;
            chkFavorite.Location = new Point(24, 161);
            chkFavorite.Margin = new Padding(3, 2, 3, 2);
            chkFavorite.Name = "chkFavorite";
            chkFavorite.Size = new Size(88, 20);
            chkFavorite.TabIndex = 17;
            chkFavorite.Text = "Favorite";
            chkFavorite.UseVisualStyleBackColor = true;
            // 
            // numMinPlayers
            // 
            numMinPlayers.Location = new Point(159, 186);
            numMinPlayers.Margin = new Padding(3, 2, 3, 2);
            numMinPlayers.Name = "numMinPlayers";
            numMinPlayers.Size = new Size(48, 23);
            numMinPlayers.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(48, 188);
            label2.Name = "label2";
            label2.Size = new Size(101, 16);
            label2.TabIndex = 19;
            label2.Text = "Min. Players";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(44, 212);
            label3.Name = "label3";
            label3.Size = new Size(105, 16);
            label3.TabIndex = 21;
            label3.Text = "Max. Players";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numMaxPlayers
            // 
            numMaxPlayers.Location = new Point(160, 211);
            numMaxPlayers.Margin = new Padding(3, 2, 3, 2);
            numMaxPlayers.Name = "numMaxPlayers";
            numMaxPlayers.Size = new Size(48, 23);
            numMaxPlayers.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.LightGray;
            label4.Location = new Point(40, 237);
            label4.Name = "label4";
            label4.Size = new Size(108, 16);
            label4.TabIndex = 23;
            label4.Text = "Playing Time";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numPlayingTime
            // 
            numPlayingTime.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numPlayingTime.Location = new Point(160, 236);
            numPlayingTime.Margin = new Padding(3, 2, 3, 2);
            numPlayingTime.Name = "numPlayingTime";
            numPlayingTime.Size = new Size(48, 23);
            numPlayingTime.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightGray;
            label5.Location = new Point(62, 263);
            label5.Name = "label5";
            label5.Size = new Size(87, 16);
            label5.TabIndex = 25;
            label5.Text = "Player Age";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // numAge
            // 
            numAge.Location = new Point(160, 262);
            numAge.Margin = new Padding(3, 2, 3, 2);
            numAge.Name = "numAge";
            numAge.Size = new Size(48, 23);
            numAge.TabIndex = 24;
            // 
            // FilterMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.dk_grey_square;
            BackgroundImageLayout = ImageLayout.Stretch;
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
            Margin = new Padding(2, 2, 2, 2);
            Name = "FilterMenu";
            Size = new Size(279, 443);
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
    }
}
