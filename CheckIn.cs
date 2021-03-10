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
            frmMain f = new frmMain();
            f.Show();
            this.Close();
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
