using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project
{
    public partial class frmMain : Form
    {
        /* Student Id: 92060016
         * Name: Dan Hayworth
         * Date: 15-03-2021
         */
        // creating lists based on class model
        public static List<Cabins> cabs = new List<Cabins>();
        public static List<CheckingIn> inCabin = new List<CheckingIn>();
        public static List<Bookings> booked = new List<Bookings>();

        public frmMain()
        {
            InitializeComponent();
            //adding the logged user to the top of screen
            lblLoggedUSer.Text = frmLogin.loggedUser;
                      
        }

        // adding an event for the link label in the footer
        private void aFooter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://developit.co.nz");
        }

        //close the application
        private void imgClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    
        // creating an event for clock 
        private void timer_tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        // add events to form loading
        private void frmMain_Load(object sender, EventArgs e)
        { 
            //start timer
            timer1.Start(); 
            // add manually the cabins
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
            //check if there are cabins already in the list
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
            // add existing clients to the current guests datagridview
            addClients();
            //add existing booking to the current bookins datagrid
            addBookings();
            //chekc if room is occupied and change the background colour
            changeColours();
        }       

        //create the method for adding clients to the datagridview of current clients
        private void addClients()
        {
            //setting a boolean for validation
            bool alreadyIn = false;
            //setting a loop for each guest already checked in
            foreach (CheckingIn c in inCabin)
            {
                //setting a loop for every row in the datagridview 
                foreach (DataGridViewRow row in dataClientsView.Rows)
                {
                    //creating objects that will pull data from the gridview name and surname columns for comparison
                    object val1 = row.Cells[0].Value;
                    object val2 = row.Cells[1].Value;
                    //if guest already in provide message
                    if (val1 != null && val1.ToString() == c.Name.ToString() && val2 != null && val2.ToString() == c.Surname.ToString())
                    {
                        alreadyIn = true;
                        MessageBox.Show("Guest already in cabin");
                    }
                }
                //if guest is not already in then add new guest to a new row
                if (!alreadyIn)
                {
                    dataClientsView.Rows.Add(c.Name, c.Surname,c.Phone, c.CheckIn, c.CheckOut, c.CabinType, c.CabinNumber, c.Notes);
                }
            }
        }
        // create method to add new bookins to datagridview
        private void addBookings()
        {
            //setting a boolean for validation
            bool alreadyIn = false;
            //setting a loop for every guest in list of bookings
            foreach (Bookings b in booked)
            {
                //setting up a loop for each row in datagridview
                foreach (DataGridViewRow row in dataGridBookings.Rows)
                {
                    //setting objects with each row value of name and surname columns
                    object val1 = row.Cells[0].Value;
                    object val2 = row.Cells[1].Value;
                    //checking similarity and returnin message if exists
                    if (val1 != null && val1.ToString() == b.Name.ToString() &&
                        val2 != null && val2.ToString() == b.Surname.ToString())
                    {
                        alreadyIn = true;
                        MessageBox.Show("Guest already booked");
                    }
                }
                //if doesn't exist a new row is added
                if (!alreadyIn)
                {
                    dataGridBookings.Rows.Add(b.Name, b.Surname, b.Phone, b.CheckIn, b.CheckOut, b.Notes);
                }
        
            }
        }
        
        //creating event for Check in button
        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            //close the dashboard form and opens a new instance of checkIn form
            this.Close();
            frmCheckIn frm = new frmCheckIn();
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
            
        }

        //creating event for current bookings
        private void btnBookings_Click(object sender, EventArgs e)
        {
            //brings datagridview with bookings to the front 
            dataGridBookings.Visible = true;
            //hide the current clients datagridview 
            dataClientsView.Visible = false;
            //change the text for the label 
            lblCurent.Text = "Bookings List";
            //calls update and refresh methods
            dataGridBookings.Update();
            dataGridBookings.Refresh();
        }

        // same as above button but viceversa
        private void btnCurentList_Click(object sender, EventArgs e)
        {
            dataGridBookings.Visible = false;
            dataClientsView.Visible = true;
            lblCurent.Text = "Current Guest List";
            dataClientsView.Update();
            dataClientsView.Refresh();
        }

        // create event for add booking button on click
        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            //closes the dashboard and creates a new instance of the add booking form
            this.Close();
            frmAddBooking f = new frmAddBooking();
            f.FormBorderStyle = FormBorderStyle.None;
            f.Show();
        }

        
        
        // create method for changing colour of the cabin buttons
        private void changeColours()
        {
            // adding all cabin buttons to a list for iteration 
            List<Button> btn = new List<Button>();
            for (int i = 1; i <= 100; i++)
            {
                // Construct button name
                string buttonName = "btnCab" + i;

                // Try to find button with that name
                Button button = this.Controls.Find(buttonName, true).FirstOrDefault() as Button;
                // If found, add to list
               if(button != null)
                {
                    btn.Add(button);
                }     
            }
            //create a loop for any of them matching 
            foreach (CheckingIn c in inCabin)
            {
                int val = c.CabinNumber;
                foreach(Button b in btn)
                {
                    //if found change colour
                    if(val == (btn.IndexOf(b) + 1))
                    {
                        b.BackColor = Color.Red;
                    }
                }
            }
        }
        //Setting some variables that can be accessed in the solution
        public static string NameClient;
        public static string Surname;
        public static string CheckIn;
        public static string CheckOut;
        public static int PhoneNumber;
        public static int CabinNumber;
        public static string CabinType;

        //create a method to get cabin details
        private void getCabinDetails()
        {
            //loop through the list to match 
            foreach(CheckingIn c in inCabin)
            {
                //if matched set the variables;
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

        /* Setting up every cabin button  
         * On click will set the cabin number and call
         * get cabin details method
         */
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

       //create a method to open next form with cabin details
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
