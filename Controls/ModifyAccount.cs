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
    public partial class ModifyAccount : UserControl
    {
        public ModifyAccount()
        {
            InitializeComponent();
            cmbxNewAuthority.Items.Add(HelperFunctions.ParseEnumToAuthority(userMode.Admin));
            cmbxNewAuthority.Items.Add(HelperFunctions.ParseEnumToAuthority(userMode.Employee));
            cmbxNewAuthority.Items.Add(HelperFunctions.ParseEnumToAuthority(userMode.User));
            RefreshSources();
        }
        private void RefreshSources()
        {

            DataTable dt = Controller.GetAllAccounts();
            datagridallaccounts.DataSource = dt;
            cmbxUserID.DataSource = dt;
            cmbxUserID.DisplayMember = "UserID";
            cmbxUserID.SelectedIndex = -1;
            cmbxUserID.Text = "User ID.";
            cmbxNewAuthority.DisplayMember = "Authority";
            cmbxNewAuthority.SelectedIndex = -1;
            cmbxNewAuthority.Text = "New Authority";
        }

        private void btnModifyAccount_Click(object sender, EventArgs e)
        {
            if(cmbxUserID.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a User. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (cmbxNewAuthority.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select the New Authority. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                MessageBox.Show("Are you sure you want to update the authority of this User with ID = " + cmbxUserID.Text + " ? ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                Controller.UpdateAuthority(Convert.ToInt32(cmbxUserID.Text),cmbxNewAuthority.Text);
                RefreshSources();

            }
        }
    }
}
