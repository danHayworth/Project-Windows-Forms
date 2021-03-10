using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project
{
    public partial class frmMain : Form
    {
        public static ArrayList cabs = new ArrayList();
        public static ArrayList inCabin = new ArrayList();
        public static List<Bookings> booked = new List<Bookings>();

        public frmMain()
        {
            InitializeComponent();
            lblLoggedUSer.Text = frmLogin.loggedUser;
                      
        }

        private void aFooter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developit.co.nz");
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
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
            
            if(cabs.Count.Equals(0))
            {
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
            }
            updateCabin();        
            addClients();
            addBookings();
        }       


        private void addClients()
        {
            bool alreadyIn = false;
            foreach (CheckingIn c in inCabin)
            {
                foreach (DataGridViewRow row in dataClientsView.Rows)
                {
                    object val1 = row.Cells[0].Value;
                    object val2 = row.Cells[1].Value;
                    if (val1 != null && val1.ToString() == c.Name.ToString() &&
                        val2 != null && val2.ToString() == c.Surname.ToString())
                    {
                        alreadyIn = true;
                    }
                }
                if (!alreadyIn)
                {
                    dataClientsView.Rows.Add(c.Name, c.Surname,c.Phone, c.CheckIn, c.CheckOut, c.CabinType, c.CabinNumber, c.Notes);
                }
            }
        }
        private void addBookings()
        {
            bool alreadyIn = false;
            foreach (Bookings b in booked)
            {
                foreach (DataGridViewRow row in dataGridBookings.Rows)
                {
                    object val1 = row.Cells[0].Value;
                    object val2 = row.Cells[1].Value;
                    if (val1 != null && val1.ToString() == b.Name.ToString() &&
                        val2 != null && val2.ToString() == b.Surname.ToString())
                    {
                        alreadyIn = true;
                    }
                }
                if (!alreadyIn)
                {
                    dataGridBookings.Rows.Add(b.Name, b.Surname, b.Phone, b.CheckIn, b.CheckOut, b.Notes);
                }
        
            }
        }
        private void updateCabin()
        {
            CheckingIn client1 = new CheckingIn("P256365", "Passport", "Dan", "Hayworth", 021322, "09-03-2021", "11-03-2021", "No notes", "Suite", 1);
            inCabin.Add(client1);  
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            frmCheckIn frm = new frmCheckIn();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();

        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            dataGridBookings.Visible = true;
            lblCurent.Text = "Bookings List";
            dataGridBookings.Update();
            dataGridBookings.Refresh();
        }

        private void btnCurentList_Click(object sender, EventArgs e)
        {
            dataGridBookings.Visible = false;
            lblCurent.Text = "Curent Guest List";
            dataClientsView.Refresh();
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            frmAddBooking f = new frmAddBooking();
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

    }
}
