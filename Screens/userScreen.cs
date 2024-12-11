using System;
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
    }
}
