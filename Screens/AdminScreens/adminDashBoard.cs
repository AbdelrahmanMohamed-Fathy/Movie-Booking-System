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

        private void adminDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void Helptickets_Click(object sender, EventArgs e)
        {
            Controls.Adminticket adminmenu = new Controls.Adminticket();
            dashboardadmin.Controls.Clear();
            dashboardadmin.Controls.Add(adminmenu);
            adminmenu.Dock = DockStyle.Fill;

        }
    }
}
