using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingSystem
{
    public partial class reset : Form
    {
        public reset()
        {
            InitializeComponent();
        }

        private void verify_Click(object sender, EventArgs e)
        {
            database d1 = new database();
            if(d1.verifyuser(uname.Text,cname.Text,mobno.Text))
            {
                reset1.Visible = false;
                reset2.Visible = true;
            }
            else
            {
                MessageBox.Show("Verification Failed");
            }
            
        }

        private void resetpass_Click(object sender, EventArgs e)
        {
            database d1 = new database();
            if(textBox3.Text==textBox4.Text)
            {
                d1.passwordreset(textBox3.Text,uname.Text);
                login r1 = new login();
                r1.Show();
                Visible = false;
            }
            else
            {
                MessageBox.Show("New password and conform password doesn't match");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                textBox3.UseSystemPasswordChar= false;
                textBox4.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
                textBox4.UseSystemPasswordChar = true;
            }
        }
    }
}
