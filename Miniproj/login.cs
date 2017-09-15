using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;

namespace Miniproj
{
    public partial class login : Form
    {
        string ipadd = Dns.GetHostByName(Environment.MachineName).AddressList[0].ToString();
                
        public login()
        {
            InitializeComponent();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            signupform suf = new signupform();
            suf.Show();
            this.Hide();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            int role;
            if (usernametxt.Text == "" || passtxt.Text == "")
            {
                if (usernametxt.Text == "")
                {
                    usernameerror.SetError(usernametxt, "User name is required");
                }
                else
                {
                    usernameerror.Dispose();
                }

                if (passtxt.Text == "")
                {
                    passworderror.SetError(passtxt, "Password is required");
                }

                else
                {
                    passworderror.Dispose();
                }

            }


            if (usernametxt.Text != "" && passtxt.Text != "")
            {
                
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=RAHUL;Initial Catalog=Webbrowser;Integrated Security=true";
                DataTable dt = new DataTable();
               string date1=DateTime.Now.Date.ToString();
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand();
                    SqlCommand cmd2 = new SqlCommand();
                    
                    cmd.Connection = con;
                    cmd2.Connection = con;

                    cmd2.CommandType = CommandType.Text;
                    cmd.CommandType = CommandType.Text;

                    cmd2.CommandText="insert into log values('"+usernametxt.Text+"','"+ipadd+"','"+date1+"')";
                    cmd.CommandText = "select * from login where loginusername='"+usernametxt.Text+"' and loginpassword='"+this.passtxt.Text+"' ";

                    int result = cmd2.ExecuteNonQuery();
                    SqlDataReader dr = cmd.ExecuteReader();
                     //int count = 0;
                       if (dr.HasRows)
                       {
                           while (dr.Read())
                           {
                               role = (int)dr[2];
                               if (role == 0)
                               {
                                   WebBrowserfrm wbf = new WebBrowserfrm(usernametxt.Text);
                                   wbf.Show();
                                   this.Hide();
                               }
                               if (role == 1)
                               {
                                   Admin a = new Admin(usernametxt.Text);
                                   a.Show();
                                   this.Hide();
                               }



                           }
                       

                           
                        /*if (count == 1)
                        {

                            MessageBox.Show("username and password is correct");
                            usernameerror.Dispose();
                            passworderror.Dispose();
                            
                            dr.Close();
                            int result = cmd2.ExecuteNonQuery();
                            

                            

                            
                        }

                        else if (count > 1)
                        {

                            MessageBox.Show("Duplicate username and password");

                        }*/

                      /*  else
                        {

                            MessageBox.Show(" username and password incorrect");
                          
                            usernametxt.Clear();
                            passtxt.Clear();

                        }*/
                    }
                    else
                    {
                        MessageBox.Show("Invalid user.Login again");
                        usernameerror.Dispose();
                        passworderror.Dispose();

                        usernametxt.Clear();
                        passtxt.Clear();
                    
                    }



                }
                catch(Exception e3)
                {
                    MessageBox.Show(""+e3);
                }
                finally
                {
                    con.Close();
                }
               
            }

           
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            usernametxt.Clear();
            passtxt.Clear();
            usernameerror.Dispose();
            passworderror.Dispose();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Changepass ch = new Changepass();
            ch.Show();
            this.Hide();
        }
    }
}
