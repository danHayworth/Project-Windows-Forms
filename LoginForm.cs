using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            ArrayList user = new ArrayList();
            Users admin = new Users(1, "danha", "danha", "dan@email.com");
            Users staff = new Users(2, "user", "user", "user@email.com");

            user.Add(admin);
            user.Add(staff);
            foreach(Users obj in user)
            {
                if (txtUsername.Text == obj.Username && txtPassword.Text == obj.Password)
                {
                    frmMain frm = new frmMain();
                    frm.Show();
                    txtPassword.Clear();
                    txtUsername.Clear();
                }

            }
                    
        }

        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
