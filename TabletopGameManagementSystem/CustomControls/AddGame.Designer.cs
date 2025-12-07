namespace TabletopGameManagementSystem.CustomControls
{
    partial class AddGame
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
            CollectionDetailsPanel = new TableLayoutPanel();
            btnSaveNewGame = new Button();
            Title = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            numPlayingTime = new NumericUpDown();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            button3 = new Button();
            button7 = new Button();
            button6 = new Button();
            clbCategories = new CheckedListBox();
            txtDescription = new TextBox();
            numAge = new NumericUpDown();
            numMinPlayers = new NumericUpDown();
            button2 = new Button();
            numMaxPlayers = new NumericUpDown();
            txtName = new TextBox();
            CollectionDetailsPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numPlayingTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMinPlayers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxPlayers).BeginInit();
            SuspendLayout();
            // 
            // CollectionDetailsPanel
            // 
            CollectionDetailsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CollectionDetailsPanel.ColumnCount = 1;
            CollectionDetailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CollectionDetailsPanel.Controls.Add(btnSaveNewGame, 0, 2);
            CollectionDetailsPanel.Controls.Add(Title, 0, 0);
            CollectionDetailsPanel.Controls.Add(tableLayoutPanel1, 0, 1);
            CollectionDetailsPanel.Location = new Point(0, 36);
            CollectionDetailsPanel.Margin = new Padding(2, 3, 2, 3);
            CollectionDetailsPanel.Name = "CollectionDetailsPanel";
            CollectionDetailsPanel.RowCount = 3;
            CollectionDetailsPanel.RowStyles.Add(new RowStyle());
            CollectionDetailsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 450F));
            CollectionDetailsPanel.RowStyles.Add(new RowStyle());
            CollectionDetailsPanel.Size = new Size(500, 577);
            CollectionDetailsPanel.TabIndex = 4;
            // 
            // btnSaveNewGame
            // 
            btnSaveNewGame.Anchor = AnchorStyles.Top;
            btnSaveNewGame.BackColor = Color.Transparent;
            btnSaveNewGame.BackgroundImage = Properties.Resources.dk_grey_square;
            btnSaveNewGame.BackgroundImageLayout = ImageLayout.Stretch;
            btnSaveNewGame.FlatAppearance.BorderSize = 0;
            btnSaveNewGame.FlatStyle = FlatStyle.Flat;
            btnSaveNewGame.Font = new Font("Broadway", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveNewGame.ForeColor = Color.Black;
            btnSaveNewGame.Location = new Point(156, 517);
            btnSaveNewGame.Margin = new Padding(0);
            btnSaveNewGame.Name = "btnSaveNewGame";
            btnSaveNewGame.Size = new Size(187, 39);
            btnSaveNewGame.TabIndex = 10;
            btnSaveNewGame.Text = "Save";
            btnSaveNewGame.UseVisualStyleBackColor = false;
            btnSaveNewGame.Click += btnSaveNewGame_Click;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Title.BackColor = Color.Transparent;
            Title.FlatAppearance.BorderSize = 0;
            Title.FlatStyle = FlatStyle.Flat;
            Title.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.FromArgb(12, 192, 223);
            Title.Location = new Point(0, 16);
            Title.Margin = new Padding(0, 16, 0, 0);
            Title.Name = "Title";
            Title.Size = new Size(500, 51);
            Title.TabIndex = 4;
            Title.Text = "Add Game";
            Title.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.74359F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 71);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(494, 442);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.AutoScroll = true;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.92704F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.07296F));
            tableLayoutPanel3.Controls.Add(numPlayingTime, 1, 3);
            tableLayoutPanel3.Controls.Add(button1, 0, 0);
            tableLayoutPanel3.Controls.Add(button4, 0, 2);
            tableLayoutPanel3.Controls.Add(button5, 0, 3);
            tableLayoutPanel3.Controls.Add(button3, 0, 4);
            tableLayoutPanel3.Controls.Add(button7, 0, 5);
            tableLayoutPanel3.Controls.Add(button6, 0, 6);
            tableLayoutPanel3.Controls.Add(clbCategories, 1, 6);
            tableLayoutPanel3.Controls.Add(txtDescription, 1, 5);
            tableLayoutPanel3.Controls.Add(numAge, 1, 4);
            tableLayoutPanel3.Controls.Add(numMinPlayers, 1, 1);
            tableLayoutPanel3.Controls.Add(button2, 0, 1);
            tableLayoutPanel3.Controls.Add(numMaxPlayers, 1, 2);
            tableLayoutPanel3.Controls.Add(txtName, 1, 0);
            tableLayoutPanel3.Font = new Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel3.Location = new Point(3, 4);
            tableLayoutPanel3.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 7;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(488, 434);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // numPlayingTime
            // 
            numPlayingTime.Anchor = AnchorStyles.Left;
            numPlayingTime.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            numPlayingTime.Location = new Point(241, 170);
            numPlayingTime.Margin = new Padding(3, 4, 3, 4);
            numPlayingTime.Name = "numPlayingTime";
            numPlayingTime.Size = new Size(150, 23);
            numPlayingTime.TabIndex = 0;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.AutoSize = true;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Broadway", 12F);
            button1.ForeColor = Color.FromArgb(12, 192, 223);
            button1.Location = new Point(54, 16);
            button1.Margin = new Padding(0, 16, 0, 0);
            button1.Name = "button1";
            button1.Size = new Size(130, 32);
            button1.TabIndex = 5;
            button1.Text = "Name";
            button1.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top;
            button4.AutoSize = true;
            button4.BackColor = Color.Transparent;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Broadway", 12F);
            button4.ForeColor = Color.FromArgb(12, 192, 223);
            button4.Location = new Point(42, 120);
            button4.Margin = new Padding(0, 16, 0, 0);
            button4.Name = "button4";
            button4.Size = new Size(153, 32);
            button4.TabIndex = 8;
            button4.Text = "Max Players";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top;
            button5.AutoSize = true;
            button5.BackColor = Color.Transparent;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Broadway", 12F);
            button5.ForeColor = Color.FromArgb(12, 192, 223);
            button5.Location = new Point(38, 172);
            button5.Margin = new Padding(0, 16, 0, 0);
            button5.Name = "button5";
            button5.Size = new Size(162, 32);
            button5.TabIndex = 10;
            button5.Text = "Playing Time";
            button5.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.AutoSize = true;
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Broadway", 12F);
            button3.ForeColor = Color.FromArgb(12, 192, 223);
            button3.Location = new Point(54, 224);
            button3.Margin = new Padding(0, 16, 0, 0);
            button3.Name = "button3";
            button3.Size = new Size(130, 32);
            button3.TabIndex = 9;
            button3.Text = "Min Age";
            button3.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top;
            button7.AutoSize = true;
            button7.BackColor = Color.Transparent;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Broadway", 12F);
            button7.ForeColor = Color.FromArgb(12, 192, 223);
            button7.Location = new Point(45, 276);
            button7.Margin = new Padding(0, 16, 0, 0);
            button7.Name = "button7";
            button7.Size = new Size(147, 32);
            button7.TabIndex = 12;
            button7.Text = "Description";
            button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top;
            button6.AutoSize = true;
            button6.BackColor = Color.Transparent;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Broadway", 12F);
            button6.ForeColor = Color.FromArgb(12, 192, 223);
            button6.Location = new Point(53, 328);
            button6.Margin = new Padding(0, 16, 0, 0);
            button6.Name = "button6";
            button6.Size = new Size(131, 32);
            button6.TabIndex = 11;
            button6.Text = "Category";
            button6.UseVisualStyleBackColor = false;
            // 
            // clbCategories
            // 
            clbCategories.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            clbCategories.FormattingEnabled = true;
            clbCategories.Location = new Point(241, 316);
            clbCategories.Margin = new Padding(3, 4, 3, 4);
            clbCategories.Name = "clbCategories";
            clbCategories.Size = new Size(244, 112);
            clbCategories.TabIndex = 16;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(241, 264);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(244, 44);
            txtDescription.TabIndex = 17;
            // 
            // numAge
            // 
            numAge.Anchor = AnchorStyles.Left;
            numAge.Location = new Point(241, 222);
            numAge.Margin = new Padding(3, 4, 3, 4);
            numAge.Name = "numAge";
            numAge.Size = new Size(150, 23);
            numAge.TabIndex = 18;
            // 
            // numMinPlayers
            // 
            numMinPlayers.Dock = DockStyle.Left;
            numMinPlayers.Location = new Point(241, 56);
            numMinPlayers.Margin = new Padding(3, 4, 3, 4);
            numMinPlayers.Name = "numMinPlayers";
            numMinPlayers.Size = new Size(150, 23);
            numMinPlayers.TabIndex = 20;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.AutoSize = true;
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Broadway", 12F);
            button2.ForeColor = Color.FromArgb(12, 192, 223);
            button2.Location = new Point(45, 68);
            button2.Margin = new Padding(0, 16, 0, 0);
            button2.Name = "button2";
            button2.Size = new Size(147, 32);
            button2.TabIndex = 6;
            button2.Text = "Min Players";
            button2.UseVisualStyleBackColor = false;
            // 
            // numMaxPlayers
            // 
            numMaxPlayers.Dock = DockStyle.Left;
            numMaxPlayers.Location = new Point(241, 108);
            numMaxPlayers.Margin = new Padding(3, 4, 3, 4);
            numMaxPlayers.Name = "numMaxPlayers";
            numMaxPlayers.Size = new Size(150, 23);
            numMaxPlayers.TabIndex = 21;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Left;
            txtName.Location = new Point(241, 4);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(213, 23);
            txtName.TabIndex = 15;
            // 
            // AddGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.grey_square;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(CollectionDetailsPanel);
            DoubleBuffered = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddGame";
            Size = new Size(500, 649);
            CollectionDetailsPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numPlayingTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMinPlayers).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxPlayers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel CollectionDetailsPanel;
        private Button Title;
        private Button btnSaveNewGame;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button3;
        private Button button7;
        private Button button6;
        private TextBox txtName;
        private CheckedListBox clbCategories;
        private TextBox txtDescription;
        private NumericUpDown numAge;
        private NumericUpDown numPlayingTime;
        private NumericUpDown numMinPlayers;
        private NumericUpDown numMaxPlayers;
    }
}
