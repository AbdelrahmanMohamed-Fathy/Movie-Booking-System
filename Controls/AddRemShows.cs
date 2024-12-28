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

namespace Movie_Booking_System.Controls
{
    public partial class AddRemShows : UserControl
    {
        public AddRemShows()
        {
            InitializeComponent();
            RefreshSources();
        }
        private void RefreshSources()
        {
            DataTable dt = Controller.GetAllShows();
            datagridshows.DataSource = dt;
        }

        private void txtbxdirector_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblfooddesc_Click(object sender, EventArgs e)
        {

        }

        private void txtbxdesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddShow_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtbxMovieName.Text))
            {
                MessageBox.Show("Please Insert the Movie Name for the Show to be Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtbxcinematype.Text))
            {
                MessageBox.Show("Please Insert the Cinema Type for the Show to be Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtboxstart.Text))
            {
                MessageBox.Show("Please Insert the Start Time for the Show to be Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                
            }
        }

        private void btnRemShow_Click(object sender, EventArgs e)
        {

        }

        private void txtbxMovieName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblruntime_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbxMovieID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
