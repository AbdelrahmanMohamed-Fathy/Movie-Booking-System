using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Booking_System.Screens
{
    public partial class loginScreen : Form
    {
        private mainForm parentForm;

        public loginScreen(mainForm parent)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void loginScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            userMode mode;
            if (ValidateLogin(out mode))
                parentForm.LoadNewForm(new userScreen(parentForm,mode));
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            parentForm.LoadNewForm(new userScreen(parentForm, userMode.Guest));
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

    }
}
