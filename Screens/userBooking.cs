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
using static Movie_Booking_System.Controls.Booking.seat;

namespace Movie_Booking_System.Screens
{
    public partial class userBooking : Form
    {
        private mainForm parentForm;
        private int MovieID;
        public userBooking(mainForm parent, userMode mode, int MovieID)
        {
            InitializeComponent();
            this.parentForm = parent;
            this.MovieID = MovieID;
        }

        private void userBooking_Load(object sender, EventArgs e)
        {
            DataTable dt = Controller.GetShowTimesFull(MovieID);
            dataGridView1.DataSource = dt;
            comboBox1.DisplayMember = "ShowID";
            comboBox1.ValueMember = "CinemaID";
            comboBox1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RePopulateSeats();
        }

        private void RePopulateSeats()
        {
            int CinemaID = (int)comboBox1.SelectedValue;
            //int.TryParse(, out CinemaID);
            int ShowID;
            int.TryParse(comboBox1.Text, out ShowID);

            DrawSeats(Controller.GetAllSeats(CinemaID));
            MarkTakenSeats(Controller.GetTakenShowSeats(ShowID));
        }

        private void DrawSeats(DataTable dt)
        {
            if (dt == null)
                return;
            panelSeat.Controls.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                panelSeat.Controls.Add(new Controls.Booking.seat(dr.Field<int>("SeatNumber")));
            }
        }

        private void MarkTakenSeats(DataTable dt)
        {
            if (dt == null)
                return;
            foreach (Controls.Booking.seat C in panelSeat.Controls)
            {
                if (dt.Rows.Contains(C.SeatNumber))
                    C.Status = ChairStatus.Taken;
            }
        }


    }
}
