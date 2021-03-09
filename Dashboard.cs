using System;
using System.Collections;
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
        public static ArrayList cabs = new ArrayList();
        public static ArrayList inCabin = new ArrayList();
        
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
            Cabins cabin1 = new Cabins(1, "Suite", 1, false);
            Cabins cabin2 = new Cabins(2, "Suite", 2, false);
            Cabins cabin3 = new Cabins(3, "Double", 3, false);
            Cabins cabin4 = new Cabins(4, "Double", 4, false);
            Cabins cabin5 = new Cabins(5, "Single", 5, false);
            Cabins cabin6 = new Cabins(6, "Suite", 6, false);
            Cabins cabin7 = new Cabins(7, "Suite", 7, false);
            Cabins cabin8 = new Cabins(8, "Double", 8, false);
            Cabins cabin9 = new Cabins(9, "Double", 9, false);
            Cabins cabin10 = new Cabins(10, "Single", 10, false);
            cabs.Add(cabin1);
            cabs.Add(cabin2);
            cabs.Add(cabin3);
            cabs.Add(cabin4);
            cabs.Add(cabin5);
            cabs.Add(cabin6);
            cabs.Add(cabin7);
            cabs.Add(cabin8);
            cabs.Add(cabin9);
            cabs.Add(cabin10);
            updateCabin();
            getAvailability();         
            addClients();
        }       
        private void getAvailability()
        {
            int s = 0;
            int d = 0;
            int sin = 0;
            foreach (Cabins cab in cabs)
            {
                if(cab.Type == "Suite" && cab.Inuse == false)
                {
                    s++;
                }
                if (cab.Type == "Double" && cab.Inuse == false)
                {
                    d++;
                }
                if (cab.Type == "Single" && cab.Inuse == false)
                {
                    sin++;
                }
            }
            txtSuiteNo.Text += s.ToString();
            txtDoubleNo.Text += d.ToString();           
            txtSingleNo.Text += sin.ToString();
        }

        private void addClients()
        {
            foreach(CheckingIn c in inCabin)
            {
                dataClientsView.Rows.Add(c.Name, c.Surname, c.CheckIn, c.CheckOut, c.CabinType, c.CabinNumber, c.Notes);
            }
        }
        private void updateCabin()
        {
            CheckingIn client1 = new CheckingIn(256365, "Passport", "Dan", "Hayworth", "09-03-2021", "11-03-2021", "No notes", "Suite", 1);
            inCabin.Add(client1);
            cabs.RemoveAt(0) ;
            Cabins cabin1 = new Cabins(1, "Suite", 1, true);
            cabs.Add(cabin1);
            btnCab1.BackColor = Color.Red;
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            frmCheckIn frm = new frmCheckIn();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            
        }
    }
}
