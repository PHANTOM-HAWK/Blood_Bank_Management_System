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
    public partial class DeleteDonorDetails : Form
    {
        String query;
        function fn = new function();
        public DeleteDonorDetails()
        {
            InitializeComponent();
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtDonorId.Text != "")
            {
                query = " DELETE FROM newDonor WHERE did = " + txtDonorId.Text + "";
                fn.setData(query);
                txtDonorId.Text = "";
                txtDonorId_TextChanged(this, null);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void DeleteDonorDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
