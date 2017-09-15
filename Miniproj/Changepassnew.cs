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
    public partial class Changepassnew : Form
    {
        string cha;
        string cha1;
        public Changepassnew(string s,string s1)
        {   
            cha = s;
            cha1 = s1;
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox2.Clear();
            textBox3.Clear();

            errorProvider1.Dispose();
            errorProvider2.Dispose();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Changepass ch1 = new Changepass();
            ch1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con=new SqlConnection();
            con.ConnectionString = @"Data Source=RAHUL;Initial Catalog=Webbrowser;Integrated Security=true";

            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Password is required");
            }
            else
            {
                errorProvider1.Dispose();
            }

            if (textBox3.Text == "")
            {
                errorProvider2.SetError(textBox3, "Confirm password is required");
            }
            else
            {
                errorProvider2.Dispose();
                if (textBox2.Text != textBox3.Text)
                {
                    errorProvider3.SetError(textBox3, "Password not matched");
                }
                else
                {
                    errorProvider3.Dispose();
                }
            }
            if (textBox2.Text != "" && textBox3.Text != "")
            {

                if (textBox2.Text == textBox3.Text)
                {

                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "update login set loginpassword='" + textBox2.Text + "' where loginpassword='" + textBox1.Text + "' and loginusername='" + cha1 + "'";
                        int result = cmd.ExecuteNonQuery();
                        if (result >= 1)
                        {
                            MessageBox.Show("password changed");
                        }
                        else
                        {
                            MessageBox.Show("Password not changed");
                        }
                    }
                    catch (Exception ex2)
                    {
                        MessageBox.Show("" + ex2);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
        }

        private void Changepassnew_Load(object sender, EventArgs e)
        {
            textBox1.Text = cha;
            textBox1.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '*';
            textBox2.PasswordChar = '*';
            textBox3.PasswordChar = '*';
        }

      
    }
}
