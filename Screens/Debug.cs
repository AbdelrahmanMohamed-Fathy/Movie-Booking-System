using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Booking_System.Screens
{
    public partial class Debug : Form
    {
        private mainForm parentForm;
        private int DebugAdmin = 5267;
        private int DebugEmployee = 5267;
        private int DebugUser = 5267;

        public Debug(mainForm parent, userMode mode)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void btnEmployeeTicket_Click(object sender, EventArgs e)
        {
            parentForm.CurrentUserID = DebugEmployee;
            parentForm.LoadNewForm(new HelpTickets.employeeReviewHelpTicket(parentForm,userMode.Employee));
        }

        private void btnUserTicket_Click(object sender, EventArgs e)
        {
            parentForm.CurrentUserID = DebugUser;
            parentForm.LoadNewForm(new HelpTickets.userSubmitHelpTicket(parentForm, userMode.Employee));
        }

        private void btnOrderReport_Click(object sender, EventArgs e)
        {
            parentForm.CurrentUserID = DebugAdmin;
            parentForm.LoadNewForm(new AdminScreens.ordersReport(parentForm, userMode.Employee));
        }

        private void Admindashboard_Click(object sender, EventArgs e)
        {
            parentForm.CurrentUserID = DebugAdmin;
            parentForm.LoadNewForm(new AdminScreens.adminDashBoard(parentForm, userMode.Employee));
        }

        private void btnBookReport_Click(object sender, EventArgs e)
        {
            parentForm.CurrentUserID = DebugAdmin;
            parentForm.LoadNewForm(new AdminScreens.bookingReport(parentForm, userMode.Employee));
        }

        private void btnUserReport_Click(object sender, EventArgs e)
        {
            parentForm.CurrentUserID = DebugAdmin;
            parentForm.LoadNewForm(new AdminScreens.usersReport(parentForm, userMode.Employee));
        }

        private void Debug_Load(object sender, EventArgs e)
        {

        }
    }
}
