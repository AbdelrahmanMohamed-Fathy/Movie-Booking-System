namespace Movie_Booking_System.Controls
{
    partial class DeleteAccountmenucs
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
            this.cmbxUserID = new System.Windows.Forms.ComboBox();
            this.datagridallaccounts = new System.Windows.Forms.DataGridView();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridallaccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbxUserID
            // 
            this.cmbxUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbxUserID.BackColor = System.Drawing.Color.MintCream;
            this.cmbxUserID.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxUserID.ForeColor = System.Drawing.Color.Gray;
            this.cmbxUserID.FormattingEnabled = true;
            this.cmbxUserID.Location = new System.Drawing.Point(3, 62);
            this.cmbxUserID.Name = "cmbxUserID";
            this.cmbxUserID.Size = new System.Drawing.Size(169, 36);
            this.cmbxUserID.TabIndex = 0;
            this.cmbxUserID.Text = "User ID.";
            // 
            // datagridallaccounts
            // 
            this.datagridallaccounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.datagridallaccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridallaccounts.Dock = System.Windows.Forms.DockStyle.Right;
            this.datagridallaccounts.GridColor = System.Drawing.Color.Teal;
            this.datagridallaccounts.Location = new System.Drawing.Point(178, 0);
            this.datagridallaccounts.Name = "datagridallaccounts";
            this.datagridallaccounts.RowHeadersWidth = 51;
            this.datagridallaccounts.RowTemplate.Height = 24;
            this.datagridallaccounts.Size = new System.Drawing.Size(476, 587);
            this.datagridallaccounts.TabIndex = 1;
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteAccount.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccount.ForeColor = System.Drawing.Color.Teal;
            this.btnDeleteAccount.Location = new System.Drawing.Point(3, 370);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(171, 60);
            this.btnDeleteAccount.TabIndex = 6;
            this.btnDeleteAccount.Text = "Delete Account.";
            this.btnDeleteAccount.UseVisualStyleBackColor = false;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // DeleteAccountmenucs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.btnDeleteAccount);
            this.Controls.Add(this.datagridallaccounts);
            this.Controls.Add(this.cmbxUserID);
            this.Name = "DeleteAccountmenucs";
            this.Size = new System.Drawing.Size(654, 587);
            ((System.ComponentModel.ISupportInitialize)(this.datagridallaccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbxUserID;
        private System.Windows.Forms.DataGridView datagridallaccounts;
        private System.Windows.Forms.Button btnDeleteAccount;
    }
}
