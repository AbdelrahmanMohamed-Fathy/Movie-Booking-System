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

namespace Movie_Booking_System.Screens
{
    public partial class userReview : Form
    {
        private int MovieID;
        private int UserID;
        public userReview(int MovieID, int UserID)
        {
            InitializeComponent();
            this.MovieID = MovieID;
            this.UserID = UserID;
            DataTable dt = Controller.GetMovieName(this.MovieID);
            DataRow data = dt.Rows[0];
            movieName.Text = data.Field<string>("MovieName");
        }
        private void Star1_MouseEnter(object sender, EventArgs e)
        {
            if (label1.Text != "?")
                return;
            Star1.Text = "★";
        }

        private void Star1_MouseLeave(object sender, EventArgs e)
        {
            if (label1.Text != "?")
                return;
            Star1.Text = "☆";
        }

        private void Star2_MouseEnter(object sender, EventArgs e)
        {
            if (label1.Text != "?")
                return;
            Star1.Text = "★";
            Star2.Text = "★";
        }

        private void Star2_MouseLeave(object sender, EventArgs e)
        {
            if (label1.Text != "?")
                return;
            Star1.Text = "☆";
            Star2.Text = "☆";
        }

        private void Star3_MouseEnter(object sender, EventArgs e)
        {
            if (label1.Text != "?")
                return;
            Star1.Text = "★";
            Star2.Text = "★";
            Star3.Text = "★";
        }

        private void Star3_MouseLeave(object sender, EventArgs e)
        {
            if (label1.Text != "?")
                return;
            Star1.Text = "☆";
            Star2.Text = "☆";
            Star3.Text = "☆";
        }

        private void Star4_MouseEnter(object sender, EventArgs e)
        {
            if (label1.Text != "?")
                return;
            Star1.Text = "★";
            Star2.Text = "★";
            Star3.Text = "★";
            Star4.Text = "★";
        }

        private void Star4_MouseLeave(object sender, EventArgs e)
        {
            if (label1.Text != "?")
                return;
            Star1.Text = "☆";
            Star2.Text = "☆";
            Star3.Text = "☆";
            Star4.Text = "☆";
        }


        private void Star5_MouseEnter(object sender, EventArgs e)
        {
            if (label1.Text != "?")
                return;
            Star1.Text = "★";
            Star2.Text = "★";
            Star3.Text = "★";
            Star4.Text = "★";
            Star5.Text = "★";
        }

        private void Star5_MouseLeave(object sender, EventArgs e)
        {
            if (label1.Text != "?")
                return;
            Star1.Text = "☆";
            Star2.Text = "☆";
            Star3.Text = "☆";
            Star4.Text = "☆";
            Star5.Text = "☆";
        }
        private void Star5_Click(object sender, EventArgs e)
        {
            label1.Text = "5";
            Star1.Text = "★";
            Star2.Text = "★";
            Star3.Text = "★";
            Star4.Text = "★";
            Star5.Text = "★";
        }

        private void Star4_Click(object sender, EventArgs e)
        {
            label1.Text = "4";
            Star1.Text = "★";
            Star2.Text = "★";
            Star3.Text = "★";
            Star4.Text = "★";
            Star5.Text = "☆";
        }

        private void Star3_Click(object sender, EventArgs e)
        {
            label1.Text = "3";
            Star1.Text = "★";
            Star2.Text = "★";
            Star3.Text = "★";
            Star4.Text = "☆";
            Star5.Text = "☆";
        }

        private void Star2_Click(object sender, EventArgs e)
        {
            label1.Text = "2";
            Star1.Text = "★";
            Star2.Text = "★";
            Star3.Text = "☆";
            Star4.Text = "☆";
            Star5.Text = "☆";
        }

        private void Star1_Click(object sender, EventArgs e)
        {
            label1.Text = "1";
            Star1.Text = "★";
            Star2.Text = "☆";
            Star3.Text = "☆";
            Star4.Text = "☆";
            Star5.Text = "☆";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text != "?")
            {
                Controller.SubmitReview(UserID, Int32.Parse(label1.Text), MovieID);
                this.Close();
            }
        }

        private void userReview_Load(object sender, EventArgs e)
        {

        }
    }
}
