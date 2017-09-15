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
                
    public partial class WebBrowserfrm : Form
    {
        SqlConnection con;
        string ipadd = Dns.GetHostByName(Environment.MachineName).AddressList[0].ToString();
        string date1 = DateTime.Now.Date.ToString();
        string user;
        String homepage=@"http://www.google.com";
        string newurlstring=@"http://";
        public WebBrowserfrm(string s)
        {
            user = s;
            InitializeComponent();
            ProgressBar1.Value = 0;
        }

        private void WebBrowserfrm_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            newurlstring += url_TextBox1.Text;
            ProgressBar1.Value = 0;
       
        }


        public void new_tab()
        {
            TabPage newtab = new TabPage();
           // newtab.BorderStyle = BorderStyle.Fixed3D;
            tabControl1.TabPages.Insert(tabControl1.TabCount - 1, newtab);
            WebBrowser browser = new WebBrowser();
            
           
            browser.Navigate(newurlstring+url_TextBox1.Text);
            newtab.Controls.Add(browser);

            browser.Dock = DockStyle.Fill;
            tabControl1.SelectTab(newtab);

           browser.ProgressChanged += new WebBrowserProgressChangedEventHandler(Form1_ProgressChanged);
           browser.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(Form1_DocumentCompleted);
            browser.Navigating += new WebBrowserNavigatingEventHandler(Form1_Navigating);
            timer1.Enabled = true;
           
        }
        private void Form1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser currentBrowser = getCurrentBrowser();
           // this.toolStripStatusLabel1.Text = "Done";
            String text = "Blank Page";

            if (!currentBrowser.Url.ToString().Equals("about:blank"))
            {
                text = currentBrowser.Url.Host.ToString();
            }

            this.url_TextBox1.Text = currentBrowser.Url.ToString();
            tabControl1.SelectedTab.Text = text;
            
            
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=RAHUL;Initial Catalog=Webbrowser;Integrated Security=true";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into history values('" +user+ "','" + text + "','"+date1+"','"+ipadd+"')";
                int result = cmd.ExecuteNonQuery();

               /* if (result >= 1)
                {
                    MessageBox.Show("Bookmared successfully");

                }
                else
                {
                    MessageBox.Show("Bookmark not created");
                }*/

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
            finally
            {
                con.Close();
            }


              
        }
        private void Form1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            
        }
        private void Form1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.url_TextBox1.Text = getCurrentBrowser().StatusText;

            
        }

        private WebBrowser getCurrentBrowser()
        {
            return (WebBrowser)tabControl1.SelectedTab.Controls[0];   
        }
       
        public WebBrowser getBrowser()
        {
            return (WebBrowser)tabControl1.SelectedTab.Controls[0];
        }

        private void tab_control(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == tabControl1.TabPages.Count - 1)
                new_tab();
            else
            {
            }


        }

        private void tnew_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            ProgressBar1.Value = 0;
           
            new_tab();
        }

        private void Back_toolStripButton1_Click(object sender, EventArgs e)
        {
            getBrowser().GoBack();
        }

        private void forword_toolStripButton1_Click(object sender, EventArgs e)
        {
            getBrowser().GoForward();
        }

        private void Search_toolStripButton1_Click(object sender, EventArgs e)
        {
            getBrowser().Navigate(newurlstring+url_TextBox1.Text);
            tabControl1.SelectedTab.Text = newurlstring+url_TextBox1.Text;
         //   tabControl1.SelectedTab.Text = getBrowser().Url.ToString().;
        }

        private void refresh_toolStripButton1_Click(object sender, EventArgs e)
        {
            getBrowser().Refresh();
        }

        private void newwindow_Click(object sender, EventArgs e)
        {
            WebBrowser we = new WebBrowser();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bookmark_toolStripButton1_Click(object sender, EventArgs e)
        {
        con = new SqlConnection();
            con.ConnectionString = @"Data Source=RAHUL;Initial Catalog=Webbrowser;Integrated Security=true";
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Insert into bookmark values('" + tabControl1.SelectedTab.Text + "','"+user+"')";
                int result = cmd.ExecuteNonQuery();

                if (result >= 1)
                {
                    MessageBox.Show("Bookmared successfully");

                }
                else
                {
                    MessageBox.Show("Bookmark not created");
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ProgressBar1.Value == 100)
            {
                ProgressBar1.Enabled = false;
             
                 }
            else 
            {
                ProgressBar1.Value = ProgressBar1.Value+25;
           
                
            }
        }

        private void ProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void bookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookmark bk = new bookmark();
            bk.Show();
            
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 v = new Form2();
            v.Show();

        }

       
      
    }
}
