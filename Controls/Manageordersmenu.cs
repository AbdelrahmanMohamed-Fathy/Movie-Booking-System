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
    public partial class Manageordersmenu : UserControl
    {
        public Manageordersmenu()
        {
            InitializeComponent();
            RefreshSources();

        }
        private void RefreshSources()
        {

            DataTable dt = Controller.GetOrders();
            datagridallorders.DataSource = dt;
            cmbxOrderID.DataSource = dt;
            cmbxOrderID.DisplayMember = "OrderID";
            cmbxOrderID.SelectedIndex = -1;
            cmbxOrderID.Text = "Order ID.";
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (cmbxOrderID.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select the Order ID for the Order to be Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                MessageBox.Show("Are you sure you want to delete this Order with ID = " + cmbxOrderID.Text + " ? ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Controller.DeleteOrders(cmbxOrderID.Text);
                RefreshSources();
            }
        }

        private void btnmarkfullfilled_Click(object sender, EventArgs e)
        {
            if (cmbxOrderID.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select the Order ID for the Order to be fulfilled", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                Controller.UpdateOrder(Convert.ToInt32(cmbxOrderID.Text));
                RefreshSources();
            }
        }
    }
}
