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

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (parentForm.Authority == userMode.Guest)
                parentForm.LoadNewForm(new loginScreen(parentForm,parentForm.Authority), false);
        }
    }
}
