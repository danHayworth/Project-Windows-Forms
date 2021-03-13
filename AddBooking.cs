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
            //using validation constraints  for validation 
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    //if validation passess then a new booking is being created
                    Bookings newBooking = new Bookings(txtNameBooking.Text, txtSurnameBooking.Text, Int32.Parse(txtPhoneBooking.Text), dateInBooking.Text, dateOutBooking.Text, txtNotesBooking.Text);
                    //adding the booking to the list 
                    frmMain.booked.Add(newBooking);
                    //creating a new instance of dashbord form and closing this 
                    frmMain f = new frmMain();
                    f.Show();
                    this.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        /************** VALIDATION *************/

        //if name box is empty do not validate
        private void txtNameBooking_Validating(object sender, CancelEventArgs e)
        {
    
            if (txtNameBooking.Text == "")
            {
                MessageBox.Show("Name cannot be blank");
                btnBooking.Enabled = false;
            }
            else
            {
                btnBooking.Enabled = true;
            }
         
        }
        //if surname box is empty do not validate
        private void txtSurnameBooking_Validating(object sender, CancelEventArgs e)
        {
            if (txtSurnameBooking.Text == "")
            {
                MessageBox.Show("Surname cannot be blank");
                btnBooking.Enabled = false;
            }
            else
            {
                btnBooking.Enabled = true;
            }

        }
        // force input to be numeric while still keeping the controls running
        private void txtPhoneBooking_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
