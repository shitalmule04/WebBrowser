using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Miniproj
{
    public partial class Form1 : Form
    {
       

        private void label2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hello");

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            signupform suf = new signupform();
            suf.Show();
            this.Hide();
        }

        private void submitbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
