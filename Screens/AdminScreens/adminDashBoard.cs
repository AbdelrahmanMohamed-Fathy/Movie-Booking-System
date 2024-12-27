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
    public partial class adminDashBoard : Form
    {
        private mainForm parentForm;
        public adminDashBoard(mainForm parent, userMode mode)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void Menuicon_Click(object sender, EventArgs e)
        {
            AdminMenu.Visible = !AdminMenu.Visible;
            if (AdminMenu.Visible) 
            {
                Menuicon.BackColor = AdminMenu.BackColor;
            }
            else
            {
                Menuicon.BackColor = this.BackColor;
            }

        }
    }
}
