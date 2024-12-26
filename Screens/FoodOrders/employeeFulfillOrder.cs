﻿using Movie_Booking_System.Util;
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
        public employeeFulfillOrder()
        {
            InitializeComponent();
        }

        private void employeeFulfillOrder_Load(object sender, EventArgs e)
        {
            LoadAllIncompleteOrders();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadAllOrders();
        }

        void LoadAllIncompleteOrders()
        {
            dataGridView1.Rows.Clear();
            DataTable table = Controller.GetOrders();
            if (table == null)
            {

            }
            else
            {
                String OrderID, FoodID, FoodName, OrderCount, TotalPrice, UnitPrice, Fulfilled;
                for (int x = 0; x < table.Rows.Count; x++)
                {
                    OrderID = table.Rows[x][0].ToString();
                    FoodID = table.Rows[x][1].ToString();
                    FoodName = table.Rows[x][2].ToString();
                    OrderCount = table.Rows[x][3].ToString();
                    UnitPrice = table.Rows[x][4].ToString();
                    TotalPrice = Convert.ToString(Convert.ToInt32(OrderCount) * Convert.ToInt32(UnitPrice));
                    Fulfilled = table.Rows[x][5].ToString();
                    if (Fulfilled == "False")
                        dataGridView1.Rows.Add(OrderID, FoodID, FoodName, OrderCount, TotalPrice, UnitPrice, Fulfilled);
                }
            }
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
                String OrderID, FoodID, FoodName, OrderCount, TotalPrice, UnitPrice, Fulfilled;
                for (int x = 0; x < table.Rows.Count; x++)
                {
                    OrderID = table.Rows[x][0].ToString();
                    FoodID = table.Rows[x][1].ToString();
                    FoodName = table.Rows[x][2].ToString();
                    OrderCount = table.Rows[x][3].ToString();
                    UnitPrice = table.Rows[x][4].ToString();
                    TotalPrice = Convert.ToString(Convert.ToInt32(OrderCount) * Convert.ToInt32(UnitPrice));
                    Fulfilled = table.Rows[x][5].ToString();
                    //if (Fulfilled == "false")
                    dataGridView1.Rows.Add(OrderID, FoodID, FoodName, OrderCount, TotalPrice, UnitPrice, Fulfilled);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadAllIncompleteOrders();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox4.Text == "")
            {
                MessageBox.Show("Select Order from View .. !!");
            }
            else
            {
                Controller.UpdateOrder(Convert.ToInt32(textBox4.Text));
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
            textBox4.Text = row;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
