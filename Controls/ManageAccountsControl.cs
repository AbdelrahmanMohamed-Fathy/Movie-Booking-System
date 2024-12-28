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
    public partial class ManageAccountsControl : UserControl
    {
        public ManageAccountsControl()
        {
            InitializeComponent();
        }

        private void btnAddAccountAdmin_Click_1(object sender, EventArgs e)
        {
            Controls.AddAccountmenu addaccmen = new Controls.AddAccountmenu();
            this.Controls.Clear();
            this.Controls.Add(addaccmen);
            addaccmen.Dock = DockStyle.Fill;
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            Controls.AddAccountmenu addaccmen = new Controls.AddAccountmenu();
            panelmngacc.Controls.Clear();
            panelmngacc.Controls.Add(addaccmen);
            addaccmen.Dock = DockStyle.Fill;
        }
    }
}
