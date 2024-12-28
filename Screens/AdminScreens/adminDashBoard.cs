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
        //bool ismousehovering;
        public adminDashBoard(mainForm parent, userMode mode)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void Menuicon_Click(object sender, EventArgs e)
        {
            dashboardadmin.Controls.Clear();
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
            Controls.Adminticket adminticketmenu = new Controls.Adminticket();
            dashboardadmin.Controls.Clear();
            dashboardadmin.Controls.Add(adminticketmenu);
            adminticketmenu.Dock = DockStyle.Fill;
        }

        private void btnManageAcc_Click(object sender, EventArgs e)
        {
            Controls.ManageAccountsControl ManageAccAdminmenu = new Controls.ManageAccountsControl(parentForm.CurrentUserID);
            dashboardadmin.Controls.Clear();
            dashboardadmin.Controls.Add(ManageAccAdminmenu);
            ManageAccAdminmenu.Dock = DockStyle.Fill;
        }

        private void btnManageCinemas_Click(object sender, EventArgs e)
        {
            Controls.ManageCinemasControl ManageAccAdminmenu = new Controls.ManageCinemasControl();
            dashboardadmin.Controls.Clear();
            dashboardadmin.Controls.Add(ManageAccAdminmenu);
            ManageAccAdminmenu.Dock = DockStyle.Fill;
        }
    }
}
