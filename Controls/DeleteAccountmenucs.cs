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
    public partial class DeleteAccountmenucs : UserControl
    {
        private int currentuserid;
        public DeleteAccountmenucs(int UserID)
        {
            InitializeComponent();
            currentuserid = UserID;
            RefreshSources();
            
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            if (cmbxUserID.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select the User ID for the Account to be Deleted","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            else
            {
                int userid = Convert.ToInt32(cmbxUserID.Text);
                if (currentuserid == userid)
                {
                    MessageBox.Show("BRO YOU ARE DELETING YOURSELF? ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Are you sure you want to delete this User with ID = " + cmbxUserID.Text + " ? ", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    Controller.DeleteAccount(Convert.ToInt32(cmbxUserID.Text));
                    RefreshSources();
                }

            }
        }
        private void RefreshSources()
        {
            
            DataTable dt = Controller.GetAllAccounts();
            datagridallaccounts.DataSource = dt;
            cmbxUserID.DataSource = dt;
            cmbxUserID.DisplayMember = "UserID";
            cmbxUserID.SelectedIndex = -1;
            cmbxUserID.Text = "User ID.";
        }
    }
}
