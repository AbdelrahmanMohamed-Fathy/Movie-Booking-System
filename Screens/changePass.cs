using Movie_Booking_System.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Booking_System.Screens
{
    public partial class changePass : Form
    {
        private mainForm parentForm;
        public changePass(mainForm parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private bool ValidatePasswordlbl(string input)
        {
            var pass = input;
            bool ispassnotvalid = true;
            lowercaselbl.ForeColor = Color.Red;
            uppercaselbl.ForeColor = Color.Red;
            numericvallbl.ForeColor = Color.Red;
            specialcharlbl.ForeColor = Color.Red;
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (hasLowerChar.IsMatch(input))
            {
                lowercaselbl.ForeColor = Color.Green;
                ispassnotvalid = false;
            }
            if (hasUpperChar.IsMatch(input))
            {
                uppercaselbl.ForeColor = Color.Green;
                ispassnotvalid = false;
            }
            if (hasNumber.IsMatch(input))
            {
                numericvallbl.ForeColor = Color.Green;
                ispassnotvalid = false;
            }
            if (hasSymbols.IsMatch(input))
            {
                specialcharlbl.ForeColor = Color.Green;
                ispassnotvalid = false;
            }
            if (hasMiniMaxChars.IsMatch(input))
            {
                passlenlbl.ForeColor = Color.Green;
                ispassnotvalid = false;
            }
            if (!ispassnotvalid)
            {
                return true;
            }
            else
            {
                passwordinvalid.Text = "Password Not Accepted";
                passwordinvalid.Show();
                return false;
            }
        }

        private void visiblepass_Click(object sender, EventArgs e)
        {
              
            if (txtbxNewPass.Text == "Password")
            {
                return;
            }
            if (txtbxNewPass.UseSystemPasswordChar == true)
            {
                txtbxNewPass.UseSystemPasswordChar = false;
                visiblepass.Image = Image.FromFile("..\\..\\Assets\\Closed-eye-icon.png");


            }
            else
            {
                txtbxNewPass.UseSystemPasswordChar = true;
                visiblepass.Image = Image.FromFile("..\\..\\Assets\\Open-eye-icon.png");

            }

        }

        private void txtbxNewPass_TextChanged(object sender, EventArgs e)
        {
            ValidatePasswordlbl(txtbxNewPass.Text);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool IsValid = true;
            if (string.IsNullOrWhiteSpace(txtbxNewPass.Text))
            {
                passwordinvalid.Text = "Password should not be empty";
                passwordinvalid.Show();
                IsValid = false;
            }
            if (!ValidatePasswordlbl(txtbxNewPass.Text))
            {
                IsValid = false;

            }
            if (string.IsNullOrEmpty(txtbxConfirm.Text))
            {
                confirmpasslbl.Text = "Please confirm the Password";
                confirmpasslbl.Show();
                IsValid = false;
            }
            else if (txtbxNewPass.Text != txtbxConfirm.Text)
            {
                confirmpasslbl.Text = "Passwords do not match!";
                confirmpasslbl.Show();
                IsValid = false;
            }
            if (IsValid)
            {
                Controller.UpdatePass(parentForm.CurrentUserID, txtbxNewPass.Text);
                parentForm.CurrentUserID = -1;
                parentForm.ShowStatus();
                parentForm.LoadNewForm(new loginScreen(parentForm, parentForm.Authority));
                this.Close();
            }
        }

        private void txtbxConfirm_TextChanged(object sender, EventArgs e)
        {
            confirmpasslbl.Hide();
        }
    }
}
