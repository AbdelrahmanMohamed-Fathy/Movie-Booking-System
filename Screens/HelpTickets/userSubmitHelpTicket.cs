using Movie_Booking_System.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Booking_System.Screens.HelpTickets
{
    public partial class userSubmitHelpTicket : Form
    {
        private mainForm parentForm;
        public userSubmitHelpTicket(mainForm parent,userMode mode)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (Controller.SubmitTicket(parentForm.CurrentUserID,txtbxHeader.Text,txtbxContent.Text) > 0)
            {
                txtbxHeader.Text = "";
                txtbxContent.Text = "";
                txtbxHeader.Focus();
                lblSuccess.Show();
            }
        }

        private void txtbxHeader_TextChanged(object sender, EventArgs e)
        {
            lblSuccess.Hide();
        }
    }
}
