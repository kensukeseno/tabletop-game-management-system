namespace TabletopGameManagementSystem.CustomControls
{
    partial class SelectGameForm
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
            gameCardContainer1 = new GameCardContainer();
            lblCollectionName = new Label();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // gameCardContainer1
            // 
            gameCardContainer1.AutoScroll = true;
            gameCardContainer1.BackColor = Color.Transparent;
            gameCardContainer1.Location = new Point(62, 92);
            gameCardContainer1.Margin = new Padding(2, 3, 2, 3);
            gameCardContainer1.Name = "gameCardContainer1";
            gameCardContainer1.Size = new Size(535, 474);
            gameCardContainer1.TabIndex = 0;
            // 
            // lblCollectionName
            // 
            lblCollectionName.Anchor = AnchorStyles.None;
            lblCollectionName.AutoSize = true;
            lblCollectionName.BackColor = Color.Transparent;
            lblCollectionName.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCollectionName.ForeColor = Color.FromArgb(12, 192, 223);
            lblCollectionName.Location = new Point(34, 26);
            lblCollectionName.Name = "lblCollectionName";
            lblCollectionName.Size = new Size(368, 34);
            lblCollectionName.TabIndex = 30;
            lblCollectionName.Text = "Select A Game To Add";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackgroundImage = Properties.Resources.grey_square;
            btnCancel.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(387, 603);
            btnCancel.Margin = new Padding(0, 150, 0, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(147, 40);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // SelectGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(642, 694);
            Controls.Add(btnCancel);
            Controls.Add(lblCollectionName);
            Controls.Add(gameCardContainer1);
            DoubleBuffered = true;
            Name = "SelectGameForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Select Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GameCardContainer gameCardContainer1;
        private Label lblCollectionName;
        private Button btnCancel;
    }
}