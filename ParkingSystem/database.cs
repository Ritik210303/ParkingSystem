using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Data;

namespace ParkingSystem
{
    internal class database
    {
        string username;
        string password;
        static int cslot=2;
        static int bslot=2;
        static string[] carslot = new string[cslot];
        static string[] bikeslot = new string[bslot];
        //int tloc;
        string connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""M:\BSC-IT\sem 5\ADFC\case study\CusotmerDetails.mdf"";Integrated Security=True;Connect Timeout=30";
        public void reg(string ncname,string nmob,string nuname,string npass) 
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand($"insert into custdetails(cname,mob,uname,pass) values('{ncname}','{nmob}','{nuname}','{npass}')",con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Account created");
        }

        public bool authenticateuser(string nuname,string npass)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand($"select count(*) from custdetails where uname='{nuname}' and pass='{npass}' ",con);
            int result = (int) cmd.ExecuteScalar();
            con.Close();
            if(result==1)
            {
                username = nuname;
                password = npass;
            }
            //MessageBox.Show("Uname and pass is: "+username+password);
            return result > 0;
        }
        public bool verifyuser(string nuname,string ncname,string nmob)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand($"select count(*) from custdetails where uname='{nuname}' and cname='{ncname}' and mob='{nmob}'",con);
            int result= (int) cmd.ExecuteScalar();
            con.Close();
            if (result == 1)
            {
                username = nuname;
            }
            return result > 0;
        }
        public void passwordreset(string npass,string nuname)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            //MessageBox.Show("username: "+nuname);
            SqlCommand cmd = new SqlCommand($"update custdetails set pass='{npass}' where uname='{nuname}'",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Password reset successful");
            con.Close();
        }

        public void assign()
        {
            int i = 0;
           // MessageBox.Show("assign function");
            for(i=0;i<cslot;i++)
            {
                carslot[i] = "free";

            }
            for(i=0;i<bslot;i++)
            {
                bikeslot[i] = "free";
            }
            //MessageBox.Show("0 slot is: " + carslot[0]);
        }
        public void advance_assign()
        {
            int i = 0;
            int j = 0;
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand($"select vcategory,location from vehical",con);
            SqlDataReader reader = cmd.ExecuteReader(); 
            while(reader.Read())
            {
               // int.Parse(reader.GetString(0).ToString())
                if (reader.GetString(0).ToString() == "Car")
                {
                    if(int.Parse(reader.GetString(1).ToString())==i)
                    {
                        carslot[i] = "parked";
                    }
                }
                if (reader.GetString(0).ToString() == "Bike")
                {
                    if (int.Parse(reader.GetString(1).ToString()) == j)
                    {
                        bikeslot[i] = "parked";
                    }
                }
                i++;
                j++;

            }
        }
        public string park(string vn, string vt, DateTime ptime)
        {
            DateTime dateAndTime = DateTime.Now;

            int f = 0;
            // Convert the date and time to a format that is compatible with the database.
            var sqlDateTime = ptime.ToString("yyyy-MM-dd HH:mm:ss");
            //MessageBox.Show(sqlDateTime);

            // carslot[0] = "parked";
            // MessageBox.Show("0 slot is: " + carslot[0]);
            //var test = ptime.ToString("yyyy-MM-dd HH:mm:ss");
            string loc=null;
            int i=0;
            if(vt=="Car")
            {
                for (i = 0; i < cslot; i++)
                {
                    //MessageBox.Show("hii " + i);
                    if (carslot[i] != "parked")
                    {
                        carslot[i] = "parked";
                        loc = i.ToString();
                        MessageBox.Show("Parking location is: C" + loc);
                        break;
                    }
                    else if(i==cslot-1)
                    {
                        MessageBox.Show("Parking is Full");
                        f = 1;
                    }
                }
            }
            else if(vt=="Bike")
            {
                for (i = 0; i < bslot; i++)
                {
                    if (bikeslot[i] != "parked")
                    {
                        bikeslot[i] = "parked";
                        loc=i.ToString();
                        MessageBox.Show("Parking location is: B" + loc);
                        break;
                    }
                    else if (i == cslot - 1)
                    {
                        MessageBox.Show("Parking is Full");
                        f = 1;
                    }
                }
            }
            // string.Compare(carslot[i], "parked");
            if (f == 0)
            {
                SqlConnection con = new SqlConnection(connectionstring);
                con.Open();
                string sql = "INSERT INTO vehical (vnumber,vcategory,parktime,location) VALUES (@vn,@vt,@sqlDateTime,@loc)";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@vn", vn);
                    command.Parameters.AddWithValue("@vt", vt);
                    command.Parameters.AddWithValue("@sqlDateTime", sqlDateTime);
                    command.Parameters.AddWithValue("@loc", loc);
                    command.ExecuteNonQuery();
                }
                // SqlCommand cmd = new SqlCommand($"insert into vehical(vnumber,vcategory,parktime,location) values('{vn}','{vt}','{sqlDateTime}','{loc}')" , con);
                //cmd.ExecuteNonQuery();
                con.Close();
            }
            return loc;
        }
        public double depart(string vno)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand($"select vcategory,parktime,location from vehical where vnumber='{vno}'", con);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            string vc = dt.Rows[0][0].ToString();
            string tpt = dt.Rows[0][1].ToString();
            string loc = dt.Rows[0][2].ToString();
            //  MessageBox.Show(tmep1);
            DateTime pt = DateTime.Parse(tpt);
            DateTime dept = DateTime.Now;
            TimeSpan parktime = dept - pt;
            int mintime= (int)parktime.TotalMinutes;
            //  MessageBox.Show("Parking time is: "+mintime);
            double amount=0;
            // MessageBox.Show("Parking location is: " + loc);
            // MessageBox.Show("Parking charge is: " + amount);
            int l = int.Parse(loc);
            if(vc=="Car")
            {
                carslot[l] = "free";
                amount = mintime * 0.75;
            }
            else if(vc=="Bike")
            {
                bikeslot[l] = "free";
                amount = mintime * 0.5;
            }    
            return amount;
        }

        public string location(string vno)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand($"select location from vehical where vnumber='{vno}'", con);
            string loc =(string) cmd.ExecuteScalar();
            cmd = new SqlCommand($"select vcategory from vehical where vnumber='{vno}'", con);
            string vc = (string)cmd.ExecuteScalar();
            string tloc;
            if(vc=="Car")
            {
                tloc = "c" +loc;
            }
            else
            {
                tloc = "b" + loc;
            }
            return tloc;
        }
        public void delete(string vno)
        {
            //MessageBox.Show("deleted");
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand($"delete vehical where vnumber='{vno}'",con); 
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void feed(string n,string e,string c)
        {
            MessageBox.Show("Feedback submitted successfully");
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand($"insert into feedback(uname,email,comment) values('{n}','{e}','{c}')", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void history(string vno)
        {
            SqlConnection con = new SqlConnection(connectionstring);
            con.Open();
            SqlCommand cmd = new SqlCommand($"select id,vcategory,parktime,location from vehical where vnumber='{vno}'", con);
            DataTable dt= new DataTable();
            dt.Load(cmd.ExecuteReader());
            string id, vcat, ptime, loc;
            string dtime = DateTime.Now.ToString();
            id = dt.Rows[0][0].ToString();
            vcat= dt.Rows[0][1].ToString();
            ptime = dt.Rows[0][2].ToString();
            loc = dt.Rows[0][3].ToString();
            cmd = new SqlCommand($"insert into ParkingHistory values('{id}','{vno}','{vcat}','{ptime}','{dtime}','{loc}')",con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

}
