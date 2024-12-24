using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Movie_Booking_System
{
    public partial class mainForm : Form
    {
        //Standard Colors:
        public Color FormColor = Color.White;
        public Color FormSubTextColor = Color.Silver;
        public Color FormTextColor = Color.Black;
        public Color btnColor = Color.Gray;

        private Stack<Type> formStack = new Stack<Type>();
        public userMode Authority = userMode.Guest;
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            btnGoBack.FlatStyle = FlatStyle.Flat;
            btnGoBack.BackColor = FormColor;
            LoadNewForm(new Screens.loginScreen(this, this.Authority),false);
        }

        /// <summary>
        /// This method loads forms onto the main form elegantly.
        /// <example>
        /// For example:
        /// <code>
        /// LoadNewForm(new Screens.loginScreen(this, this.Authority));
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="form">
        /// The form to be loaded
        /// </param>
        /// <param name="store"> 
        /// This specificies whether or not this form should be stored for the back button
        /// however you shouldn't this change from the default unless you know what you're doing
        /// </param>
        public void LoadNewForm(Form form , bool store = true)
        {
            if (store)
                formStack.Push(mainPanel.Controls[0].GetType());

            CleanUp();
            form.TopLevel = false;
            form.ControlBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.Controls.Add(form);
            form.Show();
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
            Form form = (Form)System.Activator.CreateInstance(formtype, this, this.Authority);
            LoadNewForm(form, false);
        }

        private void metroProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
    public enum userMode
    {
        Guest,
        User,
        Employee,
        Admin
    }
}
