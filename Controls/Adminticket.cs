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

namespace Movie_Booking_System.Controls
{
    public partial class Adminticket : UserControl
    {
        public Adminticket()
        {
            InitializeComponent();
            DataTable dt = Controller.GetTickets();
        }

        private void combobxTicketId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int TicketID;
            //int.TryParse(cmbboxTicketID.Text, out TicketID);
            //DataTable dt = Controller.GetTicket(TicketID);
            //if (dt == null)
            //    return;
            //lblFrom.Show();
            //lblHeader.Text = dt.Rows[0].Field<string>("Header");
            //lblHeader.Show();
            //lblName.Text = dt.Rows[0].Field<string>("Fname") + " " + dt.Rows[0].Field<string>("Lname");
            //lblName.Show();
            //txtbxContent.Text = dt.Rows[0].Field<string>("Content");
            //txtbxContent.Show();
            //btnMark.Show();
        }
    }
}
