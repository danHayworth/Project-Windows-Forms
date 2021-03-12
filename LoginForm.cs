using System;
using System.Collections;
using System.Collections.Generic;
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
            validateForm();
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
        internal List<Users> user = new List<Users>();
        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Users staff = new Users(2, "user", "user", "user@email.com");
            user.Add(staff);
        }

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validateUsername();
        }
        private bool validateUsername()
        {
            bool isreal = true;
            if(txtUsername.Text != user[0].Username)
            {
                errorProvider.SetError(txtUsername, "Wrong");
                isreal = false;
            }
            return isreal;
        }
        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            validatePass();
        }
        private bool validatePass()
        {
            bool isreal = true;
            if (txtPassword.Text != user[0].Password)
            {
                errorProvider.SetError(txtPassword, "Wrong");
                isreal = true;
            }
            return isreal;
        }
        private void validateForm()
        {
            if(validatePass() && validateUsername())
            {
                MessageBox.Show("Welcome " + user[0].Username);
            }
            else
            {
                MessageBox.Show("Wrong credentials");
            }
        }
    }
}
