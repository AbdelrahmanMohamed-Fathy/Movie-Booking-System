﻿using System;
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
    }


    public enum userMode
    {
        Guest,
        User,
        Employee,
        Admin
    }
}
