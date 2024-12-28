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

            DataTable dt = Controller.showallMovies();
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
                return;

            }
            else if (string.IsNullOrEmpty(txtbxdirector.Text))
            {
                MessageBox.Show("Please Insert the Movie Director for the Movie to be Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (string.IsNullOrEmpty(txtbxdesc.Text))
            {
                MessageBox.Show("Please Insert the Movie Description for the Movie to be Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if(string.IsNullOrEmpty(lblruntime.Text))
            {
                MessageBox.Show("Please Insert the Movie Runtime for the Movie to be Added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                Controller.AddMovie(txtbxMovieName.Text, txtbxdirector.Text, Convert.ToDateTime(lblruntime.Text), txtbxdesc.Text);
                RefreshSources();
            }
        }

        private void btnRemMovie_Click(object sender, EventArgs e)
        {
            if (cmbxMovieID.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select the Movie ID for the Movie to be Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete this Movie with ID = " + cmbxMovieID.Text + " ? ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) 
                {
                    Controller.DeleteMovie(Convert.ToInt32(cmbxMovieID.Text));
                    RefreshSources();
                }
                else
                {
                    return;
                }

            }
        }

        private void datagridallmovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
