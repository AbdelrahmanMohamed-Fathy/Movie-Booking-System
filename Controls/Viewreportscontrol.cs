using Movie_Booking_System.Screens.AdminScreens;
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
    public partial class Viewreportscontrol : UserControl
    {
        private mainForm parentForm;
        public Viewreportscontrol(mainForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void btnOrdersreports_Click(object sender, EventArgs e)
        {
            ordersReport ordersrep = new ordersReport(parentForm, parentForm.Authority);
            ordersrep.ShowDialog();
        }

        private void btnbookreports_Click(object sender, EventArgs e)
        {
            bookingReport bookingrep = new bookingReport(parentForm, parentForm.Authority);
            bookingrep.ShowDialog();
        }
    }
}

