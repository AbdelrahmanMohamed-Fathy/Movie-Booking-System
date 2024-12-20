namespace Movie_Booking_System.Screens
{
    partial class NewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewUser));
            this.Fname = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.phonenum = new System.Windows.Forms.TextBox();
            this.Createaccclk = new System.Windows.Forms.Button();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.fnameinvalid = new System.Windows.Forms.Label();
            this.lnameinvalid = new System.Windows.Forms.Label();
            this.emailinvalid = new System.Windows.Forms.Label();
            this.passwordinvalid = new System.Windows.Forms.Label();
            this.passstatuslbl = new System.Windows.Forms.Label();
            this.confirmpass = new System.Windows.Forms.TextBox();
            this.confirmpasslbl = new System.Windows.Forms.Label();
            this.visiblepass = new System.Windows.Forms.Label();
            this.visibleconfpass = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lowercaselbl = new System.Windows.Forms.Label();
            this.uppercaselbl = new System.Windows.Forms.Label();
            this.numericvallbl = new System.Windows.Forms.Label();
            this.specialcharlbl = new System.Windows.Forms.Label();
            this.passlenlbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Fname
            // 
            this.Fname.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.ForeColor = System.Drawing.Color.Silver;
            this.Fname.Location = new System.Drawing.Point(88, 60);
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(300, 34);
            this.Fname.TabIndex = 0;
            this.Fname.Text = "First Name";
            this.Fname.TextChanged += new System.EventHandler(this.Fname_TextChanged);
            this.Fname.Enter += new System.EventHandler(this.Fname_Enter);
            this.Fname.Leave += new System.EventHandler(this.Fname_Leave);
            // 
            // Lname
            // 
            this.Lname.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.ForeColor = System.Drawing.Color.Silver;
            this.Lname.Location = new System.Drawing.Point(88, 133);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(300, 34);
            this.Lname.TabIndex = 1;
            this.Lname.Text = "Last Name";
            this.Lname.TextChanged += new System.EventHandler(this.Lname_TextChanged);
            this.Lname.Enter += new System.EventHandler(this.Lname_Enter);
            this.Lname.Leave += new System.EventHandler(this.Lname_Leave);
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Silver;
            this.Email.Location = new System.Drawing.Point(88, 207);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(300, 34);
            this.Email.TabIndex = 2;
            this.Email.Text = "Email Address";
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            this.Email.Enter += new System.EventHandler(this.Email_Enter);
            this.Email.Leave += new System.EventHandler(this.Email_Leave);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Silver;
            this.password.Location = new System.Drawing.Point(88, 280);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(300, 34);
            this.password.TabIndex = 3;
            this.password.Text = "Password";
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // phonenum
            // 
            this.phonenum.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenum.ForeColor = System.Drawing.Color.Silver;
            this.phonenum.Location = new System.Drawing.Point(489, 207);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(300, 34);
            this.phonenum.TabIndex = 4;
            this.phonenum.Text = "Phone Number (Optional)";
            this.phonenum.Enter += new System.EventHandler(this.phonenum_Enter);
            this.phonenum.Leave += new System.EventHandler(this.phonenum_Leave);
            // 
            // Createaccclk
            // 
            this.Createaccclk.BackColor = System.Drawing.Color.Gray;
            this.Createaccclk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Createaccclk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Createaccclk.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createaccclk.ForeColor = System.Drawing.Color.Azure;
            this.Createaccclk.Location = new System.Drawing.Point(88, 485);
            this.Createaccclk.Name = "Createaccclk";
            this.Createaccclk.Size = new System.Drawing.Size(197, 56);
            this.Createaccclk.TabIndex = 5;
            this.Createaccclk.Text = "Create Account";
            this.Createaccclk.UseVisualStyleBackColor = false;
            this.Createaccclk.Click += new System.EventHandler(this.createacc_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // fnameinvalid
            // 
            this.fnameinvalid.AutoSize = true;
            this.fnameinvalid.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameinvalid.ForeColor = System.Drawing.Color.Red;
            this.fnameinvalid.Location = new System.Drawing.Point(88, 101);
            this.fnameinvalid.Name = "fnameinvalid";
            this.fnameinvalid.Size = new System.Drawing.Size(135, 16);
            this.fnameinvalid.TabIndex = 6;
            this.fnameinvalid.Text = "Please Enter First Name!";
            this.fnameinvalid.Visible = false;
            // 
            // lnameinvalid
            // 
            this.lnameinvalid.AutoSize = true;
            this.lnameinvalid.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameinvalid.ForeColor = System.Drawing.Color.Red;
            this.lnameinvalid.Location = new System.Drawing.Point(88, 174);
            this.lnameinvalid.Name = "lnameinvalid";
            this.lnameinvalid.Size = new System.Drawing.Size(134, 16);
            this.lnameinvalid.TabIndex = 7;
            this.lnameinvalid.Text = "Please Enter Last Name!";
            this.lnameinvalid.Visible = false;
            // 
            // emailinvalid
            // 
            this.emailinvalid.AutoSize = true;
            this.emailinvalid.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailinvalid.ForeColor = System.Drawing.Color.Red;
            this.emailinvalid.Location = new System.Drawing.Point(91, 248);
            this.emailinvalid.Name = "emailinvalid";
            this.emailinvalid.Size = new System.Drawing.Size(192, 16);
            this.emailinvalid.TabIndex = 8;
            this.emailinvalid.Text = "Please Enter A Valid Email Address!";
            this.emailinvalid.Visible = false;
            // 
            // passwordinvalid
            // 
            this.passwordinvalid.AutoSize = true;
            this.passwordinvalid.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordinvalid.ForeColor = System.Drawing.Color.Red;
            this.passwordinvalid.Location = new System.Drawing.Point(88, 346);
            this.passwordinvalid.Name = "passwordinvalid";
            this.passwordinvalid.Size = new System.Drawing.Size(140, 16);
            this.passwordinvalid.TabIndex = 9;
            this.passwordinvalid.Text = "Please Enter A Password!";
            this.passwordinvalid.Visible = false;
            // 
            // passstatuslbl
            // 
            this.passstatuslbl.AutoSize = true;
            this.passstatuslbl.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passstatuslbl.Location = new System.Drawing.Point(389, 321);
            this.passstatuslbl.Name = "passstatuslbl";
            this.passstatuslbl.Size = new System.Drawing.Size(43, 16);
            this.passstatuslbl.TabIndex = 11;
            this.passstatuslbl.Text = "Weak";
            this.passstatuslbl.Visible = false;
            // 
            // confirmpass
            // 
            this.confirmpass.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpass.ForeColor = System.Drawing.Color.Silver;
            this.confirmpass.Location = new System.Drawing.Point(489, 280);
            this.confirmpass.Name = "confirmpass";
            this.confirmpass.Size = new System.Drawing.Size(300, 34);
            this.confirmpass.TabIndex = 12;
            this.confirmpass.Text = "Confirm Password";
            this.confirmpass.TextChanged += new System.EventHandler(this.confirmpass_TextChanged);
            this.confirmpass.Enter += new System.EventHandler(this.confirmpass_Enter);
            this.confirmpass.Leave += new System.EventHandler(this.confirmpass_Leave);
            // 
            // confirmpasslbl
            // 
            this.confirmpasslbl.AutoSize = true;
            this.confirmpasslbl.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasslbl.Location = new System.Drawing.Point(486, 321);
            this.confirmpasslbl.Name = "confirmpasslbl";
            this.confirmpasslbl.Size = new System.Drawing.Size(162, 16);
            this.confirmpasslbl.TabIndex = 13;
            this.confirmpasslbl.Text = "Please confirm the Password!";
            this.confirmpasslbl.Visible = false;
            // 
            // visiblepass
            // 
            this.visiblepass.Image = ((System.Drawing.Image)(resources.GetObject("visiblepass.Image")));
            this.visiblepass.Location = new System.Drawing.Point(394, 280);
            this.visiblepass.Name = "visiblepass";
            this.visiblepass.Size = new System.Drawing.Size(38, 34);
            this.visiblepass.TabIndex = 15;
            this.visiblepass.Click += new System.EventHandler(this.label3_Click);
            // 
            // visibleconfpass
            // 
            this.visibleconfpass.Image = ((System.Drawing.Image)(resources.GetObject("visibleconfpass.Image")));
            this.visibleconfpass.Location = new System.Drawing.Point(795, 280);
            this.visibleconfpass.Name = "visibleconfpass";
            this.visibleconfpass.Size = new System.Drawing.Size(38, 34);
            this.visibleconfpass.TabIndex = 16;
            this.visibleconfpass.Click += new System.EventHandler(this.visibleconfpass_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(88, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 15);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(162, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 15);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(236, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 15);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(310, 322);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 15);
            this.panel4.TabIndex = 22;
            // 
            // lowercaselbl
            // 
            this.lowercaselbl.AutoSize = true;
            this.lowercaselbl.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowercaselbl.Location = new System.Drawing.Point(84, 371);
            this.lowercaselbl.Name = "lowercaselbl";
            this.lowercaselbl.Size = new System.Drawing.Size(346, 20);
            this.lowercaselbl.TabIndex = 23;
            this.lowercaselbl.Text = "• Password should contain at least one lower case letter.";
            // 
            // uppercaselbl
            // 
            this.uppercaselbl.AutoSize = true;
            this.uppercaselbl.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uppercaselbl.Location = new System.Drawing.Point(84, 393);
            this.uppercaselbl.Name = "uppercaselbl";
            this.uppercaselbl.Size = new System.Drawing.Size(349, 20);
            this.uppercaselbl.TabIndex = 24;
            this.uppercaselbl.Text = "• Password should contain at least one upper case letter.\r\n";
            // 
            // numericvallbl
            // 
            this.numericvallbl.AutoSize = true;
            this.numericvallbl.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericvallbl.Location = new System.Drawing.Point(84, 415);
            this.numericvallbl.Name = "numericvallbl";
            this.numericvallbl.Size = new System.Drawing.Size(334, 20);
            this.numericvallbl.TabIndex = 25;
            this.numericvallbl.Text = "• Password should contain at least one numeric value.\r\n";
            // 
            // specialcharlbl
            // 
            this.specialcharlbl.AutoSize = true;
            this.specialcharlbl.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialcharlbl.Location = new System.Drawing.Point(84, 437);
            this.specialcharlbl.Name = "specialcharlbl";
            this.specialcharlbl.Size = new System.Drawing.Size(352, 20);
            this.specialcharlbl.TabIndex = 26;
            this.specialcharlbl.Text = "• Password should contain at least one special character.\r\n";
            // 
            // passlenlbl
            // 
            this.passlenlbl.AutoSize = true;
            this.passlenlbl.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlenlbl.Location = new System.Drawing.Point(84, 459);
            this.passlenlbl.Name = "passlenlbl";
            this.passlenlbl.Size = new System.Drawing.Size(290, 20);
            this.passlenlbl.TabIndex = 27;
            this.passlenlbl.Text = "• Password should be between 8-15 characters.\r\n";
            // 
            // NewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 553);
            this.Controls.Add(this.passlenlbl);
            this.Controls.Add(this.specialcharlbl);
            this.Controls.Add(this.numericvallbl);
            this.Controls.Add(this.uppercaselbl);
            this.Controls.Add(this.lowercaselbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.visibleconfpass);
            this.Controls.Add(this.visiblepass);
            this.Controls.Add(this.confirmpasslbl);
            this.Controls.Add(this.confirmpass);
            this.Controls.Add(this.passstatuslbl);
            this.Controls.Add(this.passwordinvalid);
            this.Controls.Add(this.emailinvalid);
            this.Controls.Add(this.lnameinvalid);
            this.Controls.Add(this.fnameinvalid);
            this.Controls.Add(this.Createaccclk);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.password);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Fname);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "NewUser";
            this.Text = "NewUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Lname;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox phonenum;
        private System.Windows.Forms.Button Createaccclk;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.Label fnameinvalid;
        private System.Windows.Forms.Label lnameinvalid;
        private System.Windows.Forms.Label emailinvalid;
        private System.Windows.Forms.Label passwordinvalid;
        private System.Windows.Forms.Label passstatuslbl;
        private System.Windows.Forms.TextBox confirmpass;
        private System.Windows.Forms.Label confirmpasslbl;
        private System.Windows.Forms.Label visiblepass;
        private System.Windows.Forms.Label visibleconfpass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lowercaselbl;
        private System.Windows.Forms.Label uppercaselbl;
        private System.Windows.Forms.Label numericvallbl;
        private System.Windows.Forms.Label specialcharlbl;
        private System.Windows.Forms.Label passlenlbl;
    }
}