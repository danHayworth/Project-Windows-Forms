using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Project
{
    public partial class frmAddBooking : Form
    {
        /* Student Id: 92060016
         * Name: Dan Hayworth
         * Date: 15-03-2021
         */
        public frmAddBooking()
        {
            InitializeComponent();
        }

        // on loading I am setting up the time to DateTime.Now() and append that to the label
        private void frmAddBooking_Load(object sender, EventArgs e)
        {
            dateInBooking.MinDate = DateTime.Now;
            dateOutBooking.MinDate = DateTime.Now;
        }
        //on click image x close the booking form and open the Dashboard
        private void imgClose_Click(object sender, EventArgs e)
        {
            //create a new instance of the dashboard form
            frmMain f = new frmMain();
            f.Show();
            this.Close();
        }

        //create a click event for the button
        private void btnBooking_Click(object sender, EventArgs e)
        {
            //using validation  
            if (ValidateForm())
            {
                //if validation passess then a new booking is being created
                Bookings newBooking = new Bookings(txtNameBooking.Text, txtSurnameBooking.Text, Int32.Parse(txtPhoneBooking.Text), dateInBooking.Text, dateOutBooking.Text, txtNotesBooking.Text);
                //adding the booking to the list 
                frmMain.booked.Add(newBooking);
                //creating a new instance of dashbord form and closing this 
                frmMain f = new frmMain();
                f.Show();
                this.Close();
            }
            
           
        }

        /************** VALIDATION *************/

        //if name box is empty do not validate
        private void txtNameBooking_Validating(object sender, CancelEventArgs e)
        {
            ValidateName();      
        }
        private bool ValidateName()
        {
            bool iStats = true;
            //if null provide error
            if (txtNameBooking.Text == "")
            {
                errorProvider1.SetError(txtNameBooking, "Name cannot be blank");
                iStats = false;
            }
            else
            {
                errorProvider1.SetError(txtNameBooking, "");
            }
            return iStats;
        }
        //if surname box is empty do not validate
        private void txtSurnameBooking_Validating(object sender, CancelEventArgs e)
        {
            ValidateSurname();
            txtPhoneBooking.Focus();
        }
        private bool ValidateSurname()
        {
            bool iStats = true;
            //if null set error
            if (txtSurnameBooking.Text == "")
            {
                errorProvider1.SetError(txtSurnameBooking, "Surname cannot be blank");
                iStats = false;

            }
            else
            {
                errorProvider1.SetError(txtSurnameBooking, "");
            }
            return iStats;
        }

        // force input to be numeric while still keeping the controls running
        private void txtPhoneBooking_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            ValidatePhone();
           
        }
        //create phone validation method that returns a boolean
        private bool ValidatePhone()
        {
            bool iStats = true;
            //if empty then set error
            if (txtPhoneBooking.Text == "")
            {
                errorProvider1.SetError(txtPhoneBooking, "Phone cannot be blank");
                iStats = false;
            }
            else
            {
                errorProvider1.SetError(txtPhoneBooking, "");
            }
            return iStats;
        }

        //create method to validate date input
        private bool ValidateDateOut()
        {
            bool iStats = true;
            DateTime startDate = Convert.ToDateTime(dateInBooking.Text);
            DateTime endDate = Convert.ToDateTime(dateOutBooking.Text);
            int daysTotal = Convert.ToInt32((endDate - startDate).TotalDays);
            if (daysTotal <=0 )
            {
                errorProvider1.SetError(dateOutBooking, "Check out date cannot be earlier or in the same day as check in");
                iStats = false;
            }
            else
            {
                errorProvider1.SetError(dateOutBooking, "");
            }
            return iStats;
        }

        private void dateInBooking_Validating(object sender, CancelEventArgs e)
        {
            ValidateDateOut();
        
        }

        private void dateOutBooking_Validating(object sender, CancelEventArgs e)
        {
            ValidateDateOut();
        }
        private bool ValidateForm()
        {
            bool valid = false;
            if(ValidateName() && ValidatePhone() && ValidateDateOut() && ValidateSurname())
            {
                MessageBox.Show("A new booking has been created");
                valid = true;
            }
            else
            {
                MessageBox.Show("Check you input!");
            }
            return valid;
        }
    }
}
