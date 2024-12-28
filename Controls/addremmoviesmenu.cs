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
    public partial class addremmoviesmenu : UserControl
    {
        public addremmoviesmenu()
        {
            InitializeComponent();
            RefreshSources();
        }
        private void RefreshSources()
        {

            DataTable dt = Controller.GetOrders();
            datagridallmovies.DataSource = dt;
            cmbxMovieID.DataSource = dt;
            cmbxMovieID.DisplayMember = "MovieID";
            cmbxMovieID.SelectedIndex = -1;
            cmbxMovieID.Text = "Movie ID.";
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbxMovieName.Text))
            {
                MessageBox.Show("Please Insert the Movie Name for the Movie to be Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtbxdirector.Text))
            {
                MessageBox.Show("Please Insert the Movie Director for the Movie to be Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (string.IsNullOrEmpty(txtbxdesc.Text))
            {
                MessageBox.Show("Please Insert the Movie Description for the Movie to be Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //else if
            //{

            //}
        }

        private void btnRemMovie_Click(object sender, EventArgs e)
        {

        }

        private void datagridallmovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
