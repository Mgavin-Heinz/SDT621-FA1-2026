namespace SDT621_FA1_SectionB_Q2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblTitle = new Label();
            lblName = new Label();
            lblID = new Label();
            lblCTZ = new Label();
            txtName = new TextBox();
            txtID = new TextBox();
            comboBoxCTZ = new ComboBox();
            btnValidate = new Button();
            lblValidID = new Label();
            txtProfile = new TextBox();
            btnProfile = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.OliveDrab;
            lblTitle.Location = new Point(514, 27);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(571, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Home Affairs Digital Identity Processor";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(505, 77);
            lblName.Margin = new Padding(2, 0, 2, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(140, 20);
            lblName.TabIndex = 1;
            lblName.Text = " Enter your Name: ";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(514, 126);
            lblID.Margin = new Padding(2, 0, 2, 0);
            lblID.Name = "lblID";
            lblID.Size = new Size(110, 20);
            lblID.TabIndex = 2;
            lblID.Text = "Enter your ID: ";
            // 
            // lblCTZ
            // 
            lblCTZ.AutoSize = true;
            lblCTZ.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCTZ.Location = new Point(514, 176);
            lblCTZ.Margin = new Padding(2, 0, 2, 0);
            lblCTZ.Name = "lblCTZ";
            lblCTZ.Size = new Size(155, 20);
            lblCTZ.TabIndex = 3;
            lblCTZ.Text = "Choose your Citizen: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(744, 77);
            txtName.Margin = new Padding(2);
            txtName.Name = "txtName";
            txtName.Size = new Size(215, 27);
            txtName.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(744, 119);
            txtID.Margin = new Padding(2);
            txtID.Name = "txtID";
            txtID.Size = new Size(215, 27);
            txtID.TabIndex = 6;
            // 
            // comboBoxCTZ
            // 
            comboBoxCTZ.FormattingEnabled = true;
            comboBoxCTZ.Items.AddRange(new object[] { "South African", "", "Permanent Resident", "", "Visitor" });
            comboBoxCTZ.Location = new Point(742, 168);
            comboBoxCTZ.Margin = new Padding(2);
            comboBoxCTZ.Name = "comboBoxCTZ";
            comboBoxCTZ.Size = new Size(217, 28);
            comboBoxCTZ.TabIndex = 7;
            // 
            // btnValidate
            // 
            btnValidate.BackColor = Color.ForestGreen;
            btnValidate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidate.Location = new Point(742, 241);
            btnValidate.Margin = new Padding(2);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(148, 31);
            btnValidate.TabIndex = 8;
            btnValidate.Text = "Validate ID";
            btnValidate.UseVisualStyleBackColor = false;
            btnValidate.Click += btnValidate_Click;
            // 
            // lblValidID
            // 
            lblValidID.AutoSize = true;
            lblValidID.Location = new Point(744, 274);
            lblValidID.Margin = new Padding(2, 0, 2, 0);
            lblValidID.Name = "lblValidID";
            lblValidID.Size = new Size(0, 20);
            lblValidID.TabIndex = 9;
            // 
            // txtProfile
            // 
            txtProfile.Location = new Point(744, 324);
            txtProfile.Margin = new Padding(2);
            txtProfile.Multiline = true;
            txtProfile.Name = "txtProfile";
            txtProfile.ScrollBars = ScrollBars.Vertical;
            txtProfile.Size = new Size(245, 238);
            txtProfile.TabIndex = 10;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.ForestGreen;
            btnProfile.Location = new Point(744, 614);
            btnProfile.Margin = new Padding(2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(176, 33);
            btnProfile.TabIndex = 11;
            btnProfile.Text = "Generate profile";
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(465, 652);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSalmon;
            ClientSize = new Size(1821, 700);
            Controls.Add(pictureBox1);
            Controls.Add(btnProfile);
            Controls.Add(txtProfile);
            Controls.Add(lblValidID);
            Controls.Add(btnValidate);
            Controls.Add(comboBoxCTZ);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(lblCTZ);
            Controls.Add(lblID);
            Controls.Add(lblName);
            Controls.Add(lblTitle);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(2);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblName;
        private Label lblID;
        private Label lblCTZ;
        private TextBox txtName;
        private TextBox txtID;
        private ComboBox comboBoxCTZ;
        private Button btnValidate;
        private Label lblValidID;
        private TextBox txtProfile;
        private Button btnProfile;
        private PictureBox pictureBox1;
    }
}
