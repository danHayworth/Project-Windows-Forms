using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class frmAddBooking : Form
    {
        public frmAddBooking()
        {
            InitializeComponent();
        }

        private void frmAddBooking_Load(object sender, EventArgs e)
        {
            dateInBooking.MinDate = DateTime.Now;
            dateOutBooking.MinDate = DateTime.Now;
        }
        private void imgClose_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
            this.Close();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    Bookings newBooking = new Bookings(txtNameBooking.Text, txtSurnameBooking.Text, Int32.Parse(txtPhoneBooking.Text), dateInBooking.Text, dateOutBooking.Text, txtNotesBooking.Text);
                    frmMain.booked.Add(newBooking);
                    frmMain f = new frmMain();
                    f.Show();
                    this.Close();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

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

        private void txtPhoneBooking_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
