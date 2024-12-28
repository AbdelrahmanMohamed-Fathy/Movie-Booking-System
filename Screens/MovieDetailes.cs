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
    public partial class MovieDetailes : Form
    {
        private mainForm parentForm;
        private int MovieID;
        public MovieDetailes(mainForm parent,userMode mode,int MovieID)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.MovieID = MovieID;
        }

        private void MovieDetailes_Load(object sender, EventArgs e)
        {
            DataTable dt = Controller.GetMovie(this.MovieID);
            dataGridView1.DataSource = Controller.GetShowTimes(this.MovieID);

            DataRow data = dt.Rows[0];
            string picturePath = data.Field<string>("MoviePicturePath");
            try
            {
                pictureBox1.Image = Image.FromFile(picturePath);
            }
            catch (Exception E)
            {
                pictureBox1.Image = pictureBox1.ErrorImage;
            }
            lblTitle.Text = data.Field<string>("MovieName");
            lblDescription.Text = data.Field<string>("MovieDescription");
            int value = Controller.GetMovieReviews(MovieID);
            lblRatingValue.Text = value.ToString();
            lblRatingStars.Text = "";
            for (int i = 0; i < 5; i++)
            {
                if (value > 0)
                    lblRatingStars.Text += "★";
                else
                    lblRatingStars.Text += "☆";
                value--;
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (parentForm.Authority == userMode.Guest)
                parentForm.LoadNewForm(new loginScreen(parentForm, parentForm.Authority), false);
            else
                parentForm.LoadNewForm(new userBooking(parentForm, parentForm.Authority), false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userReview userRev;
            if (parentForm.Authority == userMode.Guest)
                parentForm.LoadNewForm(new loginScreen(parentForm, parentForm.Authority), false);
            else
            {
                userRev = new userReview(MovieID, parentForm.CurrentUserID);
                userRev.Show();
            }
        }
    }
}
