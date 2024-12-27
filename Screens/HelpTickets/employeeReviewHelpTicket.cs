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
    public partial class employeeReviewHelpTicket : Form
    {
        private mainForm parentForm;

        public employeeReviewHelpTicket(mainForm parent, userMode mode)
        {
            InitializeComponent();
            this.parentForm = parent;
            DataTable dt = Controller.GetTickets();
            RefreshSources();
        }

        private void cmbboxTicketID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int TicketID;
            int.TryParse(cmbboxTicketID.Text, out TicketID);
            DataTable dt = Controller.GetTicket(TicketID);
            if (dt == null)
                return;
            lblFrom.Show();
            lblHeader.Text = dt.Rows[0].Field<string>("Header");
            lblHeader.Show();
            lblName.Text = dt.Rows[0].Field<string>("Fname") + " " + dt.Rows[0].Field<string>("Lname");
            lblName.Show();
            txtbxContent.Text = dt.Rows[0].Field<string>("Content");
            txtbxContent.Show();
            btnMark.Show();
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            int TicketID;
            int.TryParse(cmbboxTicketID.Text, out TicketID);
            Controller.MarkTicket(TicketID);
            lblFrom.Hide();
            lblHeader.Hide();
            lblName.Hide();
            txtbxContent.Hide();
            btnMark.Hide();
            RefreshSources();
        }

        private void RefreshSources()
        {
            DataTable dt = Controller.GetTickets();
            dataGridView1.DataSource = dt;
            cmbboxTicketID.DataSource = dt;
            cmbboxTicketID.DisplayMember = "HelpTicketID";
            cmbboxTicketID.SelectedIndex = -1;
        }
    }
}
