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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void dispass_CheckedChanged(object sender, EventArgs e)
        {
            if(dispass.Checked)
            {
                pass.UseSystemPasswordChar = false;
            }
            else
            {
                pass.UseSystemPasswordChar= true;
            }
        }

        private void pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void reg_Click(object sender, EventArgs e)
        {
            database d1 = new database();
            String ncname, nuname, npass;
            string nmob;
            ncname = cname.Text;
            nmob = mobno.Text;
            nuname = uname.Text;
            npass = pass.Text;
            d1.reg(ncname,nmob,nuname,npass);
            login r1=new login();
            r1.Show();
            Visible = false;
            
            
        }

        private void uname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
