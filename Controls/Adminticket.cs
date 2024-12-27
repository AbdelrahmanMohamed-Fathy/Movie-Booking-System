using Movie_Booking_System.Screens.AdminScreens;
using Movie_Booking_System.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Movie_Booking_System.Controls
{
    public partial class Adminticket : UserControl
    {
        public Adminticket()
        {
            InitializeComponent();
            RefreshSources();

        }
        private void combobxTicketId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TicketID;
            int.TryParse(combobxTicketId.Text, out TicketID);
            DataTable dt = Controller.GetTicket(TicketID);
            if (dt == null)
                return;
            lblfrom.Show();
            lblTicketHeader.Text = dt.Rows[0].Field<string>("Header");
            lblTicketHeader.Show();
            lbluserticket.Text = dt.Rows[0].Field<string>("Fname") + " " + dt.Rows[0].Field<string>("Lname");
            lbluserticket.Show();
            txtboxTicketdesc.Text = dt.Rows[0].Field<string>("Content");
            txtboxTicketdesc.Show();
            btnMark.Show();
            dataGridView1.Show();
        }
        private void btnMark_Click(object sender, EventArgs e)
        {
            int TicketID;
            int.TryParse(combobxTicketId.Text, out TicketID);
            Controller.MarkTicket(TicketID);
            lblfrom.Hide();
            lblTicketHeader.Hide();
            lbluserticket.Hide();
            txtboxTicketdesc.Hide();
            btnMark.Hide();
            RefreshSources();
        }

        private void RefreshSources()
        {
            DataTable dt = Controller.GetTickets();
            dataGridView1.DataSource = dt;
            combobxTicketId.DataSource = dt;
            combobxTicketId.DisplayMember = "HelpTicketID";
            combobxTicketId.SelectedIndex = -1;
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            DataTable dt = Controller.GetTickets();
            if (combobxTicketId.SelectedIndex > -1)
            {
                string ticketid = combobxTicketId.Text;
                Controller.DeleteHelpTicket(Convert.ToInt32(ticketid));
                RefreshSources();
            }
            else
            {
                MessageBox.Show("No Help Ticket Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }
    }
}
