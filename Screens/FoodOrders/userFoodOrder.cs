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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Movie_Booking_System.Screens.FoodOrders
{
    public partial class userFoodOrder : Form
    {
        int FoodQty = 0;
        int FoodPrice = 0;
        String UserID = "";
        public userFoodOrder(String UserID_)
        {
            InitializeComponent();
            UserID = UserID_;//someone add the user Id;
            textBox4.Text = UserID;
        }

        private void userFoodOrder_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            DataTable table = Controller.showallFoods();
            if (table == null)
            {
                
            }
            else
            {
                for(int x=0; x<table.Rows.Count; x++)
                {
                    comboBox1.Items.Add(table.Rows[x][0].ToString());
                    comboBox2.Items.Add(table.Rows[x][1].ToString());
                }
                Controller.InsertNewOrder(UserID);
                textBox7.Text = Controller.GetNewOrderID(UserID).ToString();
                textBox8.Text = "0";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.SelectedItem = comboBox2.Items[comboBox1.SelectedIndex];

            DataTable table = Controller.GetFoodPriceandQty(comboBox1.Text);
            if (table == null)
            {

            }
            else
            {
                for (int x = 0; x < table.Rows.Count; x++)
                {
                    FoodQty = Convert.ToInt32(table.Rows[x][0].ToString());
                    textBox5.Text = FoodQty.ToString();
                    textBox6.Text = Controller.GetAllOrdersCountFromFood(Convert.ToInt32(comboBox1.Text)).ToString();
                    textBox3.Text = (FoodQty - Controller.GetAllOrdersCountFromFood(Convert.ToInt32(comboBox1.Text))).ToString(); 
                    FoodPrice = Convert.ToInt32(table.Rows[x][1].ToString());
                    textBox2.Text = FoodPrice.ToString();
                    textBox1.Text = "";
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = comboBox1.Items[comboBox2.SelectedIndex];

            DataTable table = Controller.GetFoodPriceandQty(comboBox1.Text);
            if (table == null)
            {

            }
            else
            {
                for (int x = 0; x < table.Rows.Count; x++)
                {
                    FoodQty = Convert.ToInt32(table.Rows[x][0].ToString());
                    textBox3.Text = (FoodQty - Controller.GetAllOrdersCountFromFood(Convert.ToInt32(comboBox1.Text))).ToString();

                    textBox5.Text = FoodQty.ToString();
                    textBox6.Text = Controller.GetAllOrdersCountFromFood(Convert.ToInt32(comboBox1.Text)).ToString();

                    FoodPrice = Convert.ToInt32(table.Rows[x][1].ToString());
                    textBox2.Text = FoodPrice.ToString();
                    textBox1.Text = "";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    int TotalPrice = FoodPrice * Convert.ToInt32(textBox1.Text);
                    textBox2.Text = TotalPrice.ToString();
                }
                else
                {
                    textBox2.Text = FoodPrice.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error in data entry !!");
                textBox1.Text = "";
                textBox2.Text = FoodPrice.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if ((comboBox1.Text == "") || (textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == ""))
                {
                    MessageBox.Show("Missing Data .. !!");
                }
                else
                {
                    if (Convert.ToInt32(textBox1.Text) <= 0)
                    {
                        MessageBox.Show("Can't apply zero or negative orders .. !!");
                        return;
                    }
                    if (Convert.ToInt32(textBox1.Text) > Convert.ToInt32(textBox3.Text))
                    {
                        MessageBox.Show("More than available count .. !!");
                    }
                    else
                    {
                        Controller.InsertFoodOrder(comboBox1.Text, textBox1.Text, "0", textBox7.Text);
                        MessageBox.Show("Your order was added succesfully ...");

                        textBox3.Text = (FoodQty - Controller.GetAllOrdersCountFromFood(Convert.ToInt32(comboBox1.Text))).ToString();
                        textBox5.Text = FoodQty.ToString();
                        textBox6.Text = Controller.GetAllOrdersCountFromFood(Convert.ToInt32(comboBox1.Text)).ToString();
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox8.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
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
