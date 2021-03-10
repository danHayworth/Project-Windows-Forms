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

        private void btnBooking_Click(object sender, EventArgs e)
        {
            Bookings newBooking = new Bookings(txtNameBooking.Text, txtSurnameBooking.Text, Int32.Parse(txtPhoneBooking.Text), dateInBooking.Text, dateOutBooking.Text, txtNotesBooking.Text);
            frmMain.booked.Add(newBooking);
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
