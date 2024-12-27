using Movie_Booking_System.Util;
using System;
using System.Data;
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
            DataTable dt = Controller.GetCurrentShows();
            if (dt != null )
                foreach (DataRow r in dt.Rows)
                {
                    flowLayoutPanel1.Controls.Add(new Controls.MovieCard(parentForm,r));
                }
        }

        private void button1_Click(object sender, EventArgs e)//Ahmad
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
