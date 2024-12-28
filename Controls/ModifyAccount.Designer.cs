namespace Movie_Booking_System.Controls
{
    partial class ModifyAccount
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
            this.btnModifyAccount = new System.Windows.Forms.Button();
            this.datagridallaccounts = new System.Windows.Forms.DataGridView();
            this.cmbxUserID = new System.Windows.Forms.ComboBox();
            this.cmbxNewAuthority = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridallaccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifyAccount
            // 
            this.btnModifyAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModifyAccount.BackColor = System.Drawing.Color.Transparent;
            this.btnModifyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyAccount.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifyAccount.ForeColor = System.Drawing.Color.Teal;
            this.btnModifyAccount.Location = new System.Drawing.Point(121, 382);
            this.btnModifyAccount.Name = "btnModifyAccount";
            this.btnModifyAccount.Size = new System.Drawing.Size(171, 60);
            this.btnModifyAccount.TabIndex = 9;
            this.btnModifyAccount.Text = "Modify Account.";
            this.btnModifyAccount.UseVisualStyleBackColor = false;
            this.btnModifyAccount.Click += new System.EventHandler(this.btnModifyAccount_Click);
            // 
            // datagridallaccounts
            // 
            this.datagridallaccounts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.datagridallaccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridallaccounts.Dock = System.Windows.Forms.DockStyle.Right;
            this.datagridallaccounts.GridColor = System.Drawing.Color.Teal;
            this.datagridallaccounts.Location = new System.Drawing.Point(379, 0);
            this.datagridallaccounts.Name = "datagridallaccounts";
            this.datagridallaccounts.RowHeadersWidth = 51;
            this.datagridallaccounts.RowTemplate.Height = 24;
            this.datagridallaccounts.Size = new System.Drawing.Size(427, 723);
            this.datagridallaccounts.TabIndex = 8;
            // 
            // cmbxUserID
            // 
            this.cmbxUserID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbxUserID.BackColor = System.Drawing.Color.MintCream;
            this.cmbxUserID.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxUserID.ForeColor = System.Drawing.Color.Gray;
            this.cmbxUserID.FormattingEnabled = true;
            this.cmbxUserID.Location = new System.Drawing.Point(14, 62);
            this.cmbxUserID.Name = "cmbxUserID";
            this.cmbxUserID.Size = new System.Drawing.Size(169, 36);
            this.cmbxUserID.TabIndex = 7;
            this.cmbxUserID.Text = "User ID.";
            // 
            // cmbxNewAuthority
            // 
            this.cmbxNewAuthority.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbxNewAuthority.BackColor = System.Drawing.Color.MintCream;
            this.cmbxNewAuthority.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxNewAuthority.ForeColor = System.Drawing.Color.Gray;
            this.cmbxNewAuthority.FormattingEnabled = true;
            this.cmbxNewAuthority.Location = new System.Drawing.Point(204, 62);
            this.cmbxNewAuthority.Name = "cmbxNewAuthority";
            this.cmbxNewAuthority.Size = new System.Drawing.Size(169, 36);
            this.cmbxNewAuthority.TabIndex = 10;
            this.cmbxNewAuthority.Text = "New Authority.";
            // 
            // ModifyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.cmbxNewAuthority);
            this.Controls.Add(this.btnModifyAccount);
            this.Controls.Add(this.datagridallaccounts);
            this.Controls.Add(this.cmbxUserID);
            this.Name = "ModifyAccount";
            this.Size = new System.Drawing.Size(806, 723);
            ((System.ComponentModel.ISupportInitialize)(this.datagridallaccounts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifyAccount;
        private System.Windows.Forms.DataGridView datagridallaccounts;
        private System.Windows.Forms.ComboBox cmbxUserID;
        private System.Windows.Forms.ComboBox cmbxNewAuthority;
    }
}
