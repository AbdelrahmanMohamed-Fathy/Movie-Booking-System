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

        private Stack<Type> formStack = new Stack<Type>();
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.FlatAppearance.BorderSize = 0;
            LoadNewForm(new Screens.loginScreen(this),false);
        }

        public void LoadNewForm(Form f , bool store = true)
        {
            if (store)
                formStack.Push(mainPanel.Controls[0].GetType());

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

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            if (!formStack.Any())
                return;

            Type formtype = formStack.Pop();
            Form form = (Form)System.Activator.CreateInstance(formtype, this);
            LoadNewForm(form, false);

        }
    }
}
