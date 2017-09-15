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
    public partial class signupform : Form
    {
        public signupform()
        {
            InitializeComponent();
        }

        private void signupform_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void birthtxt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void conformpasstxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            
            login f = new login();
            f.Show();
            this.Hide();
        }

        private void submit_btn_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=RAHUL;Initial Catalog=Webbrowser;Integrated Security=true";
            
            if (usernametxt.Text == "")
            {
                usernameerrorProvider.SetError(usernametxt, "User name is required");
            }
            else
            {
                usernameerrorProvider.Dispose();
            }

            if (password_txt.Text == "")
            {
                passerrorProvider.SetError(password_txt, "Password is required");
            }
            else
            {
                passerrorProvider.Dispose();
            }

            if (conformpasstxt.Text == "")
            {
                conpasserrorProvider.SetError(conformpasstxt, "Confirm password is required");
            }
            else
            {
                conpasserrorProvider.Dispose();
                if (password_txt.Text != conformpasstxt.Text)
                {
                    passequalerrorProvider.SetError(conformpasstxt, "Password not matched");
                }
                else
                {
                    passequalerrorProvider.Dispose();
                }
            }

            if(malerbtn.Checked==false && femalerbtn.Checked==false)
            {
                maleerrorProvider.SetError(groupBox2,"Gender is required");
            }
            else
            {
                maleerrorProvider.Dispose();
            }

            if (usernametxt.Text != "" && password_txt.Text != "" && conformpasstxt.Text != "")
            {
                if (password_txt.Text == conformpasstxt.Text)
                {
                    if (malerbtn.Checked == true)
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.Text;
                            SqlCommand cmd1 = new SqlCommand();
                            cmd1.Connection = con;
                            cmd1.CommandType = CommandType.Text;
                            cmd.CommandText = "Insert into signup values('" + usernametxt.Text + "','" + password_txt.Text + "','" + maskedTextBox1.Text + "','male')";
                            cmd1.CommandText = "Insert into login values('"+usernametxt.Text+"','"+password_txt.Text+"','0')";
                            int result = cmd.ExecuteNonQuery();
                            int result1 = cmd1.ExecuteNonQuery();

                            if (result >= 1)
                            {
                                MessageBox.Show("Acccount created successfully");

                            }
                            else
                            {
                                MessageBox.Show("Account is not created");
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
                    if (femalerbtn.Checked == true)
                    {
                        try
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand();
                            cmd.Connection = con;
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = "Insert into Signup values('" + usernametxt.Text + "','" + password_txt.Text + "','" + maskedTextBox1.Text + "','female')";
                            SqlCommand cmd1 = new SqlCommand();
                            cmd1.Connection = con;
                            cmd1.CommandType = CommandType.Text;
                            cmd1.CommandText = "Insert into login values('" + usernametxt.Text + "','" + password_txt.Text + "','0')";
                            int result = cmd.ExecuteNonQuery();
                            int result1 = cmd1.ExecuteNonQuery();



                            if (result >= 1)
                            {
                                MessageBox.Show("Acccount created successfully");

                            }
                            else
                            {
                                MessageBox.Show("Account is not created");
                            }

                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show("" + ex);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
