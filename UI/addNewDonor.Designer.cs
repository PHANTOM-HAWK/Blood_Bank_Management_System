namespace BloodBankManagementSystem
{
    partial class addNewDonor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addNewDonor));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            txtName = new TextBox();
            txtFather = new TextBox();
            txtMother = new TextBox();
            txtMobile = new TextBox();
            txtDob = new DateTimePicker();
            txtGender = new ComboBox();
            txtBloodGroup = new ComboBox();
            txtCity = new TextBox();
            txtAddress = new RichTextBox();
            labelNewId = new TextBox();
            txtEmail = new TextBox();
            btnSave = new Button();
            btnReset = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Book Antiqua", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(280, 20);
            label1.Name = "label1";
            label1.Size = new Size(338, 41);
            label1.TabIndex = 4;
            label1.Text = "ADD NEW DONOR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(118, 98);
            label2.Name = "label2";
            label2.Size = new Size(118, 23);
            label2.TabIndex = 5;
            label2.Text = "New Donor Id";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(118, 197);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 6;
            label3.Text = "Father Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(118, 305);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 7;
            label4.Text = "Date of Birth";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(460, 145);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(118, 252);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 9;
            label6.Text = "Mother Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.Location = new Point(460, 252);
            label7.Name = "label7";
            label7.Size = new Size(40, 23);
            label7.TabIndex = 10;
            label7.Text = "City";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.Location = new Point(460, 197);
            label8.Name = "label8";
            label8.Size = new Size(107, 23);
            label8.TabIndex = 11;
            label8.Text = "Blood Group";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.Location = new Point(460, 305);
            label9.Name = "label9";
            label9.Size = new Size(70, 23);
            label9.TabIndex = 12;
            label9.Text = "Address";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label10.Location = new Point(118, 401);
            label10.Name = "label10";
            label10.Size = new Size(66, 23);
            label10.TabIndex = 13;
            label10.Text = "Gender";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label11.Location = new Point(118, 354);
            label11.Name = "label11";
            label11.Size = new Size(63, 23);
            label11.TabIndex = 14;
            label11.Text = "Mobile";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label12.Location = new Point(118, 145);
            label12.Name = "label12";
            label12.Size = new Size(56, 23);
            label12.TabIndex = 15;
            label12.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(232, 145);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 27);
            txtName.TabIndex = 16;
            // 
            // txtFather
            // 
            txtFather.Location = new Point(232, 193);
            txtFather.Name = "txtFather";
            txtFather.Size = new Size(199, 27);
            txtFather.TabIndex = 17;
            // 
            // txtMother
            // 
            txtMother.Location = new Point(232, 252);
            txtMother.Name = "txtMother";
            txtMother.Size = new Size(199, 27);
            txtMother.TabIndex = 18;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(232, 354);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(199, 27);
            txtMobile.TabIndex = 19;
            txtMobile.TextChanged += txtMobile_TextChanged;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(232, 305);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(199, 27);
            txtDob.TabIndex = 20;
            // 
            // txtGender
            // 
            txtGender.DropDownStyle = ComboBoxStyle.DropDownList;
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female" });
            txtGender.Location = new Point(232, 400);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(199, 28);
            txtGender.TabIndex = 21;
            txtGender.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtBloodGroup
            // 
            txtBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBloodGroup.FormattingEnabled = true;
            txtBloodGroup.Items.AddRange(new object[] { "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" });
            txtBloodGroup.Location = new Point(570, 197);
            txtBloodGroup.Name = "txtBloodGroup";
            txtBloodGroup.Size = new Size(199, 28);
            txtBloodGroup.TabIndex = 22;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(570, 248);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(199, 27);
            txtCity.TabIndex = 24;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(570, 304);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(199, 137);
            txtAddress.TabIndex = 25;
            txtAddress.Text = "";
            // 
            // labelNewId
            // 
            labelNewId.Location = new Point(242, 94);
            labelNewId.Name = "labelNewId";
            labelNewId.Size = new Size(27, 27);
            labelNewId.TabIndex = 26;
            labelNewId.Text = "1";
            labelNewId.TextChanged += textBox7_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(570, 141);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(199, 27);
            txtEmail.TabIndex = 27;
            // 
            // btnSave
            // 
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(206, 545);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(71, 29);
            btnSave.TabIndex = 28;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnReset
            // 
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(436, 545);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 29);
            btnReset.TabIndex = 29;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.MiddleRight;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(637, 545);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(69, 29);
            btnClose.TabIndex = 30;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // addNewDonor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1006, 652);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(txtEmail);
            Controls.Add(labelNewId);
            Controls.Add(txtAddress);
            Controls.Add(txtCity);
            Controls.Add(txtBloodGroup);
            Controls.Add(txtGender);
            Controls.Add(txtDob);
            Controls.Add(txtMobile);
            Controls.Add(txtMother);
            Controls.Add(txtFather);
            Controls.Add(txtName);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addNewDonor";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addNewDonor";
            Load += addNewDonor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtName;
        private TextBox txtFather;
        private TextBox txtMother;
        private TextBox txtMobile;
        private DateTimePicker txtDob;
        private ComboBox txtGender;
        private ComboBox txtBloodGroup;
        private TextBox txtCity;
        private RichTextBox txtAddress;
        private TextBox labelNewId;
        private TextBox txtEmail;
        private Button btnSave;
        private Button btnReset;
        private Button btnClose;
    }
}