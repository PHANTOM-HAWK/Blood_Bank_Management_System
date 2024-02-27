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
    public partial class SearchBloodDonorBloodGroup : Form
    {
        function fn = new function();
        String query;
        public SearchBloodDonorBloodGroup()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBloodGroup_TextChanged(object sender, EventArgs e)
        {
            if(txtBloodGroup.Text != "")
            {
                query = "select * from newDonor where bloodgroup like '" + txtBloodGroup.Text + "%'";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                query = "select * from newDonor";
                DataSet ds = fn.getData(query);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void SearchBloodDonorBloodGroup_Load(object sender, EventArgs e)
        {
            query = "select * from newDonor";
            DataSet ds=fn.getData(query); 
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
