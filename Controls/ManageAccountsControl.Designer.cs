namespace Movie_Booking_System.Controls
{
    partial class ManageAccountsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnModifyAccounts = new System.Windows.Forms.Button();
            this.btnViewReports = new System.Windows.Forms.Button();
            this.btnAddAccountAdmin = new System.Windows.Forms.Button();
            this.panelmngacc = new System.Windows.Forms.Panel();
            this.panelmngacc.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.Teal;
            this.btnDeleteAccount.Location = new System.Drawing.Point(12, 178);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(171, 60);
            this.btnDeleteAccount.TabIndex = 5;
            this.btnDeleteAccount.Text = "Delete Accounts.";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnModifyAccounts
            // 
            this.btnModifyAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyAccounts.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyAccounts.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyAccounts.ForeColor = System.Drawing.Color.Teal;
            this.btnModifyAccounts.Location = new System.Drawing.Point(12, 244);
            this.btnModifyAccounts.Name = "btnModifyAccounts";
            this.btnModifyAccounts.Size = new System.Drawing.Size(171, 61);
            this.btnModifyAccounts.TabIndex = 6;
            this.btnModifyAccounts.Text = "Modify Accounts.";
            this.btnModifyAccounts.UseVisualStyleBackColor = false;
            // 
            // btnViewReports
            // 
            this.btnViewReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewReports.BackColor = System.Drawing.Color.Transparent;
            this.btnViewReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewReports.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewReports.ForeColor = System.Drawing.Color.Teal;
            this.btnViewReports.Location = new System.Drawing.Point(12, 311);
            this.btnViewReports.Name = "btnViewReports";
            this.btnViewReports.Size = new System.Drawing.Size(171, 62);
            this.btnViewReports.TabIndex = 7;
            this.btnViewReports.Text = "View Reports.";
            this.btnViewReports.UseVisualStyleBackColor = false;
            // 
            // btnAddAccountAdmin
            // 
            this.btnAddAccountAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddAccountAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAccountAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccountAdmin.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccountAdmin.ForeColor = System.Drawing.Color.Teal;
            this.btnAddAccountAdmin.Location = new System.Drawing.Point(12, 113);
            this.btnAddAccountAdmin.Name = "btnAddAccountAdmin";
            this.btnAddAccountAdmin.Size = new System.Drawing.Size(171, 59);
            this.btnAddAccountAdmin.TabIndex = 4;
            this.btnAddAccountAdmin.Text = "Add Accounts.";
            this.btnAddAccountAdmin.UseVisualStyleBackColor = false;
            this.btnAddAccountAdmin.Click += new System.EventHandler(this.btnAddAccountAdmin_Click_1);
            // 
            // panelmngacc
            // 
            this.panelmngacc.BackColor = System.Drawing.Color.Transparent;
            this.panelmngacc.Controls.Add(this.btnAddAccountAdmin);
            this.panelmngacc.Controls.Add(this.btnViewReports);
            this.panelmngacc.Controls.Add(this.btnModifyAccounts);
            this.panelmngacc.Controls.Add(this.btnDeleteAccount);
            this.panelmngacc.Location = new System.Drawing.Point(0, 120);
            this.panelmngacc.Name = "panelmngacc";
            this.panelmngacc.Size = new System.Drawing.Size(250, 500);
            this.panelmngacc.TabIndex = 4;
            // 
            // ManageAccountsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panelmngacc);
            this.Name = "ManageAccountsControl";
            this.Size = new System.Drawing.Size(530, 767);
            this.panelmngacc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnModifyAccounts;
        private System.Windows.Forms.Button btnViewReports;
        private System.Windows.Forms.Button btnAddAccountAdmin;
        private System.Windows.Forms.Panel panelmngacc;
    }
}
