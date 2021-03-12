﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Project
{
    public partial class frmMain : Form
    {
        public static List<Cabins> cabs = new List<Cabins>();
        public static List<CheckingIn> inCabin = new List<CheckingIn>();
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
            addClients();
            addBookings();
            changeColours();
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
                    if (val1 != null && val1.ToString() == c.Name.ToString() && val2 != null && val2.ToString() == c.Surname.ToString())
                    {
                        alreadyIn = true;
                        MessageBox.Show("Guest already in cabin");
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
                        MessageBox.Show("Guest already booked");
                    }
                }
                if (!alreadyIn)
                {
                    dataGridBookings.Rows.Add(b.Name, b.Surname, b.Phone, b.CheckIn, b.CheckOut, b.Notes);
                }
        
            }
        }
        

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            this.Close();
            frmCheckIn frm = new frmCheckIn();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            dataGridBookings.Visible = true;
            dataClientsView.Visible = false;
            lblCurent.Text = "Bookings List";
            dataGridBookings.Update();
            dataGridBookings.Refresh();
        }

        private void btnCurentList_Click(object sender, EventArgs e)
        {
            dataGridBookings.Visible = false;
            dataClientsView.Visible = true;
            lblCurent.Text = "Curent Guest List";
            dataClientsView.Update();
            dataClientsView.Refresh();
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAddBooking f = new frmAddBooking();
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        private void changeColours()
        {
            foreach (CheckingIn c in inCabin)
            {
                int val = c.CabinNumber;
                if (val == 1)
                {
                    btnCab1.BackColor = Color.Red;
                }
                if (val == 2)
                {
                    btnCab2.BackColor = Color.Red;
                }
                if (val == 3)
                {
                    btnCab3.BackColor = Color.Red;
                }
                if (val == 4)
                {
                    btnCab4.BackColor = Color.Red;
                }
                if (val == 5)
                {
                    btnCab5.BackColor = Color.Red;
                }
                if (val == 6)
                {
                    btnCab6.BackColor = Color.Red;
                }
                if (val == 7)
                {
                    btnCab7.BackColor = Color.Red;
                }
                if (val == 8)
                {
                    btnCab8.BackColor = Color.Red;
                }
                if (val == 9)
                {
                    btnCab9.BackColor = Color.Red;
                }
                if (val == 10)
                {
                    btnCab10.BackColor = Color.Red;
                }

            }
        }

        public static string NameClient;
        public static string Surname;
        public static string CheckIn;
        public static string CheckOut;
        public static int PhoneNumber;
        public static int CabinNumber;
        public static string CabinType;

        private void getCabinDetails()
        {
            foreach(CheckingIn c in inCabin)
            {
                if(CabinNumber == c.CabinNumber)
                {
                    NameClient = c.Name;
                    Surname = c.Surname;
                    CheckIn = c.CheckIn;
                    CheckOut = c.CheckOut;
                    PhoneNumber = c.Phone;
                    CabinType = c.CabinType;
                }
            }
        }

        private void btnCab1_Click(object sender, EventArgs e)
        {
            
            CabinNumber = 1;
            generateCabin();
        }

        private void btnCab2_Click(object sender, EventArgs e)
        {
            CabinNumber = 2;
            generateCabin();
        }

        private void btnCab6_Click(object sender, EventArgs e)
        {
           
            CabinNumber = 6;
            generateCabin();
        }

        private void btnCab7_Click(object sender, EventArgs e)
        {
          
            CabinNumber = 7;
            generateCabin();
            
        }

        private void btnCab3_Click(object sender, EventArgs e)
        {
          
            CabinNumber = 3;
            generateCabin();
            
        }

        private void btnCab4_Click(object sender, EventArgs e)
        {
   
            CabinNumber = 4;
            generateCabin();
           
        }

        private void btnCab8_Click(object sender, EventArgs e)
        {
        
            CabinNumber = 8;
            generateCabin();
             
        }

        private void btnCab9_Click(object sender, EventArgs e)
        {
           
            CabinNumber = 9;
            generateCabin();
              
        }

        private void btnCab5_Click(object sender, EventArgs e)
        {
           
            CabinNumber = 5;
            generateCabin();
               
        }

        private void btnCab10_Click(object sender, EventArgs e)
        {          
            CabinNumber = 10;
            generateCabin();     
           
        }

       
        private void generateCabin()
        {
            bool empty = true;
            foreach(CheckingIn c in inCabin)
            {
                if(CabinNumber == c.CabinNumber)
                {
                    empty = false;
                    getCabinDetails();
                    frmCabinsCheck f = new frmCabinsCheck();
                    f.Show();
                    this.Close();
                }
            }
            if (empty)
            {
                MessageBox.Show("This cabin is empty!");
            }

        }
    }
}
