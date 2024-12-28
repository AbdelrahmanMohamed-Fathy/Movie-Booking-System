using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Booking_System.Controls.Booking
{
    public partial class seat : UserControl
    {
        private ChairStatus status;
        private int seatNumber;

        [Browsable(true)]
        [Category("Appearance")]
        [System.ComponentModel.DefaultValue(ChairStatus.Available)]
        public ChairStatus Status
        {
            get { return status; }
            set { status = value; RefreshAppearance(); }
        }

        [Browsable(false)]
        public int SeatNumber
        {
            get { return seatNumber; }
            set { seatNumber = value; label1.Text = value.ToString(); }
        }

        public seat()
        {
            InitializeComponent();
            status = ChairStatus.Available;
        }

        public seat(ChairStatus status)
        {
            InitializeComponent();
            this.status = status;
        }

        private void RefreshAppearance()
        {
            string ImageFile;
            switch (status)
            {
                default:
                case ChairStatus.Available:
                    ImageFile = "chair_green.png";
                    break;
                case ChairStatus.Selected:
                    ImageFile = "chair_yellow.png";
                    break;
                case ChairStatus.Taken:
                    ImageFile = "chair_red.png";
                    break;
            }
            this.BackgroundImage = Image.FromFile("..\\..\\Assets\\" + ImageFile);
        }

        public enum ChairStatus
        {
            Available,
            Selected,
            Taken
        }
    }
}
