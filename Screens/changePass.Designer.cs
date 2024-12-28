namespace Movie_Booking_System.Screens
{
    partial class changePass
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(changePass));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.passlenlbl = new System.Windows.Forms.Label();
            this.specialcharlbl = new System.Windows.Forms.Label();
            this.numericvallbl = new System.Windows.Forms.Label();
            this.uppercaselbl = new System.Windows.Forms.Label();
            this.lowercaselbl = new System.Windows.Forms.Label();
            this.confirmpasslbl = new System.Windows.Forms.Label();
            this.visiblepass = new System.Windows.Forms.Label();
            this.passwordinvalid = new System.Windows.Forms.Label();
            this.txtbxConfirm = new Movie_Booking_System.Controls.PlaceHolderTextBox();
            this.txtbxNewPass = new Movie_Booking_System.Controls.PlaceHolderTextBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(67, 184);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 52);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Password";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // passlenlbl
            // 
            this.passlenlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passlenlbl.AutoSize = true;
            this.passlenlbl.BackColor = System.Drawing.Color.Transparent;
            this.passlenlbl.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlenlbl.ForeColor = System.Drawing.Color.Red;
            this.passlenlbl.Location = new System.Drawing.Point(446, 116);
            this.passlenlbl.Name = "passlenlbl";
            this.passlenlbl.Size = new System.Drawing.Size(223, 16);
            this.passlenlbl.TabIndex = 32;
            this.passlenlbl.Text = "• Password should be between 8-15 characters.\r\n";
            // 
            // specialcharlbl
            // 
            this.specialcharlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specialcharlbl.AutoSize = true;
            this.specialcharlbl.BackColor = System.Drawing.Color.Transparent;
            this.specialcharlbl.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialcharlbl.ForeColor = System.Drawing.Color.Red;
            this.specialcharlbl.Location = new System.Drawing.Point(446, 100);
            this.specialcharlbl.Name = "specialcharlbl";
            this.specialcharlbl.Size = new System.Drawing.Size(269, 16);
            this.specialcharlbl.TabIndex = 31;
            this.specialcharlbl.Text = "• Password should contain at least one special character.\r\n";
            // 
            // numericvallbl
            // 
            this.numericvallbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericvallbl.AutoSize = true;
            this.numericvallbl.BackColor = System.Drawing.Color.Transparent;
            this.numericvallbl.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericvallbl.ForeColor = System.Drawing.Color.Red;
            this.numericvallbl.Location = new System.Drawing.Point(446, 86);
            this.numericvallbl.Name = "numericvallbl";
            this.numericvallbl.Size = new System.Drawing.Size(258, 16);
            this.numericvallbl.TabIndex = 30;
            this.numericvallbl.Text = "• Password should contain at least one numeric value.\r\n";
            // 
            // uppercaselbl
            // 
            this.uppercaselbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uppercaselbl.AutoSize = true;
            this.uppercaselbl.BackColor = System.Drawing.Color.Transparent;
            this.uppercaselbl.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uppercaselbl.ForeColor = System.Drawing.Color.Red;
            this.uppercaselbl.Location = new System.Drawing.Point(447, 54);
            this.uppercaselbl.Name = "uppercaselbl";
            this.uppercaselbl.Size = new System.Drawing.Size(268, 16);
            this.uppercaselbl.TabIndex = 29;
            this.uppercaselbl.Text = "• Password should contain at least one upper case letter.\r\n";
            // 
            // lowercaselbl
            // 
            this.lowercaselbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lowercaselbl.AutoSize = true;
            this.lowercaselbl.BackColor = System.Drawing.Color.Transparent;
            this.lowercaselbl.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowercaselbl.ForeColor = System.Drawing.Color.Red;
            this.lowercaselbl.Location = new System.Drawing.Point(446, 70);
            this.lowercaselbl.Name = "lowercaselbl";
            this.lowercaselbl.Size = new System.Drawing.Size(267, 16);
            this.lowercaselbl.TabIndex = 28;
            this.lowercaselbl.Text = "• Password should contain at least one lower case letter.";
            // 
            // confirmpasslbl
            // 
            this.confirmpasslbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmpasslbl.AutoSize = true;
            this.confirmpasslbl.BackColor = System.Drawing.Color.Transparent;
            this.confirmpasslbl.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasslbl.ForeColor = System.Drawing.Color.Red;
            this.confirmpasslbl.Location = new System.Drawing.Point(36, 150);
            this.confirmpasslbl.Name = "confirmpasslbl";
            this.confirmpasslbl.Size = new System.Drawing.Size(142, 15);
            this.confirmpasslbl.TabIndex = 33;
            this.confirmpasslbl.Text = "Please confirm the Password!";
            this.confirmpasslbl.Visible = false;
            // 
            // visiblepass
            // 
            this.visiblepass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.visiblepass.BackColor = System.Drawing.Color.Transparent;
            this.visiblepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visiblepass.Image = ((System.Drawing.Image)(resources.GetObject("visiblepass.Image")));
            this.visiblepass.Location = new System.Drawing.Point(306, 54);
            this.visiblepass.Name = "visiblepass";
            this.visiblepass.Size = new System.Drawing.Size(28, 28);
            this.visiblepass.TabIndex = 34;
            this.visiblepass.Click += new System.EventHandler(this.visiblepass_Click);
            // 
            // passwordinvalid
            // 
            this.passwordinvalid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordinvalid.AutoSize = true;
            this.passwordinvalid.BackColor = System.Drawing.Color.Transparent;
            this.passwordinvalid.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordinvalid.ForeColor = System.Drawing.Color.Red;
            this.passwordinvalid.Location = new System.Drawing.Point(36, 86);
            this.passwordinvalid.Name = "passwordinvalid";
            this.passwordinvalid.Size = new System.Drawing.Size(123, 15);
            this.passwordinvalid.TabIndex = 35;
            this.passwordinvalid.Text = "Please Enter A Password!";
            this.passwordinvalid.Visible = false;
            // 
            // txtbxConfirm
            // 
            this.txtbxConfirm.AutoSize = true;
            this.txtbxConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxConfirm.Location = new System.Drawing.Point(25, 115);
            this.txtbxConfirm.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtbxConfirm.MaximumSize = new System.Drawing.Size(27200, 29);
            this.txtbxConfirm.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtbxConfirm.Name = "txtbxConfirm";
            this.txtbxConfirm.PlaceHolderText = "Confirm New Password";
            this.txtbxConfirm.PlaceHolderTextColor = System.Drawing.Color.Silver;
            this.txtbxConfirm.Size = new System.Drawing.Size(272, 29);
            this.txtbxConfirm.TabIndex = 1;
            this.txtbxConfirm.UseSystemPasswordChar = true;
            this.txtbxConfirm.TextChanged += new System.EventHandler(this.txtbxConfirm_TextChanged);
            // 
            // txtbxNewPass
            // 
            this.txtbxNewPass.AutoSize = true;
            this.txtbxNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxNewPass.Location = new System.Drawing.Point(25, 54);
            this.txtbxNewPass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtbxNewPass.MaximumSize = new System.Drawing.Size(27200, 29);
            this.txtbxNewPass.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtbxNewPass.Name = "txtbxNewPass";
            this.txtbxNewPass.PlaceHolderText = "New Password";
            this.txtbxNewPass.PlaceHolderTextColor = System.Drawing.Color.Silver;
            this.txtbxNewPass.Size = new System.Drawing.Size(272, 29);
            this.txtbxNewPass.TabIndex = 0;
            this.txtbxNewPass.UseSystemPasswordChar = true;
            this.txtbxNewPass.TextChanged += new System.EventHandler(this.txtbxNewPass_TextChanged);
            // 
            // changePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 264);
            this.Controls.Add(this.passwordinvalid);
            this.Controls.Add(this.visiblepass);
            this.Controls.Add(this.confirmpasslbl);
            this.Controls.Add(this.passlenlbl);
            this.Controls.Add(this.specialcharlbl);
            this.Controls.Add(this.numericvallbl);
            this.Controls.Add(this.uppercaselbl);
            this.Controls.Add(this.lowercaselbl);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtbxConfirm);
            this.Controls.Add(this.txtbxNewPass);
            this.Name = "changePass";
            this.Text = "changePass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.PlaceHolderTextBox txtbxNewPass;
        private Controls.PlaceHolderTextBox txtbxConfirm;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label passlenlbl;
        private System.Windows.Forms.Label specialcharlbl;
        private System.Windows.Forms.Label numericvallbl;
        private System.Windows.Forms.Label uppercaselbl;
        private System.Windows.Forms.Label lowercaselbl;
        private System.Windows.Forms.Label confirmpasslbl;
        private System.Windows.Forms.Label visiblepass;
        private System.Windows.Forms.Label passwordinvalid;
    }
}