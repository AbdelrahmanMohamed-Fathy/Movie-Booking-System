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
    public partial class ManageCinemasControl : UserControl
    {
        public ManageCinemasControl()
        {
            InitializeComponent();
        }

        private void btnAddRemMovies_Click(object sender, EventArgs e)
        {
            Controls.addremmoviesmenu addremmoviemen = new Controls.addremseatsmenu();
            this.Controls.Clear();
            this.Controls.Add(addremmoviemen);
            addremmoviemen.Dock = DockStyle.Fill;
        }

        private void btnAddRemCinemas_Click(object sender, EventArgs e)
        {
            Controls.AddRemcinemamenu addremcinemamenu = new Controls.AddRemcinemamenu();
            this.Controls.Clear();
            this.Controls.Add(addremcinemamenu);
            addremcinemamenu.Dock = DockStyle.Fill;
        }

        private void btnAddRemShows_Click(object sender, EventArgs e)
        {
            Controls.AddAccountmenu addaccmen = new Controls.AddAccountmenu();
            this.Controls.Clear();
            this.Controls.Add(addaccmen);
            addaccmen.Dock = DockStyle.Fill;
        }

        private void btnAddRemSeats_Click(object sender, EventArgs e)
        {
            Controls.AddAccountmenu addaccmen = new Controls.AddAccountmenu();
            this.Controls.Clear();
            this.Controls.Add(addaccmen);
            addaccmen.Dock = DockStyle.Fill;
        }
    }
}
