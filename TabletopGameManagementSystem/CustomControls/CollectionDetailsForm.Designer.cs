namespace TabletopGameManagementSystem.CustomControls
{
    partial class CollectionDetailsForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCollectionName = new Label();
            lblDescription = new Label();
            gameCardContainer1 = new GameCardContainer();
            btnAddGame = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblCollectionName
            // 
            lblCollectionName.Anchor = AnchorStyles.None;
            lblCollectionName.AutoSize = true;
            lblCollectionName.BackColor = Color.Transparent;
            lblCollectionName.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCollectionName.ForeColor = Color.FromArgb(12, 192, 223);
            lblCollectionName.Location = new Point(24, 28);
            lblCollectionName.Name = "lblCollectionName";
            lblCollectionName.Size = new Size(280, 34);
            lblCollectionName.TabIndex = 29;
            lblCollectionName.Text = "Collection Name";
            // 
            // lblDescription
            // 
            lblDescription.Anchor = AnchorStyles.None;
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Broadway", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.Silver;
            lblDescription.Location = new Point(45, 62);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(161, 27);
            lblDescription.TabIndex = 30;
            lblDescription.Text = "Description";
            // 
            // gameCardContainer1
            // 
            gameCardContainer1.AutoScroll = true;
            gameCardContainer1.BackColor = Color.Transparent;
            gameCardContainer1.BorderStyle = BorderStyle.FixedSingle;
            gameCardContainer1.Location = new Point(89, 112);
            gameCardContainer1.Margin = new Padding(2, 3, 2, 3);
            gameCardContainer1.Name = "gameCardContainer1";
            gameCardContainer1.Size = new Size(903, 537);
            gameCardContainer1.TabIndex = 31;
            // 
            // btnAddGame
            // 
            btnAddGame.BackColor = Color.Transparent;
            btnAddGame.BackgroundImage = Properties.Resources.grey_square;
            btnAddGame.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddGame.FlatAppearance.BorderSize = 0;
            btnAddGame.FlatStyle = FlatStyle.Flat;
            btnAddGame.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddGame.ForeColor = Color.Black;
            btnAddGame.Location = new Point(599, 658);
            btnAddGame.Margin = new Padding(0, 150, 0, 0);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(147, 40);
            btnAddGame.TabIndex = 32;
            btnAddGame.Text = "Add Game";
            btnAddGame.UseVisualStyleBackColor = false;
            btnAddGame.Click += btnAddGame_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = Properties.Resources.grey_square;
            btnClose.BackgroundImageLayout = ImageLayout.Stretch;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(785, 658);
            btnClose.Margin = new Padding(0, 150, 0, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(147, 40);
            btnClose.TabIndex = 33;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // CollectionDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1085, 731);
            Controls.Add(btnClose);
            Controls.Add(btnAddGame);
            Controls.Add(gameCardContainer1);
            Controls.Add(lblDescription);
            Controls.Add(lblCollectionName);
            DoubleBuffered = true;
            Name = "CollectionDetailsForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Collection Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCollectionName;
        private Label lblDescription;
        private GameCardContainer gameCardContainer1;
        private Button btnAddGame;
        private Button btnClose;
    }
}