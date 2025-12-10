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
            btnEdit = new Button();
            lblName = new Label();
            lblDescription = new Label();
            btnOpen = new Button();
            btnDelete = new Button();
            lblGameCount = new Label();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Transparent;
            btnEdit.BackgroundImage = Properties.Resources.grey_square;
            btnEdit.BackgroundImageLayout = ImageLayout.Stretch;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = Color.Black;
            btnEdit.Location = new Point(95, 184);
            btnEdit.Margin = new Padding(0, 150, 0, 0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 40);
            btnEdit.TabIndex = 19;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblName
            // 
            lblName.Anchor = AnchorStyles.Top;
            lblName.AutoSize = true;
            lblName.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ActiveBorder;
            lblName.Location = new Point(105, 0);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(87, 34);
            lblName.TabIndex = 2;
            lblName.Text = "NEW";
            // 
            // lblDescription
            // 
            lblDescription.ForeColor = SystemColors.ControlLightLight;
            lblDescription.Location = new Point(-1, 72);
            lblDescription.Margin = new Padding(3, 20, 3, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(297, 108);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "label1";
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.Transparent;
            btnOpen.BackgroundImage = Properties.Resources.grey_square;
            btnOpen.BackgroundImageLayout = ImageLayout.Stretch;
            btnOpen.FlatAppearance.BorderSize = 0;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOpen.ForeColor = Color.Black;
            btnOpen.Location = new Point(-5, 184);
            btnOpen.Margin = new Padding(0, 150, 0, 0);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(100, 40);
            btnOpen.TabIndex = 20;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.BackgroundImage = Properties.Resources.grey_square;
            btnDelete.BackgroundImageLayout = ImageLayout.Stretch;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Black;
            btnDelete.Location = new Point(195, 184);
            btnDelete.Margin = new Padding(0, 150, 0, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 40);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Remove";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblGameCount
            // 
            lblGameCount.ForeColor = SystemColors.ControlLightLight;
            lblGameCount.Location = new Point(-1, 34);
            lblGameCount.Margin = new Padding(3, 20, 3, 0);
            lblGameCount.Name = "lblGameCount";
            lblGameCount.Size = new Size(297, 30);
            lblGameCount.TabIndex = 22;
            lblGameCount.Text = "label1";
            lblGameCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CollectionCard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImageLayout = ImageLayout.Stretch;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblGameCount);
            Controls.Add(btnOpen);
            Controls.Add(btnDelete);
            Controls.Add(lblName);
            Controls.Add(btnEdit);
            Controls.Add(lblDescription);
            DoubleBuffered = true;
            Margin = new Padding(10);
            Name = "CollectionCard";
            Size = new Size(295, 235);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Label lblName;
        private Button btnDelete;
        private Button btnOpen;
        private Label lblDescription;
        private Label lblGameCount;
    }
}
