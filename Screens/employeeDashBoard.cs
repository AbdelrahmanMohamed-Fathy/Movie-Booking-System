using Movie_Booking_System.Screens.FoodOrders;
using Movie_Booking_System.Screens.HelpTickets;
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
    public partial class employeeDashBoard : Form
    {
        private mainForm parentForm;
        private employeeReviewHelpTicket ticket;
        private employeeFulfillOrder order;
        public employeeDashBoard(mainForm parentForm, userMode mode)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void Helptickets_Click(object sender, EventArgs e)
        {
            ticket = new employeeReviewHelpTicket(parentForm, parentForm.Authority);
            ticket.Show();
        }

        private void btnManageAcc_Click(object sender, EventArgs e)
        {
            order = new employeeFulfillOrder(parentForm, parentForm.Authority);
            order.ShowDialog();
        }
    }
}
