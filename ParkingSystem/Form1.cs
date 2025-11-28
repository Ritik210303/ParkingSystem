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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login l1=new login();
            l1.Show();

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            register r1 = new register();
            r1.Show();
            
            //Visible = false;
        }

        private void home1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {
            database d = new database();
            d.assign();
            //enduser ed = new enduser();
            //ed.Show();
            d.advance_assign();
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            location l=new location();
            l.Visible = true;
        }

        private void feedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            feedback f = new feedback();
            f.Visible = true;
        }
    }
}
