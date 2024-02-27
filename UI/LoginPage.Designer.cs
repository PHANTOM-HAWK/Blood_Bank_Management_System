namespace BloodBankManagementSystem
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            btnShowHide = new LinkLabel();
            buttonLogin = new Button();
            textBoxPassword = new TextBox();
            label2 = new Label();
            textBoxUserName = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            buttonClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnShowHide);
            panel1.Controls.Add(buttonLogin);
            panel1.Controls.Add(textBoxPassword);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBoxUserName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(312, 396);
            panel1.TabIndex = 0;
            // 
            // btnShowHide
            // 
            btnShowHide.AutoSize = true;
            btnShowHide.Location = new Point(198, 261);
            btnShowHide.Name = "btnShowHide";
            btnShowHide.Size = new Size(45, 20);
            btnShowHide.TabIndex = 6;
            btnShowHide.TabStop = true;
            btnShowHide.Text = "Show";
            btnShowHide.LinkClicked += btnShowHide_LinkClicked;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(117, 333);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(90, 34);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 10.2F);
            textBoxPassword.Location = new Point(24, 284);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(219, 30);
            textBoxPassword.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 261);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // textBoxUserName
            // 
            textBoxUserName.Font = new Font("Segoe UI", 10.2F);
            textBoxUserName.Location = new Point(24, 219);
            textBoxUserName.Name = "textBoxUserName";
            textBoxUserName.Size = new Size(219, 30);
            textBoxUserName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 196);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 1;
            label1.Text = "User Name";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 181);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonClose
            // 
            buttonClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonClose.BackColor = Color.Red;
            buttonClose.Location = new Point(1028, 2);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(38, 29);
            buttonClose.TabIndex = 1;
            buttonClose.Text = "X";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1069, 594);
            Controls.Add(buttonClose);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBoxUserName;
        private Label label1;
        private Button buttonLogin;
        private TextBox textBoxPassword;
        private LinkLabel btnShowHide;
        private Button buttonClose;
    }
}
