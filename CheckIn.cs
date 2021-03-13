using System;
using System.Linq;
using System.Windows.Forms;

namespace Project
{
    public partial class frmCheckIn : Form
    {
        /* Student Id: 92060016
         * Name: Dan Hayworth
         * Date: 15-03-2021
         */
        public frmCheckIn()
        {
            InitializeComponent();
        }
        //set up clock
        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            dateInBook.MinDate = DateTime.Now;
            dateOutBook.MinDate = DateTime.Now;
        }
       
        
        // add event to close the form and go back to dashboard
        private void imgClose_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
            this.Close();
        }

        /************** VALIDATION *************/

        private void txtNameBook_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //call method to validate name;
            ValidateName();
        }
        //create method to validate the name
        private bool ValidateName()
        {
            bool iStats = true;
            //if null provide error
            if (txtNameBook.Text == "")
            {
                errorProvider.SetError(txtNameBook, "Name cannot be blank");
                iStats = false;
            }
            else
            {
                errorProvider.SetError(txtNameBook, "");
            }
            return iStats;
        }
        
        private void txtSurnameBook_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //call surname validation method
            ValidateSurname();
        }
        // create a validfation method for surname
        private bool ValidateSurname()
        {
            bool iStats = true;
            //if null set error
            if (txtSurnameBook.Text == "")
            {
                errorProvider.SetError(txtSurnameBook, "Surname cannot be blank");
                iStats = false;
            }
            else
            {
                errorProvider.SetError(txtSurnameBook, "");
            }
            return iStats;
        }

        // create event for phone input
        private void txtPhoneBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            //setting numerical input only
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //call phone validating method
            ValidatePhone();
          
        }
        //create phone validation method that returns a boolean
        private bool ValidatePhone()
        {
            bool iStats = true;
            //if empty then set error
            if (txtPhoneBook.Text == "")
            {
                errorProvider.SetError(txtPhoneBook, "Phone cannot be blank");
                iStats = false;
            }
            else
            {
                errorProvider.SetError(txtPhoneBook, "");
            }
            return iStats;
        }
        //create a validation event for Id number
        private void txtIDBook_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //call method to validate
            ValidateIdNumber();
            
        }
        //create a method that will return a boolean 
        private bool ValidateIdNumber()
        {
            bool iStats = true;
            //if empty set error
            if (txtIDBook.Text == "")
            {
                errorProvider.SetError(txtIDBook, "Phone cannot be blank");
                iStats = false;
            }
            else
            {
                errorProvider.SetError(txtIDBook, "");
            }
            return iStats;
        }
        //create validation event
        private void txtCabinBook_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //use a try catch for errors
            try
            {              
                //if selected cabin is suite then cabin number gets set up with the suite cabin numbers only
                if (txtCabinBook.SelectedItem != null && txtCabinBook.SelectedItem.ToString() == "Suite")
                {
                    //set up an array with suite cabin numbers
                    int[] suite = { 1, 2, 6, 7};
                    //check if cabin already occupied and remove it 
                    foreach (CheckingIn c in frmMain.inCabin)
                    {
                        int a = c.CabinNumber;
                        foreach(int i in suite)
                        {
                            suite = suite.Where(val => val != a).ToArray();
                        }
                    }
                    //add all cabin numbers to cabin number text box          
                    for (int i = 0; i < suite.Length; i++)
                    {
                        txtCabinNumber.Items.Add(suite[i]);                       
                    }
                   // check if there are no cabins left
                    if (suite.Length == 0){
                        MessageBox.Show("All Suite Cabins are occupied please choose a different cabin type!");
                    }
                }
                // i will do the same for the next 2 types of cabins
                if (txtCabinBook.SelectedItem != null && txtCabinBook.SelectedItem.ToString() == "Double")
                {
                    int[] suite = { 3, 4, 8, 9 };
                    foreach (CheckingIn c in frmMain.inCabin)
                    {
                        int a = c.CabinNumber;
                        foreach (int i in suite)
                        {
                            suite = suite.Where(val => val != a).ToArray();
                        }
                    }
                    for (int i = 0; i < suite.Length; i++)
                    {
                        txtCabinNumber.Items.Add(suite[i]);
                    }
             
                    if (suite.Length == 0)
                    {
                        MessageBox.Show("All Double Cabins are occupied please choose a different cabin type!");
                    }
                }
                if (txtCabinBook.SelectedItem != null && txtCabinBook.SelectedItem.ToString() == "Single")
                {
                    int[] suite = { 5, 10 };
                    foreach (CheckingIn c in frmMain.inCabin)
                    {
                        int a = c.CabinNumber;
                        foreach (int i in suite)
                        {
                            suite = suite.Where(val => val != a).ToArray();
                        }
                    }
                    for (int i = 0; i < suite.Length; i++)
                    {
                        txtCabinNumber.Items.Add(suite[i]);
                    }
                 
                    if (suite.Length == 0)
                    {
                        MessageBox.Show("All Single Cabins are occupied please choose a different cabin type!");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //create a validation for cabin type
        private bool checkCab()
        {
            bool isType = false;
            if (txtCabinBook.SelectedItem == null)
            {
                //if null return message
                MessageBox.Show("Please select the cabin type");

            }
            else
            {
                isType = true;
            }
            return isType;
        }
        //create event to validate the check in
        private void dateInBook_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateDateOut();
        }
        //create event to validate the check out
        private void dateOutBook_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateDateOut();

        }
        //create method to validate date input
        private bool ValidateDateOut()
        {
            //set up a boolean for validation
            bool iStats = true;
            DateTime startDate = Convert.ToDateTime(dateInBook.Text);
            DateTime endDate = Convert.ToDateTime(dateOutBook.Text);
            int daysTotal = Convert.ToInt32((endDate - startDate).TotalDays);
            if (daysTotal <=0)
            {
                errorProvider.SetError(dateOutBook, "Check out date cannot be earlier than check in");
                iStats = false;
            }
            else
            {
                errorProvider.SetError(dateOutBook, "");
            }
            return iStats;
        }
        //create a method to validate the forma on submission
        private void ValidateForm()
        {        
            if(ValidateDateOut() && ValidateIdNumber() && ValidatePhone() && ValidateName() && ValidateSurname() && checkCab() && checkNumber())
            {
                MessageBox.Show("Form has been validated and new guest added!");
                try
                {
                    //if validated a new guest will be added to list
                    CheckingIn guest = new CheckingIn(txtIDBook.Text, txtIdType.Text, txtNameBook.Text, txtSurnameBook.Text, int.Parse(txtPhoneBook.Text), dateInBook.Text, dateOutBook.Text, txtNotesBook.Text, txtCabinBook.SelectedItem.ToString(), Int32.Parse(txtCabinNumber.SelectedItem.ToString()));
                    frmMain.inCabin.Add(guest);
                    frmMain f = new frmMain();
                    f.Show();
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Please fill in all the fields!");
                }
            }
            else
            {
                MessageBox.Show("Please check the fields");
            }
        }

        public void btnBook_Click(object sender, EventArgs e)
        {
            ValidateForm();
        }

        private void txtCabinNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            checkNumber();
        }
        private bool checkNumber()
        {
            bool isNum = false;
            if(txtCabinNumber.SelectedItem == null)
            {
                MessageBox.Show("Select a cabin number");
            }
            else
            {
                isNum = true;
            }
            return isNum;
        }
    }
}
