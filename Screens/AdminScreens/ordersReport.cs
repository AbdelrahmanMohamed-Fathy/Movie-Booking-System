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

namespace Movie_Booking_System.Screens.AdminScreens
{
    public partial class ordersReport : Form
    {
        private mainForm parentForm;
        public ordersReport(mainForm parent, userMode mode)
        {
            InitializeComponent();
            this.parentForm = parent;
        }
    }
}
