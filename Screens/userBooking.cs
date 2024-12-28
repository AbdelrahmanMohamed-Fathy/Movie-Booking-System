using Movie_Booking_System.Controls.Booking;
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
                Controls.Booking.seat seat = new Controls.Booking.seat(dr.Field<int>("SeatNumber"));
                panelSeat.Controls.Add(seat);
            }
        }

        private void MarkTakenSeats(DataTable dt)
        {
            if (dt == null)
                return;
            foreach (Controls.Booking.seat C in panelSeat.Controls)
            {
                if (dt.AsEnumerable().Any(row => row.Field<int>("SeatNumber") == C.SeatNumber))
                    C.Status = ChairStatus.Taken;
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            List<int> SeatNumbers = new List<int>();
            foreach (Controls.Booking.seat C in panelSeat.Controls)
            {
                if (C.Status == ChairStatus.Selected)
                    SeatNumbers.Add(C.SeatNumber);
            }
            if (SeatNumbers.Any())
            {
                Controller.InsertBooking(parentForm.CurrentUserID, Convert.ToInt32(comboBox1.Text), SeatNumbers);

                int CinemaID = (int)comboBox1.SelectedValue;
                int ShowID;
                int.TryParse(comboBox1.Text, out ShowID);

                DrawSeats(Controller.GetAllSeats(CinemaID));
                MarkTakenSeats(Controller.GetTakenShowSeats(ShowID));
            }


        }
    }
}
