using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Miniproj
{
    public partial class bookmark : Form
    {
        public bookmark()
        {
            InitializeComponent();
        }

        private void bookmark_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=RAHUL;Initial Catalog=Webbrowser;Integrated Security=true";
            DataTable dt=new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from bookmark";
                int result = cmd.ExecuteNonQuery();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
               
                }

            }
            catch
            {
            }
            finally
            {
                con.Close();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = "";
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=RAHUL;Initial Catalog=Webbrowser;Integrated Security=true";
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from bookmark";
              

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;

                }

            }
            catch
            {
            }
            finally
            {
                con.Close();
            }
        }
    }
}
