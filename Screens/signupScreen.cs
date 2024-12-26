using Movie_Booking_System.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using Movie_Booking_System.Screens;
using System.Collections.ObjectModel;

namespace Movie_Booking_System.Screens
{
    public partial class signupScreen : Form
    {
        private mainForm parentForm;
        sbyte progessBarRed = 2;
        sbyte progessBarYellow = 3;
        public signupScreen(mainForm parent, userMode mode)
        {
            InitializeComponent();
            this.parentForm = parent;
            parentForm.Authority = userMode.Guest;
            visiblepass.Hide();
            visibleconfpass.Hide();
        }

        private void Fname_Enter(object sender, EventArgs e)
        {
            if (Fname.Text == "First Name")
            {
                Fname.Text = "";
                Fname.ForeColor = Color.Black;
            }
        }


        private void Fname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Fname.Text))
            {
                Fname.Text = "First Name";
                Fname.ForeColor = Color.Silver;
            }
        }

        private void Lname_Enter(object sender, EventArgs e)
        {
            if (Lname.Text == "Last Name")
            {
                Lname.Text = "";
                Lname.ForeColor = Color.Black;
            }

        }

        private void Lname_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Lname.Text))
            {
                Lname.Text = "Last Name";
                Lname.ForeColor = Color.Silver;
            }

        }

        private void Email_Enter(object sender, EventArgs e)
        {
            if (Email.Text == "Email Address")
            {
                Email.Text = "";
                Email.ForeColor = Color.Black;
            }

        }

        private void Email_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Email.Text))
            {
                Email.Text = "Email Address";
                Email.ForeColor = Color.Silver;
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.ForeColor = Color.Black;
                password.UseSystemPasswordChar = true;
            }

        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password.Text))
            {
                password.Text = "Password";
                password.ForeColor = Color.Silver;
                password.UseSystemPasswordChar= false;
            }

        }
        private void confirmpass_Enter(object sender, EventArgs e)
        {
            if (confirmpass.Text == "Confirm Password")
            {
                confirmpass.Text = "";
                confirmpass.ForeColor = Color.Black;
                confirmpass.UseSystemPasswordChar = true;
            }
        }

        private void confirmpass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(confirmpass.Text))
            {
                confirmpass.Text = "Confirm Password";
                confirmpass.ForeColor = Color.Silver;
                confirmpass.UseSystemPasswordChar=false;
            }
        }

        private void phonenum_Enter(object sender, EventArgs e)
        {
            if (phonenum.Text == "Phone Number (Optional)")
            {
                phonenum.Text = "";
                phonenum.ForeColor = Color.Black;
            }
        }

        private void phonenum_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(phonenum.Text))
            {
                phonenum.Text = "Phone Number (Optional)";
                phonenum.ForeColor = Color.Silver;
            }

        }

        private void createacc_Click(object sender, EventArgs e)
        {
            bool IsValid = true;
            if (string.IsNullOrEmpty(Fname.Text) || Fname.Text == "First Name")
            {
                fnameinvalid.Show();
                IsValid = false;
            }
            if (string.IsNullOrEmpty(Lname.Text) || Lname.Text == "Last Name")
            {
                 lnameinvalid.Show();
                 IsValid = false;
            }
            if (string.IsNullOrEmpty(Email.Text) || Email.Text == "Email Address")
            {
                emailinvalid.Show();
                IsValid = false;

            }

            if (string.IsNullOrWhiteSpace(password.Text) || password.Text == "Password")
            {
                passwordinvalid.Text = "Password should not be empty";
                passwordinvalid.Show();
                IsValid = false;
            }
            if (!ValidatePasswordlbl(password.Text))
            {
                IsValid = false;
                
            }
            if (string.IsNullOrEmpty(confirmpass.Text) || confirmpass.Text == "Confirm Password")
            {
                confirmpasslbl.Text = "Please confirm the Password";
                confirmpasslbl.Show();
                IsValid=false;
            }
            else if (password.Text != confirmpass.Text)
            {
                confirmpasslbl.Text = "Passwords do not match!";
                confirmpasslbl.Show();
                IsValid=false;
            }
            if (IsValid)
            {
                string Role = HelperFunctions.ParseEnumToAuthority(userMode.User);
                Controller.InsertAccount(Fname.Text, Lname.Text, Email.Text, password.Text, Convert.ToInt32(phonenum.Text), Role);
                parentForm.ShowStatus();
                MessageBox.Show("user entered successfully");
                //parentForm.LoadNewForm(new userScreen(parentForm,parentForm.Authority));
            }
        }

        private void Fname_TextChanged(object sender, EventArgs e)
        {
            fnameinvalid.Hide();
        }

        private void Lname_TextChanged(object sender, EventArgs e)
        {
            lnameinvalid.Hide();
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            emailinvalid.Hide();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
                if (string.IsNullOrEmpty(password.Text) || password.Text == "Password")
                {
                    visiblepass.Hide();
                }
                else
                {
                    visiblepass.Show();
                }
                ValidatePasswordlbl(password.Text);
                int charcount = password.Text.Length;
                if (string.IsNullOrEmpty(password.Text))
                {
                    passstatuslbl.Hide();
                    panel4.BackColor = Color.LightGray;
                    panel3.BackColor = Color.LightGray;
                    panel2.BackColor = Color.LightGray;
                    panel1.BackColor = Color.LightGray;

                }
                else if (charcount >= 1 && charcount <= 4)
                {
                    passstatuslbl.Text = "Weak";
                    passstatuslbl.ForeColor = Color.Red;
                    passstatuslbl.Show();
                    panel4.BackColor = Color.LightGray;
                    panel3.BackColor = Color.LightGray;
                    panel2.BackColor = Color.LightGray;
                    panel1.BackColor = Color.Red;
                    passlenlbl.ForeColor = Color.Red;
                }
                else if (charcount > 4 && charcount < 8)
                {
                    passstatuslbl.Text = "Medium";
                    passstatuslbl.ForeColor = Color.Gold;
                    passstatuslbl.Show();
                    panel4.BackColor = Color.LightGray;
                    panel3.BackColor = Color.LightGray;
                    panel2.BackColor = Color.Gold;
                    panel1.BackColor = Color.Gold;
                    passlenlbl.ForeColor = Color.Red;
                }
                else if (charcount >= 8 && charcount <= 15 && password.Text != "Password")
                {
                    passstatuslbl.Text = "Strong";
                    passstatuslbl.ForeColor = Color.Green;
                    passstatuslbl.Show();
                    panel4.BackColor = Color.LightGray;
                    panel3.BackColor = Color.Green;
                    panel2.BackColor = Color.Green;
                    panel1.BackColor = Color.Green;

                }
                else if (charcount > 15)
                {
                    passstatuslbl.Text = "Too Large";
                    passstatuslbl.ForeColor = Color.Red;
                    passstatuslbl.Show();
                    panel4.BackColor = Color.Red;
                    panel3.BackColor = Color.Red;
                    panel2.BackColor = Color.Red;
                    panel1.BackColor = Color.Red;
                    passlenlbl.ForeColor = Color.Red;
                }

                passwordinvalid.Hide();
        }
        private void confirmpass_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(confirmpass.Text) || confirmpass.Text == "Confirm Password")
            {
                visibleconfpass.Hide();
            }
            else
            {
                visibleconfpass.Show();
            }
            confirmpasslbl.Hide();
        }

        private void visibleconfpass_Click(object sender, EventArgs e)
        {
            if (confirmpass.Text == "Confirm Password")
            {
                return;
            }
            if (confirmpass.UseSystemPasswordChar == true)
            {
                confirmpass.UseSystemPasswordChar = false;
                visibleconfpass.Image = Image.FromFile("C:\\Users\\User\\Source\\Repos\\Movie-Booking-System\\Assets\\Closed-eye-icon.png");
            }
            else
            {
                confirmpass.UseSystemPasswordChar = true;
                visibleconfpass.Image = Image.FromFile("C:\\Users\\User\\Source\\Repos\\Movie-Booking-System\\Assets\\Open-eye-icon.png");
            }

        }
        private void visiblepass_Click(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                return;
            }
            if (password.UseSystemPasswordChar == true)
            {
                password.UseSystemPasswordChar = false;
                visiblepass.Image = Image.FromFile("C:\\Users\\User\\Source\\Repos\\Movie-Booking-System\\Assets\\Closed-eye-icon.png");
                

            }
            else
            {
                password.UseSystemPasswordChar = true;
                visiblepass.Image = Image.FromFile("C:\\Users\\User\\Source\\Repos\\Movie-Booking-System\\Assets\\Open-eye-icon.png");

            }
           
        }
        private bool ValidatePassword(string input)
        {
            var pass = input;

            if (string.IsNullOrWhiteSpace(input) || password.Text == "Password")
            {
                passwordinvalid.Text = "Password should not be empty";
                passwordinvalid.Show();
                return false;
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");

            if (!hasLowerChar.IsMatch(input))
            {
                passwordinvalid.Text = "Password should contain at least one lower case letter.";
                passwordinvalid.Show();
                lowercaselbl.ForeColor = Color.Green;
                lowercaselbl.Show();
                return false;
            }
            else if (!hasUpperChar.IsMatch(input))
            {
                passwordinvalid.Text = "Password should contain at least one upper case letter.";
                passwordinvalid.Show();
                return false;
            }
            else if (!hasNumber.IsMatch(input))
            {
                passwordinvalid.Text = "Password should contain at least one numeric value.";
                passwordinvalid.Show();
                return false;
            }
            else if (!hasSymbols.IsMatch(input))
            {
                passwordinvalid.Text = "Password should contain at least one special case character.";
                passwordinvalid.Show();
                return false;
            }
            else if (!hasMiniMaxChars.IsMatch(input))
            {
                passwordinvalid.Text = "Password should be between 8-15 characters.";
                passwordinvalid.Show();
                return false;
            }

            else
            {
                passwordinvalid.Text = "Password Accepted";
                passwordinvalid.Show();
                return true;
            }
        }
        private bool ValidatePasswordlbl(string input)
        {
            var pass = input;
            bool ispassnotvalid = true;
            lowercaselbl.ForeColor = Color.Red;
            uppercaselbl.ForeColor = Color.Red;
            numericvallbl.ForeColor = Color.Red;
            specialcharlbl.ForeColor = Color.Red;
            if (string.IsNullOrWhiteSpace(input) || password.Text == "Password")
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
    }
    public static class ModifyProgressBarColor
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);
        public static void SetState(this System.Windows.Forms.ProgressBar pBar, int state)
        {
            SendMessage(pBar.Handle, 1040, (IntPtr)state, IntPtr.Zero);
        }
    }
}
