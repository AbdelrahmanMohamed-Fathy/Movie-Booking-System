using System;
using System.Drawing;
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

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter Movie Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
                textBox1.Font =new Font(textBox1.Font,FontStyle.Regular);
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = "Enter Movie Name";
                textBox1.ForeColor = Color.Silver;
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {

        }
    }
}
