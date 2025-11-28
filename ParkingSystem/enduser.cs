using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ParkingSystem
{
    public partial class enduser : Form
    {
        
        public enduser()
        {
            InitializeComponent();
        }

        private void enter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Enter button
            //enter.Visible = false;
            // panel1.Visible = true;
            depart.Visible = true;
            enter.Visible = false;
            
        }

        private void sumbit_Click(object sender, EventArgs e)
        {
            
        }

        private void sumbit_Click_1(object sender, EventArgs e)
        {
            database d1 = new database();
            string vno = combo.Text;
            string loc= d1.location(vno);
            double num=d1.depart(vno);
            d1.history(vno);
            d1.delete(vno);
            combo.Items.Clear();
            cc();
            textBox3.Text = num.ToString();
            textBox4.Text = loc;

            bill.Visible = true;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //enter button
            //MessageBox.Show("Time is: "+time.Text);
            string vno, vt;
            string loc;
            DateTime ptime;
            vno = vnumber.Text;
            vt = vtype.Text;
            ptime = time.Value;
           // MessageBox.Show("Time is: " + ptime);
            database d1 = new database();
            loc =d1.park(vno, vt, ptime);
            //MessageBox.Show("done");
            combo.Items.Clear();
            cc();
            //if(vt=="Car")
            //{
            //    if(loc==c0.Text)
            //    {
            //        c0.BackColor= Color.Red;
            //    }
            //    else if(loc==c1.Text);
            //    {
            //        c1.BackColor=Color.Red;
            //    }
            //}
        }

        private void enduser_Load(object sender, EventArgs e)
        {
            combo.Items.Clear();
            cc();
        }
        private void cc()
        {
            string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""M:\BSC-IT\sem 5\ADFC\case study\CusotmerDetails.mdf"";Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(connectionstring);
            
            SqlCommand cmd = new SqlCommand($"select * from vehical",con);
            SqlDataReader myreader;
            try
            {
                con.Open();
                myreader = cmd.ExecuteReader();
                while(myreader.Read())
                {
                    string vno = myreader.GetString(1);
                    combo.Items.Add(vno);
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            depart.Visible = false;
            enter.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
