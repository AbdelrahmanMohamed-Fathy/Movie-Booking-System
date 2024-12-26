using Movie_Booking_System.Screens.FoodOrders;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Movie_Booking_System.Screens
{
    public partial class userScreen : Form
    {
        private mainForm parentForm;
        private userMode mode;
        public userScreen(mainForm parent,userMode mode)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.mode = mode;
        }

        private void userScreen_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Movie Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                textBox1.Font =new Font(textBox1.Font,FontStyle.Regular);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "Enter Movie Name";
                textBox1.ForeColor = Color.Silver;
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String UserID = "1"; // Select user from form
            userFoodOrder userFoodOrder1 = new userFoodOrder(UserID);
            userFoodOrder1.ShowDialog(this);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            employeeFulfillOrder employeeFulfillOrder1 = new employeeFulfillOrder();
            employeeFulfillOrder1.ShowDialog(this);
        }
    }
}
