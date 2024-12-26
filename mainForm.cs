using Movie_Booking_System.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Movie_Booking_System
{
    public partial class mainForm : Form
    {
        //Standard Colors:
        public Color FormColor = Color.FromArgb(175, 236, 231);
        public Color FormSubTextColor = Color.Silver;
        public Color FormTextColor = Color.Black;
        public Color btnColor = Color.Gray;

        private Stack<Type> formStack = new Stack<Type>();
        private int currentUserID = -1;
        public userMode Authority = userMode.Guest;

        public int CurrentUserID
        {
            get { return currentUserID; }
            set { currentUserID = value; RefreshStatus(); }
        }
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            LoadNewForm(new Screens.userScreen(this, this.Authority),false);
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
            this.BackColor = form.BackColor;
            this.BackgroundImage = form.BackgroundImage;
            form.TopLevel = false;
            form.ControlBox = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            mainPanel.Controls.Add(form);
            form.Dock = DockStyle.Fill;
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
            ShowStatus();
            Form form = (Form)System.Activator.CreateInstance(formtype, this, this.Authority);
            LoadNewForm(form, false);
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            LoadNewForm(new Screens.loginScreen(this, this.Authority));
        }

        private void RefreshStatus()
        {
            if (currentUserID == -1)
            {
                btnStatus.Text = "Login";
                return;
            }
            DataTable dt = Controller.FetchUser(currentUserID);
            btnStatus.Text = dt.Rows[0].Field<string>("Fname") + " " + dt.Rows[0].Field<string>("Lname");
        }

        public void HideStatus()
        {
            btnStatus.Hide();
        }
        public void ShowStatus()
        {
            btnStatus.Show();
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
