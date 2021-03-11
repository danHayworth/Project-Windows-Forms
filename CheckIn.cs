using System;
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
       
        public void btnBook_Click(object sender, EventArgs e)
        {    
            
            CheckingIn guest = new CheckingIn(txtIDBook.Text, txtIdType.Text, txtNameBook.Text, txtSurnameBook.Text, Int32.Parse(txtPhoneBook.Text), dateInBook.Text, dateOutBook.Text, txtNotesBook.Text, txtCabinBook.SelectedItem.ToString(), Int32.Parse(txtCabinNumber.SelectedItem.ToString()));
            frmMain.inCabin.Add(guest);
            MessageBox.Show("Guest Added ");
            Close();
            frmMain f = new frmMain();
            f.Show();
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
       
            this.Close();
        }

        private void txtNameBook_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtNameBook.Text == "")
            {
                MessageBox.Show("Name cannot be blank");
                btnBook.Enabled = false;
            }
            else
            {
                btnBook.Enabled = true;
            }
        }

        private void txtSurnameBook_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtSurnameBook.Text == "")
            {
                MessageBox.Show("Surname cannot be blank");
                btnBook.Enabled = false;
            }
            else
            {
                btnBook.Enabled = true;
            }
        }

        private void txtPhoneBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtIDBook_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtIDBook.Text == "")
            {
                MessageBox.Show("Add Id Number");
                btnBook.Enabled = false;
            }
            else
            {
                btnBook.Enabled = true;
                txtCabinBook.Select();
            }
        }

        private void txtCabinBook_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
            try
            {
                if (txtCabinBook.SelectedItem == null)
                {
                    MessageBox.Show("Please select the cabin type");
                    btnBook.Enabled = false;
                }
                if (txtCabinBook.SelectedItem != null && txtCabinBook.SelectedItem.ToString() == "Suite")
                {
                    int[] suite = { 1, 2, 6, 7 };
                    for (int i = 0; i < suite.Length; i++)
                    {
                        txtCabinNumber.Items.Add(suite[i]);
                    }
                    btnBook.Enabled = true;
                }
                if (txtCabinBook.SelectedItem != null && txtCabinBook.SelectedItem.ToString() == "Double")
                {
                    int[] suite = { 3, 4, 8, 9 };
                    for (int i = 0; i < suite.Length; i++)
                    {
                        txtCabinNumber.Items.Add(suite[i]);
                    }
                    btnBook.Enabled = true;
                }
                if (txtCabinBook.SelectedItem != null && txtCabinBook.SelectedItem.ToString() == "Single")
                {
                    int[] suite = { 5, 10 };
                    for (int i = 0; i < suite.Length; i++)
                    {
                        txtCabinNumber.Items.Add(suite[i]);
                    }
                    btnBook.Enabled = true;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtCabinNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (txtCabinNumber.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the cabin number");
                btnBook.Enabled = false;
            }
            
        }
    }
}
