using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem
{
    public partial class addNewDonor : Form
    {
        function fn = new function();
        public addNewDonor()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void addNewDonor_Load(object sender, EventArgs e)
        {
            string query = "SELECT MAX(did) FROM newDonor";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count > 0 && ds.Tables[0].Rows[0][0] != DBNull.Value)
            {
                int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelNewId.Text = (count + 1).ToString();
            }
            else
            {
                // Handle the case when the table has zero rows (e.g., set a default value).
                labelNewId.Text = "1"; // You can adjust this as needed.
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text != "" && txtBloodGroup.Text != "" && txtCity.Text != "" && txtDob.Text != "" && txtEmail.Text != "" && txtFather.Text != "" && txtGender.Text != "" && txtMobile.Text != "" && txtMother.Text != "" && txtName.Text != "")
            {
                string dname = txtName.Text;
                string fname = txtFather.Text;
                string mname = txtMother.Text;
                string dob = txtDob.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                string gender = txtGender.Text;
                string email = txtEmail.Text;
                string bgroup = txtBloodGroup.Text;
                string city = txtCity.Text;
                string address = txtAddress.Text;
                string query = "insert into newDonor(dname,fname,mname,dob,mobile,gender,email,bloodgroup,city,daddress) values('" + dname + "','" + fname + "','" + mname + "','" + dob + "'," + mobile + ",'" + gender + "','" + email + "','" + bgroup + "','" + city + "','" + address + "')";
                fn.setData(query);
            }
            else
            {
                MessageBox.Show("FILL ALL FIELDS.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAddress.Clear();

            txtBloodGroup.ResetText();
            txtGender.ResetText();
            txtEmail.Clear();
            txtCity.Clear();
            txtDob.ResetText();
            txtFather.Clear();
            txtMother.Clear();
            txtName.Clear();
            txtMobile.Clear();




        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
