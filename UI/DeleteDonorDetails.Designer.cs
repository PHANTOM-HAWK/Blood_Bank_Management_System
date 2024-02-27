namespace BloodBankManagementSystem
{
    partial class DeleteDonorDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeleteDonorDetails));
            btnSearch = new Button();
            txtDonorId = new TextBox();
            label2 = new Label();
            btnClose = new Button();
            btnReset = new Button();
            btnDelete = new Button();
            txtEmail = new TextBox();
            txtAddress = new RichTextBox();
            txtCity = new TextBox();
            txtBloodGroup = new ComboBox();
            txtGender = new ComboBox();
            txtDob = new DateTimePicker();
            txtMobile = new TextBox();
            txtMother = new TextBox();
            txtFather = new TextBox();
            txtName = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(577, 106);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 29);
            btnSearch.TabIndex = 83;
            btnSearch.Text = "Search";
            btnSearch.TextAlign = ContentAlignment.MiddleRight;
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtDonorId
            // 
            txtDonorId.Location = new Point(372, 106);
            txtDonorId.Name = "txtDonorId";
            txtDonorId.Size = new Size(199, 27);
            txtDonorId.TabIndex = 82;
            txtDonorId.TextChanged += txtDonorId_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label2.Location = new Point(284, 107);
            label2.Name = "label2";
            label2.Size = new Size(82, 23);
            label2.TabIndex = 81;
            label2.Text = "Donor Id:";
            // 
            // btnClose
            // 
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(688, 535);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(69, 29);
            btnClose.TabIndex = 80;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnReset
            // 
            btnReset.Image = (Image)resources.GetObject("btnReset.Image");
            btnReset.ImageAlign = ContentAlignment.MiddleLeft;
            btnReset.Location = new Point(487, 535);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 29);
            btnReset.TabIndex = 79;
            btnReset.Text = "Reset";
            btnReset.TextAlign = ContentAlignment.MiddleRight;
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(257, 535);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 29);
            btnDelete.TabIndex = 78;
            btnDelete.Text = "Delete";
            btnDelete.TextAlign = ContentAlignment.MiddleRight;
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(621, 176);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(199, 27);
            txtEmail.TabIndex = 77;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(621, 339);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(199, 137);
            txtAddress.TabIndex = 76;
            txtAddress.Text = "";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(621, 283);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(199, 27);
            txtCity.TabIndex = 75;
            // 
            // txtBloodGroup
            // 
            txtBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            txtBloodGroup.FormattingEnabled = true;
            txtBloodGroup.Items.AddRange(new object[] { "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" });
            txtBloodGroup.Location = new Point(621, 232);
            txtBloodGroup.Name = "txtBloodGroup";
            txtBloodGroup.Size = new Size(199, 28);
            txtBloodGroup.TabIndex = 74;
            // 
            // txtGender
            // 
            txtGender.DropDownStyle = ComboBoxStyle.DropDownList;
            txtGender.FormattingEnabled = true;
            txtGender.Items.AddRange(new object[] { "Male", "Female" });
            txtGender.Location = new Point(283, 435);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(199, 28);
            txtGender.TabIndex = 73;
            // 
            // txtDob
            // 
            txtDob.Location = new Point(283, 340);
            txtDob.Name = "txtDob";
            txtDob.Size = new Size(199, 27);
            txtDob.TabIndex = 72;
            // 
            // txtMobile
            // 
            txtMobile.Location = new Point(283, 389);
            txtMobile.Name = "txtMobile";
            txtMobile.Size = new Size(199, 27);
            txtMobile.TabIndex = 71;
            // 
            // txtMother
            // 
            txtMother.Location = new Point(283, 287);
            txtMother.Name = "txtMother";
            txtMother.Size = new Size(199, 27);
            txtMother.TabIndex = 70;
            // 
            // txtFather
            // 
            txtFather.Location = new Point(283, 228);
            txtFather.Name = "txtFather";
            txtFather.Size = new Size(199, 27);
            txtFather.TabIndex = 69;
            // 
            // txtName
            // 
            txtName.Location = new Point(283, 180);
            txtName.Name = "txtName";
            txtName.Size = new Size(199, 27);
            txtName.TabIndex = 68;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label12.Location = new Point(169, 180);
            label12.Name = "label12";
            label12.Size = new Size(56, 23);
            label12.TabIndex = 67;
            label12.Text = "Name";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label11.Location = new Point(169, 389);
            label11.Name = "label11";
            label11.Size = new Size(63, 23);
            label11.TabIndex = 66;
            label11.Text = "Mobile";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label10.Location = new Point(169, 436);
            label10.Name = "label10";
            label10.Size = new Size(66, 23);
            label10.TabIndex = 65;
            label10.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label9.Location = new Point(511, 340);
            label9.Name = "label9";
            label9.Size = new Size(70, 23);
            label9.TabIndex = 64;
            label9.Text = "Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label8.Location = new Point(511, 232);
            label8.Name = "label8";
            label8.Size = new Size(107, 23);
            label8.TabIndex = 63;
            label8.Text = "Blood Group";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label7.Location = new Point(511, 287);
            label7.Name = "label7";
            label7.Size = new Size(40, 23);
            label7.TabIndex = 62;
            label7.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label6.Location = new Point(169, 287);
            label6.Name = "label6";
            label6.Size = new Size(118, 23);
            label6.TabIndex = 61;
            label6.Text = "Mother Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label5.Location = new Point(511, 180);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 60;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label4.Location = new Point(169, 340);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 59;
            label4.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            label3.Location = new Point(169, 232);
            label3.Name = "label3";
            label3.Size = new Size(109, 23);
            label3.TabIndex = 58;
            label3.Text = "Father Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(272, 37);
            label1.Name = "label1";
            label1.Size = new Size(412, 46);
            label1.TabIndex = 57;
            label1.Text = "DELETE DONOR DETAILS";
            // 
            // DeleteDonorDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(988, 605);
            Controls.Add(btnSearch);
            Controls.Add(txtDonorId);
            Controls.Add(label2);
            Controls.Add(btnClose);
            Controls.Add(btnReset);
            Controls.Add(btnDelete);
            Controls.Add(txtEmail);
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
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DeleteDonorDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DeleteDonorDetails";
            Load += DeleteDonorDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtDonorId;
        private Label label2;
        private Button btnClose;
        private Button btnReset;
        private Button btnDelete;
        private TextBox txtEmail;
        private RichTextBox txtAddress;
        private TextBox txtCity;
        private ComboBox txtBloodGroup;
        private ComboBox txtGender;
        private DateTimePicker txtDob;
        private TextBox txtMobile;
        private TextBox txtMother;
        private TextBox txtFather;
        private TextBox txtName;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
    }
}