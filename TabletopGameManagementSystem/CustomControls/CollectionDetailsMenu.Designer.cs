namespace TabletopGameManagementSystem.CustomControls
{
    partial class CollectionDetailsMenu
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
            comboBox2 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            apply_collection_btn = new Button();
            Title = new Button();
            Collection_name_input = new TextBox();
            label1 = new Label();
            comboBox1 = new ComboBox();
            CollectionDetailsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CollectionDetailsPanel
            // 
            CollectionDetailsPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CollectionDetailsPanel.ColumnCount = 1;
            CollectionDetailsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            CollectionDetailsPanel.Controls.Add(comboBox2, 0, 6);
            CollectionDetailsPanel.Controls.Add(label3, 0, 5);
            CollectionDetailsPanel.Controls.Add(label2, 0, 3);
            CollectionDetailsPanel.Controls.Add(apply_collection_btn, 0, 7);
            CollectionDetailsPanel.Controls.Add(Title, 0, 0);
            CollectionDetailsPanel.Controls.Add(Collection_name_input, 0, 2);
            CollectionDetailsPanel.Controls.Add(label1, 0, 1);
            CollectionDetailsPanel.Controls.Add(comboBox1, 0, 4);
            CollectionDetailsPanel.Location = new Point(0, 27);
            CollectionDetailsPanel.Margin = new Padding(2);
            CollectionDetailsPanel.Name = "CollectionDetailsPanel";
            CollectionDetailsPanel.RowCount = 8;
            CollectionDetailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            CollectionDetailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            CollectionDetailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            CollectionDetailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            CollectionDetailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            CollectionDetailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            CollectionDetailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            CollectionDetailsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            CollectionDetailsPanel.Size = new Size(279, 389);
            CollectionDetailsPanel.TabIndex = 3;
            // 
            // comboBox2
            // 
            comboBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            comboBox2.BackColor = SystemColors.ActiveBorder;
            comboBox2.FlatStyle = FlatStyle.Popup;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(20, 290);
            comboBox2.Margin = new Padding(20, 2, 20, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(239, 23);
            comboBox2.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Broadway", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveBorder;
            label3.Location = new Point(98, 253);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 17;
            label3.Text = "Colour:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveBorder;
            label2.Location = new Point(109, 157);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 16;
            label2.Text = "Icon:";
            // 
            // apply_collection_btn
            // 
            apply_collection_btn.Anchor = AnchorStyles.Top;
            apply_collection_btn.BackColor = Color.Transparent;
            apply_collection_btn.BackgroundImage = Properties.Resources.grey_square;
            apply_collection_btn.BackgroundImageLayout = ImageLayout.Stretch;
            apply_collection_btn.FlatAppearance.BorderSize = 0;
            apply_collection_btn.FlatStyle = FlatStyle.Flat;
            apply_collection_btn.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            apply_collection_btn.ForeColor = Color.Black;
            apply_collection_btn.Location = new Point(57, 348);
            apply_collection_btn.Margin = new Padding(0, 12, 0, 0);
            apply_collection_btn.Name = "apply_collection_btn";
            apply_collection_btn.Size = new Size(164, 37);
            apply_collection_btn.TabIndex = 9;
            apply_collection_btn.Text = "Apply";
            apply_collection_btn.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Title.BackColor = Color.Transparent;
            Title.FlatAppearance.BorderSize = 0;
            Title.FlatStyle = FlatStyle.Flat;
            Title.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.FromArgb(12, 192, 223);
            Title.Location = new Point(0, 12);
            Title.Margin = new Padding(0, 12, 0, 0);
            Title.Name = "Title";
            Title.Size = new Size(279, 36);
            Title.TabIndex = 3;
            Title.Text = "Collection Details";
            Title.UseVisualStyleBackColor = false;
            // 
            // Collection_name_input
            // 
            Collection_name_input.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            Collection_name_input.BackColor = SystemColors.ActiveBorder;
            Collection_name_input.BorderStyle = BorderStyle.None;
            Collection_name_input.Font = new Font("Broadway", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Collection_name_input.Location = new Point(20, 98);
            Collection_name_input.Margin = new Padding(20, 2, 20, 2);
            Collection_name_input.Name = "Collection_name_input";
            Collection_name_input.Size = new Size(239, 28);
            Collection_name_input.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Broadway", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveBorder;
            label1.Location = new Point(48, 61);
            label1.Name = "label1";
            label1.Size = new Size(182, 21);
            label1.TabIndex = 14;
            label1.Text = "Collection Name:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            comboBox1.BackColor = SystemColors.ActiveBorder;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 194);
            comboBox1.Margin = new Padding(20, 2, 20, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 23);
            comboBox1.TabIndex = 15;
            // 
            // CollectionDetailsMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            BackgroundImage = Properties.Resources.dk_grey_square;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(CollectionDetailsPanel);
            DoubleBuffered = true;
            Name = "CollectionDetailsMenu";
            Size = new Size(279, 443);
            CollectionDetailsPanel.ResumeLayout(false);
            CollectionDetailsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel CollectionDetailsPanel;
        private Button apply_collection_btn;
        private Button Title;
        private TextBox Collection_name_input;
        private Label label1;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}
