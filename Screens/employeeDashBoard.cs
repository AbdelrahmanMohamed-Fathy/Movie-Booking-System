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
        public employeeDashBoard(mainForm parent,userMode mode)
        {
            InitializeComponent();
            this.parentForm = parent;
        }
    }
}
