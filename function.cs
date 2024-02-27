﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace BloodBankManagementSystem
{
    internal class function
    {
        public SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=ABHISHEK\\SQLEXPRESS;database=bloodbank;integrated security=True";
            return con;
        }
        public DataSet getData(string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText= query; 
            SqlDataAdapter da= new SqlDataAdapter(cmd);    
            DataSet ds= new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(string query)
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("DATA PROCESSING SUCCESSFUL!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
