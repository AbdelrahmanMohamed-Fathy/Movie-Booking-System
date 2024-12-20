using System;
using System.Drawing;
using System.Windows.Forms;

namespace Movie_Booking_System.Screens
{
    public partial class loginScreen : Form
    {
        private mainForm parentForm;

        public loginScreen(mainForm parent, userMode mode)
        {
            InitializeComponent();
            this.parentForm = parent;
            parentForm.Authority = userMode.Guest;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userMode mode;
            if (ValidateLogin(out mode))
            {
                parentForm.Authority = mode;
                parentForm.LoadNewForm(new userScreen(parentForm,parentForm.Authority));
            }
            else
            {
                txtbxUsername.ForeColor = Color.Red;
                txtbxPassword.ForeColor = Color.Red;
                lblInvalid.Show();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            parentForm.Authority = userMode.Guest;
            parentForm.LoadNewForm(new userScreen(parentForm, parentForm.Authority));
        }

        private bool ValidateLogin(out userMode mode)
        {
            //TODO: write these condition once queries are done
            if (false)
            {
                mode = userMode.User;
                return true;
            }
            else if (false)
            {
                mode = userMode.Employee;
                return true;
            }
            else if (false)
            {
                mode = userMode.Admin;
                return true;
            }

            mode = userMode.Guest;
            return false;
        }

        private void txtbxUsername_TextChanged(object sender, EventArgs e)
        {
            if (txtbxUsername.ForeColor == Color.Red)
            {
                txtbxUsername.ForeColor = Color.Black;
                txtbxPassword.ForeColor = Color.Black;
                lblInvalid.Hide();
            }
        }

        private void txtbxPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtbxPassword.ForeColor == Color.Red)
            {
                txtbxUsername.ForeColor = Color.Black;
                txtbxPassword.ForeColor = Color.Black;
                lblInvalid.Hide();
            }
        }

        private void Signupclk_Click(object sender, EventArgs e)
        {
            parentForm.Authority = userMode.Guest;
            parentForm.LoadNewForm(new NewUser(parentForm, parentForm.Authority));
        }

        private void visibleconfpass_Click(object sender, EventArgs e)
        {
            if (txtbxPassword.UseSystemPasswordChar == true)
            {
                txtbxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtbxPassword.UseSystemPasswordChar= true;
            } 
            
        }
    }
}
