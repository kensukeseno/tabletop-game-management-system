namespace TabletopGameManagementSystem.CustomControls
{
    partial class InputDialog
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
            lblName = new Label();
            txtName = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            lblDesc = new Label();
            txtDescription = new TextBox();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ActiveBorder;
            lblName.Location = new Point(29, 26);
            lblName.Name = "lblName";
            lblName.Size = new Size(79, 28);
            lblName.TabIndex = 0;
            lblName.Text = "Name :";
            // 
            // txtName
            // 
            txtName.Location = new Point(29, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(350, 27);
            txtName.TabIndex = 1;
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.Transparent;
            btnOK.BackgroundImage = Properties.Resources.grey_square;
            btnOK.BackgroundImageLayout = ImageLayout.Stretch;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnOK.ForeColor = Color.Black;
            btnOK.Location = new Point(157, 206);
            btnOK.Margin = new Padding(0, 150, 0, 0);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(100, 40);
            btnOK.TabIndex = 21;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BackgroundImage = Properties.Resources.grey_square;
            btnCancel.BackgroundImageLayout = ImageLayout.Stretch;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Broadway", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.Black;
            btnCancel.Location = new Point(279, 206);
            btnCancel.Margin = new Padding(0, 150, 0, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 40);
            btnCancel.TabIndex = 22;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.BackColor = Color.Transparent;
            lblDesc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesc.ForeColor = SystemColors.ActiveBorder;
            lblDesc.Location = new Point(29, 108);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(132, 28);
            lblDesc.TabIndex = 24;
            lblDesc.Text = "Description :";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(29, 139);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(350, 55);
            txtDescription.TabIndex = 25;
            // 
            // InputDialog
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = Properties.Resources.dk_grey_square;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(414, 269);
            Controls.Add(txtDescription);
            Controls.Add(lblDesc);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtName);
            Controls.Add(lblName);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InputDialog";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Button btnOK;
        private Button btnCancel;
        private Label lblDesc;
        private TextBox txtDescription;
    }
}