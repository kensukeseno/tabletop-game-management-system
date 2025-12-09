namespace TabletopGameManagementSystem.CustomControls.Views
{
    partial class AllGamesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllGamesView));
            games_layoutPanel = new TableLayoutPanel();
            gameCardContainer1 = new GameCardContainer();
            filterMenu1 = new FilterMenu();
            btnAddNewGame = new Button();
            games_layoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // games_layoutPanel
            // 
            games_layoutPanel.BackColor = Color.Transparent;
            games_layoutPanel.ColumnCount = 2;
            games_layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.04223F));
            games_layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.95777F));
            games_layoutPanel.Controls.Add(gameCardContainer1, 0, 0);
            games_layoutPanel.Controls.Add(filterMenu1, 0, 1);
            games_layoutPanel.Controls.Add(btnAddNewGame, 1, 0);
            games_layoutPanel.Dock = DockStyle.Fill;
            games_layoutPanel.Location = new Point(0, 0);
            games_layoutPanel.Margin = new Padding(3, 4, 3, 4);
            games_layoutPanel.Name = "games_layoutPanel";
            games_layoutPanel.RowCount = 2;
            games_layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            games_layoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            games_layoutPanel.Size = new Size(1191, 651);
            games_layoutPanel.TabIndex = 5;
            // 
            // gameCardContainer1
            // 
            gameCardContainer1.AutoScroll = true;
            gameCardContainer1.BackColor = Color.Transparent;
            gameCardContainer1.Location = new Point(2, 3);
            gameCardContainer1.Margin = new Padding(2, 3, 2, 3);
            gameCardContainer1.Name = "gameCardContainer1";
            games_layoutPanel.SetRowSpan(gameCardContainer1, 2);
            gameCardContainer1.Size = new Size(806, 645);
            gameCardContainer1.TabIndex = 1;
            // 
            // filterMenu1
            // 
            filterMenu1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            filterMenu1.BackColor = Color.Transparent;
            filterMenu1.BackgroundImage = (Image)resources.GetObject("filterMenu1.BackgroundImage");
            filterMenu1.BackgroundImageLayout = ImageLayout.Stretch;
            filterMenu1.Location = new Point(812, 68);
            filterMenu1.Margin = new Padding(2, 3, 2, 3);
            filterMenu1.Name = "filterMenu1";
            filterMenu1.Size = new Size(377, 580);
            filterMenu1.TabIndex = 0;
            // 
            // btnAddNewGame
            // 
            btnAddNewGame.Anchor = AnchorStyles.Top;
            btnAddNewGame.BackColor = Color.Transparent;
            btnAddNewGame.BackgroundImage = Properties.Resources.grey_square;
            btnAddNewGame.BackgroundImageLayout = ImageLayout.Stretch;
            btnAddNewGame.FlatAppearance.BorderSize = 0;
            btnAddNewGame.FlatStyle = FlatStyle.Flat;
            btnAddNewGame.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddNewGame.ForeColor = Color.Black;
            btnAddNewGame.Location = new Point(876, 16);
            btnAddNewGame.Margin = new Padding(0, 16, 0, 0);
            btnAddNewGame.Name = "btnAddNewGame";
            btnAddNewGame.Size = new Size(249, 40);
            btnAddNewGame.TabIndex = 10;
            btnAddNewGame.Text = "+ Add Game";
            btnAddNewGame.UseVisualStyleBackColor = false;
            btnAddNewGame.Click += btnAddNewGame_Click;
            // 
            // AllGamesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(games_layoutPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AllGamesView";
            Size = new Size(1191, 651);
            games_layoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel games_layoutPanel;
        private GameCardContainer gameCardContainer1;
        private FilterMenu filterMenu1;
        private Button btnAddNewGame;
    }
}
