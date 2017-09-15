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
    public partial class Admin : Form
    {
        string user;
        public Admin(string s)
        {
            user = s;
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            WebBrowserfrm bt = new WebBrowserfrm(user);
            bt.Show();
            this.Hide();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=RAHUL;Initial Catalog=Webbrowser;Integrated Security=true";
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from log where logusername like '" + textBox1.Text + "%' ";
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dt.Load(dr);
                    dataGridView1.DataSource = dt;
                    if (textBox1.Text == "")
                    {
                        dataGridView1.DataSource = "";
                    }
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=RAHUL;Initial Catalog=Webbrowser;Integrated Security=true";
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from history where hurl like '%" + textBox2.Text + "%' ";
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dt.Load(dr);
                    dataGridView3.DataSource = dt;
                    if (textBox2.Text == "")
                    {
                        dataGridView3.DataSource = "";
                    }
                }
                dr.Close();

            }
            catch
            {
            }
            finally
            {
                
                con.Close();
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=RAHUL;Initial Catalog=Webbrowser;Integrated Security=true";
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from log where logdate like '" + textBox3.Text + "%' ";
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dt.Load(dr);
                    dataGridView2.DataSource = dt;
                    if (textBox3.Text == "")
                    {
                        dataGridView2.DataSource = "";
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(""+ex);
            }
            finally
            {
                con.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
