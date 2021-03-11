using System;
using System.Linq;
using System.Windows.Forms;

namespace Project
{
    public partial class frmCheckIn : Form
    {
        public frmCheckIn()
        {
            InitializeComponent();
        }

        private void frmCheckIn_Load(object sender, EventArgs e)
        {
            dateInBook.MinDate = DateTime.Now;
            dateOutBook.MinDate = DateTime.Now;
        }
       
        

        private void imgClose_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
            this.Close();
        }

        private void txtNameBook_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            ValidateName();
        }
        private bool ValidateName()
        {
            bool iStats = true;
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
            ValidateSurname();
        }
        private bool ValidateSurname()
        {
            bool iStats = true;
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


        private void txtPhoneBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            ValidatePhone();
          
        }
        private bool ValidatePhone()
        {
            bool iStats = true;
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

        private void txtIDBook_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

            ValidateIdNumber();
            
        }
        private bool ValidateIdNumber()
        {
            bool iStats = true;
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

        private void txtCabinBook_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            try
            {
                if (txtCabinBook.SelectedItem == null)
                {
                    MessageBox.Show("Please select the cabin type");
                   
                }
                if (txtCabinBook.SelectedItem != null && txtCabinBook.SelectedItem.ToString() == "Suite")
                {
                    int[] suite = { 1, 2, 6, 7};
               
                    foreach (CheckingIn c in frmMain.inCabin)
                    {
                        int a = c.CabinNumber;
                        foreach(int i in suite)
                        {
                            suite = suite.Where(val => val != a).ToArray();
                        }
                    }
                              
                    for (int i = 0; i < suite.Length; i++)
                    {
                        txtCabinNumber.Items.Add(suite[i]);                       
                    }
                   
                    if (suite.Length == 0){
                        MessageBox.Show("All Suite Cabins are occupied please choose a different cabin type!");
                    }
                }
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
        private void dateInBook_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateDateOut();
        }
        private void dateOutBook_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValidateDateOut();

        }
        private bool ValidateDateOut()
        {
            bool iStats = true;
            string[] dateIn;
            string[] dateOut;
            dateIn = dateInBook.Text.Split('-');
            dateOut = dateOutBook.Text.Split('-');
            int i = Convert.ToInt32(dateIn[0]);
            int j = Convert.ToInt32(dateOut[0]);
            if (j <= i)
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
        private void ValidateForm()
        {
            bool jValidName = ValidateName();
            bool jValidSurname = ValidateSurname();
            bool jValidatePhone = ValidatePhone();
            bool jValidateId = ValidateIdNumber();
            bool jValidateDate = ValidateDateOut();
            if(jValidateDate && jValidateId && jValidatePhone && jValidName && jValidSurname)
            {
                MessageBox.Show("Form has been validated and new guest added!");
                try
                {
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

        
    }
}
