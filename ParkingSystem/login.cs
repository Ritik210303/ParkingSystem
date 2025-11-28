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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkboxpass_CheckedChanged(object sender, EventArgs e)
        {
            if(checkboxpass.Checked)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar= true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset r1 = new reset();
            r1.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(uname.Text=="admin" && pass.Text=="admin")
            {
                dashboard r1 =new dashboard();
                r1.Show();
                Visible=false;
            }
            else
            {
                database d1 = new database();
                if(d1.authenticateuser(uname.Text,pass.Text))
                {
                    enduser r1 = new enduser();
                    database d = new database();
                    
                   // MessageBox.Show("0 slot is: " + d.carslot[0]);
                    r1.Show();
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorrect username or password");
                }
                
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
