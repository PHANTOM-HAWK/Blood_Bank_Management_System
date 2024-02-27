namespace BloodBankManagementSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnShowHide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (btnShowHide.Text == "Show")
            {
                btnShowHide.Text = "Hide";
                textBoxPassword.PasswordChar = '\0';

            }
            else
            {
                btnShowHide.Text = "Show";
                textBoxPassword.PasswordChar = '*';
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "Abhi" && textBoxPassword.Text == "Abhi@2003")
            {
                dashBoard db = new dashBoard();
                db.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("ENTER VALID USERNAME AND PASSWORD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
