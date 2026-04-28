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
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(2449, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(473, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Home Affairs Digital Identity Processor";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(2449, 224);
            lblName.Name = "lblName";
            lblName.Size = new Size(236, 37);
            lblName.TabIndex = 1;
            lblName.Text = " Enter your Name: ";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(2468, 319);
            lblID.Name = "lblID";
            lblID.Size = new Size(184, 37);
            lblID.TabIndex = 2;
            lblID.Text = "Enter your ID: ";
            // 
            // lblCTZ
            // 
            lblCTZ.AutoSize = true;
            lblCTZ.Location = new Point(2449, 424);
            lblCTZ.Name = "lblCTZ";
            lblCTZ.Size = new Size(267, 37);
            lblCTZ.TabIndex = 3;
            lblCTZ.Text = "Choose your Citizen: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(2900, 221);
            txtName.Name = "txtName";
            txtName.Size = new Size(399, 43);
            txtName.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(2900, 313);
            txtID.Name = "txtID";
            txtID.Size = new Size(399, 43);
            txtID.TabIndex = 6;
            // 
            // comboBoxCTZ
            // 
            comboBoxCTZ.FormattingEnabled = true;
            comboBoxCTZ.Items.AddRange(new object[] { "South African", "", "Permanent Resident", "", "Visitor" });
            comboBoxCTZ.Location = new Point(2900, 416);
            comboBoxCTZ.Name = "comboBoxCTZ";
            comboBoxCTZ.Size = new Size(403, 45);
            comboBoxCTZ.TabIndex = 7;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(2966, 529);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(278, 57);
            btnValidate.TabIndex = 8;
            btnValidate.Text = "Validate ID";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // lblValidID
            // 
            lblValidID.AutoSize = true;
            lblValidID.Location = new Point(2905, 672);
            lblValidID.Name = "lblValidID";
            lblValidID.Size = new Size(0, 37);
            lblValidID.TabIndex = 9;
            // 
            // txtProfile
            // 
            txtProfile.Location = new Point(2932, 757);
            txtProfile.Multiline = true;
            txtProfile.Name = "txtProfile";
            txtProfile.ScrollBars = ScrollBars.Vertical;
            txtProfile.Size = new Size(455, 436);
            txtProfile.TabIndex = 10;
            // 
            // btnProfile
            // 
            btnProfile.Location = new Point(2966, 1255);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(330, 61);
            btnProfile.TabIndex = 11;
            btnProfile.Text = "Generate profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(3589, 1501);
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
            Name = "Form1";
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
    }
}
