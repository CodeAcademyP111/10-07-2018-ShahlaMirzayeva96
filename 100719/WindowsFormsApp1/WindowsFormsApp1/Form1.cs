using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LogInButton : Form
    {
        public LogInButton()
        {
            InitializeComponent();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passCheck.Checked)
            {
                passInput.UseSystemPasswordChar = false;
            }
            else
            {
                passInput.UseSystemPasswordChar = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "admin" && passInput.Text=="12345")
            {
                MessageBox.Show("Congratulations");
            }
            else if(txtInput.Text!="admin")
            {
                MessageBox.Show("Login is incorrect");
            }else if (passInput.Text != "12345")
            {
                MessageBox.Show("Password is incorrect");
            }
        }
    }
}
