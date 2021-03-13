using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project
{
    public partial class frmLogin : Form
    {
        /* Student Id: 92060016
         * Name: Dan Hayworth
         * Date: 15-03-2021
         */
        public frmLogin()
        {
            InitializeComponent();
        }
        //creating a string for the logged user
        public static string loggedUser = "";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //validate form before moving to dashboard
            validateForm();
            //check user match in the user array list
            //if found match
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
        //set up a user list class 
        internal List<Users> user = new List<Users>();

        //if click on x image the app will close
        private void imgClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //on load add the following user to the list to be able to login
        private void frmLogin_Load(object sender, EventArgs e)
        {
            //create new user
            Users staff = new Users(2, "user", "user", "user@email.com");
            //then add to list
            user.Add(staff);
        }

        /************** VALIDATION *************/

        private void txtUsername_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //call username validating method
            validateUsername();
        }
        //set up a boolean method for validation
        private bool validateUsername()
        {
            bool isreal = true;
            //if is no match change boolean
            if(txtUsername.Text != user[0].Username)
            {
                //provide UI error
                errorProvider.SetError(txtUsername, "Wrong");
                isreal = false;
            }
            
            return isreal;
        }
        //password validation
        private void txtPassword_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //call password method 
            validatePass();
        }
        //set up a boolean method for validation
        private bool validatePass()
        {
            //if is no match change boolean
            bool isreal = true;
            if (txtPassword.Text != user[0].Password)
            {
                //provide UI error
                errorProvider.SetError(txtPassword, "Wrong");
                isreal = true;
            }
            return isreal;
        }
        //generate a method for all input and provide an output for user 
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
