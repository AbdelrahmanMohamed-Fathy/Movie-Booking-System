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

namespace Movie_Booking_System.Screens.FoodOrders
{
    public partial class employeeFulfillOrder : Form
    {
        private mainForm parentForm;
        public employeeFulfillOrder(mainForm parent, userMode mode)
        {
            InitializeComponent();
            this.parentForm = parent;
        }

        private void employeeFulfillOrder_Load(object sender, EventArgs e)
        {
            LoadAllIncompleteOrders();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtOrderId.Text = "";
        }

        private void btnLoadorder_Click(object sender, EventArgs e)
        {
            LoadAllOrders();
        }

        void LoadAllIncompleteOrders()
        {
            dataGridView1.Rows.Clear();
            DataTable table = Controller.GetOrders();
            if (table != null)
            {
                string OrderID, FoodID, FoodName, OrderCount, TotalPrice, UnitPrice, Fulfilled, UserID;
                for (int x = 0; x < table.Rows.Count; x++)
                {
                    OrderID = table.Rows[x][0].ToString();
                    FoodID = table.Rows[x][1].ToString();
                    FoodName = table.Rows[x][2].ToString();
                    OrderCount = table.Rows[x][3].ToString();
                    UnitPrice = table.Rows[x][4].ToString();
                    TotalPrice = Convert.ToString(Convert.ToInt32(OrderCount) * Convert.ToInt32(UnitPrice));
                    Fulfilled = table.Rows[x][5].ToString();
                    UserID = table.Rows[x][6].ToString();
                    if (Fulfilled == "False")
                        dataGridView1.Rows.Add(OrderID, FoodID, FoodName, OrderCount, TotalPrice, UnitPrice, Fulfilled, UserID);
                }
            }
        }

        void LoadAllOrders()
        {
            dataGridView1.Rows.Clear();
            DataTable table = Controller.GetOrders();
            if (table != null)
            {
                String OrderID, FoodID, FoodName, OrderCount, TotalPrice, UnitPrice, Fulfilled, UserID;
                for (int x = 0; x < table.Rows.Count; x++)
                {
                    OrderID = table.Rows[x][0].ToString();
                    FoodID = table.Rows[x][1].ToString();
                    FoodName = table.Rows[x][2].ToString();
                    OrderCount = table.Rows[x][3].ToString();
                    UnitPrice = table.Rows[x][4].ToString();
                    TotalPrice = Convert.ToString(Convert.ToInt32(OrderCount) * Convert.ToInt32(UnitPrice));
                    Fulfilled = table.Rows[x][5].ToString();
                    UserID = table.Rows[x][6].ToString();
                    //if (Fulfilled == "false")
                    dataGridView1.Rows.Add(OrderID, FoodID, FoodName, OrderCount, TotalPrice, UnitPrice, Fulfilled, UserID);
                }
            }
        }

        private void btnLoadincOrd_Click(object sender, EventArgs e)
        {
            LoadAllIncompleteOrders();
        }

        private void btnCompleteorder_Click(object sender, EventArgs e)
        {
            if(txtOrderId.Text == "")
            {
                MessageBox.Show("Select Order from View .. !!");
            }
            else
            {
                Controller.UpdateOrder(Convert.ToInt32(txtOrderId.Text));
                MessageBox.Show("Order Completed Correctly ...");
                LoadAllIncompleteOrders();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            var rowsCount = dataGridView1.SelectedRows.Count;
            if (rowsCount == 0 || rowsCount > 1) 
                return;

            String row = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if (row == null) 
                return;
            txtOrderId.Text = row;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
