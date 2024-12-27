using Movie_Booking_System.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Booking_System.Controls
{
    public partial class MovieCard : UserControl
    {
        private DataRow data;
        private mainForm parentForm;
        private int MovieID;
        public MovieCard(mainForm parent,DataRow data)
        {
            InitializeComponent();
            this.data = data;
            this.parentForm = parent;
        }

        private void MovieCard_Load(object sender, EventArgs e)
        {
            string picturePath = data.Field<string>("MoviePicturePath");
            try
            {
                pictureBox1.Image = Image.FromFile(picturePath);
            }
            catch (Exception E)
            {
                pictureBox1.Image = pictureBox1.ErrorImage;
            }
            MovieID = data.Field<int>("MovieID");
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
            foreach (Control C in this.Controls)
            {
                C.Click += new EventHandler(MovieCard_Click);
            }
        }

        private void MovieCard_BackColorChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                c.BackColor = this.BackColor;
            }
        }

        private void MovieCard_Click(object sender, EventArgs e)
        {
            parentForm.LoadNewForm(new Screens.MovieDetailes(parentForm,parentForm.Authority,MovieID));
        }
    }
}
