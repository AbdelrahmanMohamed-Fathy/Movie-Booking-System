using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movie_Booking_System
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            LoadNewForm(new Screens.loginScreen(this));
        }

        public void LoadNewForm(Form f)
        {
            CleanUp();
            f.TopLevel = false;
            f.ControlBox = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.Controls.Add(f);
            f.Show();
        }

        private void CleanUp()
        {
            foreach (Control c in mainPanel.Controls)
                c.Dispose();
            mainPanel.Controls.Clear();
        }
    }
}
