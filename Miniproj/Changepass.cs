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
    public partial class Changepass : Form
    {
        
        public Changepass()
        {
            InitializeComponent();
        }
     

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login l = new login();
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                if (textBox1.Text == "")
                {
                    errorProvider1.SetError(textBox1, "User name is required");
                }
                else
                {
                    errorProvider1.Dispose();
                }

                if (textBox2.Text == "")
                {
                    errorProvider2.SetError(textBox2, "Password is required");
                }

                else
                {
                    errorProvider2.Dispose();
                }

            }


            if (textBox1.Text != "" && textBox2.Text != "")
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=RAHUL;Initial Catalog=Webbrowser;Integrated Security=true";
                DataTable dt = new DataTable();
                string date1 = DateTime.Now.Date.ToString();
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from login where loginusername='" + textBox1.Text + "' and loginpassword='" + this.textBox2.Text + "' ";
                    SqlDataReader dr = cmd.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            MessageBox.Show("Password is correct");
                            Changepassnew chn = new Changepassnew(textBox2.Text,textBox1.Text);
                            chn.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid user.Login again");
                        errorProvider1.Dispose();
                        errorProvider2.Dispose();

                        
                        textBox2.Clear();
                    }
                }
                catch (Exception e3)
                {
                    MessageBox.Show("" + e3);
                }
                finally
                {
                    con.Close();
                }

            }

        }

        private void Changepass_Load(object sender, EventArgs e)
        {
            
        }
    }
}
