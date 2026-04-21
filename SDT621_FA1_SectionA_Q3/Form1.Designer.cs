namespace SDT621_FA1_SectionA_Q3
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
            lblTItle = new Label();
            lstLanguages = new ListBox();
            txtLanguage = new TextBox();
            button1 = new Button();
            btnRemove = new Button();
            btnAdd = new Button();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblTItle
            // 
            lblTItle.AutoSize = true;
            lblTItle.Font = new Font("Simple Indust Shaded", 20F, FontStyle.Regular, GraphicsUnit.Point, 178);
            lblTItle.Location = new Point(592, 159);
            lblTItle.Name = "lblTItle";
            lblTItle.Size = new Size(1490, 109);
            lblTItle.TabIndex = 0;
            lblTItle.Text = "My Favourite Programming Languages";
            lblTItle.Click += label1_Click;
            // 
            // lstLanguages
            // 
            lstLanguages.FormattingEnabled = true;
            lstLanguages.ItemHeight = 37;
            lstLanguages.Location = new Point(592, 330);
            lstLanguages.Name = "lstLanguages";
            lstLanguages.Size = new Size(1122, 263);
            lstLanguages.TabIndex = 1;
            // 
            // txtLanguage
            // 
            txtLanguage.Location = new Point(592, 645);
            txtLanguage.Name = "txtLanguage";
            txtLanguage.PlaceholderText = "Enter programming language";
            txtLanguage.Size = new Size(1129, 43);
            txtLanguage.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(691, 527);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Red;
            btnRemove.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(1008, 781);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(293, 52);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Cyan;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(592, 781);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(341, 52);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add Language";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(592, 890);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 37);
            lblStatus.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2332, 1232);
            Controls.Add(lblStatus);
            Controls.Add(btnAdd);
            Controls.Add(btnRemove);
            Controls.Add(button1);
            Controls.Add(txtLanguage);
            Controls.Add(lstLanguages);
            Controls.Add(lblTItle);
            Name = "Form1";
            Text = "Favourite Programming Languages";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTItle;
        private ListBox lstLanguages;
        private TextBox txtLanguage;
        private Button button1;
        private Button btnRemove;
        private Button btnAdd;
        private Label lblStatus;
    }
}
