using Movie_Booking_System.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Booking_System.Screens.FoodOrders
{
    public partial class userFoodOrder : Form
    {
        private mainForm parentForm;
        int FoodQty = 0;
        int FoodPrice = 0;
        String UserID = "";

        public userFoodOrder(mainForm parent,userMode mode)
        {
            InitializeComponent();
            this.parentForm = parent;

            UserID = parent.CurrentUserID.ToString();//someone add the user Id;
            UserId1.Text = UserID;
        }

        private void userFoodOrder_Load(object sender, EventArgs e)
        {
            FoodId.Items.Clear();
            FoodName.Items.Clear();
            DataTable table = Controller.showallFoods();
            if (table == null)
            {
                
            }
            else
            {
                for(int x=0; x<table.Rows.Count; x++)
                {
                    FoodId.Items.Add(table.Rows[x][0].ToString());
                    FoodName.Items.Add(table.Rows[x][1].ToString());
                }
                Controller.InsertNewOrder(UserID);
                textBox7.Text = Controller.GetNewOrderID(UserID).ToString();
                textBox8.Text = "0";
            }
        }

        private void FoodId_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodName.SelectedItem = FoodName.Items[FoodId.SelectedIndex];

            DataTable table = Controller.GetFoodPriceandQty(FoodId.Text);
            if (table == null)
            {

            }
            else
            {
                for (int x = 0; x < table.Rows.Count; x++)
                {
                    FoodQty = Convert.ToInt32(table.Rows[x][0].ToString());
                    TotalOrCo.Text = FoodQty.ToString();
                    UsedCount.Text = Controller.GetOrdersCountFromFood(Convert.ToInt32(FoodId.Text)).ToString();
                    avaliablecount.Text = (FoodQty - Controller.GetOrdersCountFromFood(Convert.ToInt32(FoodId.Text))).ToString(); 
                    FoodPrice = Convert.ToInt32(table.Rows[x][1].ToString());
                    OrderPrice.Text = FoodPrice.ToString();
                    OrderCount.Text = "";
                }
            }
        }

        private void FoodName_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodId.SelectedItem = FoodId.Items[FoodName.SelectedIndex];

            DataTable table = Controller.GetFoodPriceandQty(FoodId.Text);
            if (table == null)
            {

            }
            else
            {
                for (int x = 0; x < table.Rows.Count; x++)
                {
                    FoodQty = Convert.ToInt32(table.Rows[x][0].ToString());
                    avaliablecount.Text = (FoodQty - Controller.GetOrdersCountFromFood(Convert.ToInt32(FoodId.Text))).ToString();

                    TotalOrCo.Text = FoodQty.ToString();
                    UsedCount.Text = Controller.GetOrdersCountFromFood(Convert.ToInt32(FoodId.Text)).ToString();

                    FoodPrice = Convert.ToInt32(table.Rows[x][1].ToString());
                    OrderPrice.Text = FoodPrice.ToString();
                    OrderCount.Text = "";
                }
            }
        }

        private void OrderCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (OrderCount.Text != "")
                {
                    int TotalPrice = FoodPrice * Convert.ToInt32(OrderCount.Text);
                    OrderPrice.Text = TotalPrice.ToString();
                }
                else
                {
                    OrderPrice.Text = FoodPrice.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in data entry !!");
                OrderCount.Text = "";
                OrderPrice.Text = FoodPrice.ToString();
            }
        }

        private void addOrderBut_Click(object sender, EventArgs e)
        {
            try
            {
                if ((FoodId.Text == "") || (OrderCount.Text == "") || (OrderPrice.Text == "") || (avaliablecount.Text == ""))
                {
                    MessageBox.Show("Missing Data .. !!");
                }
                else
                {
                    if (Convert.ToInt32(OrderCount.Text) <= 0)
                    {
                        MessageBox.Show("Can't apply zero or negative orders .. !!");
                        return;
                    }
                    if (Convert.ToInt32(OrderCount.Text) > Convert.ToInt32(avaliablecount.Text))
                    {
                        MessageBox.Show("More than available count .. !!");
                    }
                    else
                    {
                        Controller.InsertFoodOrder(FoodId.Text, OrderCount.Text, textBox7.Text);
                        MessageBox.Show("Your order was added succesfully ...");

                        avaliablecount.Text = (FoodQty - Controller.GetOrdersCountFromFood(Convert.ToInt32(FoodId.Text))).ToString();
                        TotalOrCo.Text = FoodQty.ToString();
                        UsedCount.Text = Controller.GetOrdersCountFromFood(Convert.ToInt32(FoodId.Text)).ToString();
                        DataTable tablePrice = Controller.GetTotalOrderPrice(textBox7.Text);
                        textBox8.Text = tablePrice.Rows[0][0].ToString();
                        LoadAllOrders();
                        //textBox3.Refresh();
                    }
                }
            }
            catch(Exception d)
            {
                MessageBox.Show("Error in add Order " + d.Message);
            }
        }

        private void LoadOrderButt_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            LoadAllOrders();
        }
        void LoadAllOrders()
        {
            dataGridView1.Rows.Clear();
            DataTable table = Controller.GetOrders();
            if (table == null)
            {

            }
            else
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
                    dataGridView1.Rows.Add(OrderID, FoodID, FoodName, OrderCount, TotalPrice, UnitPrice, Fulfilled, UserID);
                }
            }
        }

        private void ClearButt_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            FoodId.Text = "";
            FoodName.Text = "";
            OrderCount.Text = "";
            OrderPrice.Text = "";
            avaliablecount.Text = "";
            TotalOrCo.Text = "";
            UsedCount.Text = "";
            textBox8.Text = "";
        }

        private void DeleteOrdButton_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            Controller.DeleteOrders("");
            MessageBox.Show("All orders deleted Correctly");
            LoadAllOrders();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
