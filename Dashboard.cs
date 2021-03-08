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

namespace Project
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void aFooter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developit.co.nz");
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        private void timer_tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            timer1.Start();
            getAvailability();

        }
        
        private void getAvailability()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\danha\source\repos\Project\ProjectDatabase.mdf;Integrated Security=True");
            con.Open();
            SqlCommand cmd;
            SqlDataReader dr;
            string suite = "Select type, inuse from Cabins where type ='suite' and inuse = 'false'";
            cmd = new SqlCommand(suite, con);
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    i++;
                }
                txtSuiteNo.Text = i.ToString();
            }
            else
            {
                txtSuiteNo.Text= "0";
            }
            dr.Close();
            string doub = "Select type, inuse from Cabins where type ='double' and inuse = 'false'";
            cmd = new SqlCommand(doub, con);
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    i++;
                }
                txtDoubleNo.Text = i.ToString();
            }
            else
            {
                txtDoubleNo.Text = "0";
            }
            dr.Close();
            string sing = "Select type, inuse from Cabins where type ='single' and inuse = 'false'";
            cmd = new SqlCommand(sing, con);
            dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                int i = 0;
                while (dr.Read())
                {
                    i++;
                }
                txtSingleNo.Text = i.ToString();
            }
            else
            {
                txtSingleNo.Text = "0";
            }
            dr.Close();
        }

    }
}
