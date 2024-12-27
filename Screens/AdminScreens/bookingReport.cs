using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Booking_System.Screens.AdminScreens
{
    public partial class bookingReport : Form
    {
        mainForm parentForm;
        public bookingReport(mainForm parent, userMode mode)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void bookingReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'reportsData.BookingStats' table. You can move, or remove it, as needed.
            this.bookingStatsTableAdapter.Fill(this.reportsData.BookingStats);

            this.reportViewer1.RefreshReport();
        }
    }
}
