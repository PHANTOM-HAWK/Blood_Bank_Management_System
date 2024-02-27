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

    public partial class UpdateDonorDetails : Form
    {
        function fn = new function();
        public UpdateDonorDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Int64 id = Int64.Parse(txtDonorId.Text.ToString());
                String query = "select * from newDonor where did=" + id + "";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    // ID does not exist in the database
                    MessageBox.Show("Please enter a valid ID.", "ID Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    txtName.Text = ds.Tables[0].Rows[0]["dname"].ToString();
                    txtFather.Text = ds.Tables[0].Rows[0]["fname"].ToString();
                    txtMother.Text = ds.Tables[0].Rows[0]["mname"].ToString();
                    txtDob.Text = ds.Tables[0].Rows[0]["dob"].ToString();
                    txtMobile.Text = ds.Tables[0].Rows[0]["mobile"].ToString();
                    txtGender.Text = ds.Tables[0].Rows[0]["gender"].ToString();
                    txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                    txtBloodGroup.Text = ds.Tables[0].Rows[0]["bloodgroup"].ToString();
                    txtCity.Text = ds.Tables[0].Rows[0]["city"].ToString();
                    txtAddress.Text = ds.Tables[0].Rows[0]["daddress"].ToString();


                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid numeric ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtAddress.Text != "" && txtBloodGroup.Text != "" && txtCity.Text != "" && txtDob.Text != "" && txtEmail.Text != "" && txtFather.Text != "" && txtGender.Text != "" && txtMobile.Text != "" && txtMother.Text != "" && txtName.Text != "")
            {
                Int64 id = Int64.Parse(txtDonorId.Text); // Assuming txtDonorId contains the donor ID
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

                string query = $"UPDATE newDonor SET dname = '{dname}', fname = '{fname}', mname = '{mname}', dob = '{dob}', mobile = {mobile}, gender = '{gender}', email = '{email}', bloodgroup = '{bgroup}', city = '{city}', daddress = '{address}' WHERE did = {id}";

                fn.setData(query);
                UpdateDonorDetails_Load(this, null);
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDonorId_TextChanged(object sender, EventArgs e)
        {
            if (txtDonorId.Text == "")
            {
                txtName.Clear();
                txtFather.Clear();
                txtMobile.Clear();
                txtMother.Clear();
                txtDob.ResetText();
                txtGender.ResetText();
                txtEmail.Clear();
                txtCity.Clear();
                txtAddress.Clear();

            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFather.Clear();
            txtMobile.Clear();
            txtMother.Clear();
            txtDob.ResetText();
            txtGender.ResetText();
            txtEmail.Clear();
            txtCity.Clear();
            txtAddress.Clear();
        }

        private void UpdateDonorDetails_Load(object sender, EventArgs e)
        {
            txtDonorId.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
