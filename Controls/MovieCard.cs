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

        public MovieCard(DataRow data)
        {
            InitializeComponent();
            this.data = data;
        }

        private void MovieCard_Load(object sender, EventArgs e)
        {
            string picturePath = data.Field<string>("MoviePicturePath");
            if (picturePath != null)
                pictureBox1.Image = Image.FromFile(picturePath);

            lblTitle.Text = data.Field<string>("MovieName");
            lblDescription.Text = data.Field<string>("MovieDescription");
            lblRatingValue.Text = data.Field<string>("Rating");
            int value = (int)Math.Round(data.Field<decimal>("Rating"));
            lblRatingStars.Text = "";
            for (int i = 0; i < 5; i++)
            {
                value--;
                if (value > 0)
                    lblRatingStars.Text += "★";
                else
                    lblRatingStars.Text += "☆";
            }
        }

        private void MovieCard_BackColorChanged(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                c.BackColor = this.BackColor;
            }
        }
    }
}
