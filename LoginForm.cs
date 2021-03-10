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
        public static string loggedUser = "";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            foreach(Users obj in user)
            {
                if (txtUsername.Text == obj.Username && txtPassword.Text == obj.Password)
                {
                    loggedUser = txtUsername.Text;
                    frmMain frm = new frmMain();
                    this.Hide();
                    frm.Show();
                    txtPassword.Clear();
                    txtUsername.Clear();
                }

            }
                
        }
        internal ArrayList user = new ArrayList();
        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
          
            Users admin = new Users(1, "danha", "danha", "dan@email.com");
            Users staff = new Users(2, "user", "user", "user@email.com");
            user.Add(admin);
            user.Add(staff);
        }
    }
}
