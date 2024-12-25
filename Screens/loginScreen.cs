using Movie_Booking_System.Util;
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
            parentForm.CurrentUserID = -1;
            
            this.BackColor = parent.FormColor;
            this.ForeColor = parent.FormTextColor;
            this.btnContinue.BackColor = parent.btnColor;
            this.btnLogin.BackColor = parent.btnColor;
            this.btnSignup.BackColor = parent.btnColor;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userMode mode;
            if (txtbxUsername.Text == "kofta" && txtbxPassword.Text == "kofta")
                parentForm.LoadNewForm(new Debug(parentForm, userMode.Guest));
            this.Cursor = Cursors.WaitCursor;
            if (ValidateLogin(out mode))
            {
                this.Cursor = Cursors.Default;
                parentForm.Authority = mode;
                parentForm.LoadNewForm(new userScreen(parentForm,parentForm.Authority));
            }
            else
            {
                this.Cursor = Cursors.Default;
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
            int ID;
            userMode Result = Controller.FetchUser(txtbxUsername.Text, txtbxPassword.Text,out ID);
            switch (Result)
            {
                case userMode.Admin:
                    mode = userMode.Admin;
                    parentForm.CurrentUserID = ID;
                    return true;
                case userMode.Employee:
                    mode = userMode.Employee;
                    parentForm.CurrentUserID = ID;
                    return true;
                case userMode.User:
                    mode = userMode.User;
                    parentForm.CurrentUserID = ID;
                    return true;
                default:
                    mode = userMode.Guest;
                    parentForm.CurrentUserID = -1;
                    return false;
            }
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
            if (String.IsNullOrEmpty(txtbxPassword.Text))
            {
                btnPassVis.Hide();
            }
            else
            {
                btnPassVis.Show();
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            parentForm.Authority = userMode.Guest;
            parentForm.LoadNewForm(new signupScreen(parentForm, parentForm.Authority));
        }

        private void btnPassVis_Click(object sender, EventArgs e)
        {
            txtbxPassword.UseSystemPasswordChar = !txtbxPassword.UseSystemPasswordChar;
        }

        private void loginScreen_Load(object sender, EventArgs e)
        {

        }

        private void placeHolderTextBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
