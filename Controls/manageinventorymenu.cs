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
    public partial class manageinventorymenu : UserControl
    {
        public manageinventorymenu()
        {
            InitializeComponent();
            datagridallfood.DataSource = Controller.Getallfooditems();
            RefreshSources();
        }
        private void RefreshSources()
        {

            DataTable dt = Controller.Getallfooditems();
            datagridallfood.DataSource = dt;
            cmbxFoodID.DataSource = dt;
            cmbxFoodID.DisplayMember = "FoodID";
            cmbxFoodID.SelectedIndex = -1;
            cmbxFoodID.Text = "Food Item ID.";
        }

        private void btnAddFoodItm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtbxfoodname.Text))
            {
                MessageBox.Show("Please Insert the Food Item Name for the Item to be Added to the inventory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if(string.IsNullOrEmpty(txtbxqty.Text))
            {
                MessageBox.Show("Please Insert the Food Item Quantity for the Item to be Added to the inventory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (string.IsNullOrEmpty(txtbxprice.Text))
            {
                MessageBox.Show("Please Insert the Food Item Price for the Item to be Added to the inventory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {

                Controller.AddFoodItm(txtbxfoodname.Text,Convert.ToInt32(txtbxqty.Text),Convert.ToInt32(txtbxprice.Text),txtbxdesc.Text);
                MessageBox.Show("Food Item Added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshSources();
            }
        }

        private void btnRemoveFooditm_Click(object sender, EventArgs e)
        {
            if (cmbxFoodID.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select the Food Item ID for the Item to be Removed from the inventory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Are you sure you want to delete this Food Item with ID = " + cmbxFoodID.Text + " ? ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Controller.DeleteFooditm(Convert.ToInt32(cmbxFoodID.Text));
                RefreshSources();

            }

        }

        private void btnUpdateFooditm_Click(object sender, EventArgs e)
        {
            if (cmbxFoodID.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select the Food Item ID for the Item to be Updated in the inventory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Controller.Updatefooditmqty(Convert.ToInt32(txtbxnewqty.Text), Convert.ToInt32(cmbxFoodID.Text));
                MessageBox.Show("Inventory Updated", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshSources();
            }
        }
    }
}
