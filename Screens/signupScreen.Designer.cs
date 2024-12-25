namespace Movie_Booking_System.Screens
{
    partial class signupScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signupScreen));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.phoneicon = new System.Windows.Forms.Label();
            this.emailicon = new System.Windows.Forms.Label();
            this.passicon = new System.Windows.Forms.Label();
            this.fnameicon = new System.Windows.Forms.Label();
            this.lnameicon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Fname
            // 
            this.Fname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Fname.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.ForeColor = System.Drawing.Color.Silver;
            this.Fname.Location = new System.Drawing.Point(63, 27);
            this.Fname.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.Lname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lname.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.ForeColor = System.Drawing.Color.Silver;
            this.Lname.Location = new System.Drawing.Point(63, 104);
            this.Lname.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Email.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.Silver;
            this.Email.Location = new System.Drawing.Point(64, 180);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.Silver;
            this.password.Location = new System.Drawing.Point(63, 257);
            this.password.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.phonenum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phonenum.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenum.ForeColor = System.Drawing.Color.Silver;
            this.phonenum.Location = new System.Drawing.Point(526, 25);
            this.phonenum.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(300, 34);
            this.phonenum.TabIndex = 4;
            this.phonenum.Text = "Phone Number (Optional)";
            this.phonenum.Enter += new System.EventHandler(this.phonenum_Enter);
            this.phonenum.Leave += new System.EventHandler(this.phonenum_Leave);
            // 
            // Createaccclk
            // 
            this.Createaccclk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Createaccclk.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Createaccclk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Createaccclk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Createaccclk.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Createaccclk.ForeColor = System.Drawing.Color.White;
            this.Createaccclk.Location = new System.Drawing.Point(644, 480);
            this.Createaccclk.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Createaccclk.Name = "Createaccclk";
            this.Createaccclk.Size = new System.Drawing.Size(197, 57);
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
            this.fnameinvalid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fnameinvalid.AutoSize = true;
            this.fnameinvalid.BackColor = System.Drawing.Color.Transparent;
            this.fnameinvalid.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fnameinvalid.ForeColor = System.Drawing.Color.Red;
            this.fnameinvalid.Location = new System.Drawing.Point(64, 63);
            this.fnameinvalid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fnameinvalid.Name = "fnameinvalid";
            this.fnameinvalid.Size = new System.Drawing.Size(135, 16);
            this.fnameinvalid.TabIndex = 6;
            this.fnameinvalid.Text = "Please Enter First Name!";
            this.fnameinvalid.Visible = false;
            // 
            // lnameinvalid
            // 
            this.lnameinvalid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnameinvalid.AutoSize = true;
            this.lnameinvalid.BackColor = System.Drawing.Color.Transparent;
            this.lnameinvalid.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnameinvalid.ForeColor = System.Drawing.Color.Red;
            this.lnameinvalid.Location = new System.Drawing.Point(64, 140);
            this.lnameinvalid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnameinvalid.Name = "lnameinvalid";
            this.lnameinvalid.Size = new System.Drawing.Size(134, 16);
            this.lnameinvalid.TabIndex = 7;
            this.lnameinvalid.Text = "Please Enter Last Name!";
            this.lnameinvalid.Visible = false;
            // 
            // emailinvalid
            // 
            this.emailinvalid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailinvalid.AutoSize = true;
            this.emailinvalid.BackColor = System.Drawing.Color.Transparent;
            this.emailinvalid.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailinvalid.ForeColor = System.Drawing.Color.Red;
            this.emailinvalid.Location = new System.Drawing.Point(64, 216);
            this.emailinvalid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailinvalid.Name = "emailinvalid";
            this.emailinvalid.Size = new System.Drawing.Size(192, 16);
            this.emailinvalid.TabIndex = 8;
            this.emailinvalid.Text = "Please Enter A Valid Email Address!";
            this.emailinvalid.Visible = false;
            // 
            // passwordinvalid
            // 
            this.passwordinvalid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordinvalid.AutoSize = true;
            this.passwordinvalid.BackColor = System.Drawing.Color.Transparent;
            this.passwordinvalid.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordinvalid.ForeColor = System.Drawing.Color.Red;
            this.passwordinvalid.Location = new System.Drawing.Point(64, 317);
            this.passwordinvalid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordinvalid.Name = "passwordinvalid";
            this.passwordinvalid.Size = new System.Drawing.Size(140, 16);
            this.passwordinvalid.TabIndex = 9;
            this.passwordinvalid.Text = "Please Enter A Password!";
            this.passwordinvalid.Visible = false;
            // 
            // passstatuslbl
            // 
            this.passstatuslbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passstatuslbl.AutoSize = true;
            this.passstatuslbl.BackColor = System.Drawing.Color.Transparent;
            this.passstatuslbl.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passstatuslbl.Location = new System.Drawing.Point(372, 295);
            this.passstatuslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passstatuslbl.Name = "passstatuslbl";
            this.passstatuslbl.Size = new System.Drawing.Size(43, 16);
            this.passstatuslbl.TabIndex = 11;
            this.passstatuslbl.Text = "Weak";
            this.passstatuslbl.Visible = false;
            // 
            // confirmpass
            // 
            this.confirmpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmpass.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpass.ForeColor = System.Drawing.Color.Silver;
            this.confirmpass.Location = new System.Drawing.Point(63, 345);
            this.confirmpass.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.confirmpasslbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmpasslbl.AutoSize = true;
            this.confirmpasslbl.BackColor = System.Drawing.Color.Transparent;
            this.confirmpasslbl.Font = new System.Drawing.Font("Arial Narrow", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmpasslbl.Location = new System.Drawing.Point(60, 383);
            this.confirmpasslbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmpasslbl.Name = "confirmpasslbl";
            this.confirmpasslbl.Size = new System.Drawing.Size(162, 16);
            this.confirmpasslbl.TabIndex = 13;
            this.confirmpasslbl.Text = "Please confirm the Password!";
            this.confirmpasslbl.Visible = false;
            // 
            // visiblepass
            // 
            this.visiblepass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.visiblepass.BackColor = System.Drawing.Color.Transparent;
            this.visiblepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visiblepass.Image = ((System.Drawing.Image)(resources.GetObject("visiblepass.Image")));
            this.visiblepass.Location = new System.Drawing.Point(373, 261);
            this.visiblepass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.visiblepass.Name = "visiblepass";
            this.visiblepass.Size = new System.Drawing.Size(37, 34);
            this.visiblepass.TabIndex = 15;
            this.visiblepass.Click += new System.EventHandler(this.visiblepass_Click);
            // 
            // visibleconfpass
            // 
            this.visibleconfpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.visibleconfpass.BackColor = System.Drawing.Color.Transparent;
            this.visibleconfpass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visibleconfpass.Image = ((System.Drawing.Image)(resources.GetObject("visibleconfpass.Image")));
            this.visibleconfpass.Location = new System.Drawing.Point(373, 345);
            this.visibleconfpass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.visibleconfpass.Name = "visibleconfpass";
            this.visibleconfpass.Size = new System.Drawing.Size(37, 34);
            this.visibleconfpass.TabIndex = 16;
            this.visibleconfpass.Click += new System.EventHandler(this.visibleconfpass_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Location = new System.Drawing.Point(64, 295);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 16);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(139, 295);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 16);
            this.panel2.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(214, 295);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(75, 16);
            this.panel3.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(289, 295);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(75, 16);
            this.panel4.TabIndex = 22;
            // 
            // lowercaselbl
            // 
            this.lowercaselbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lowercaselbl.AutoSize = true;
            this.lowercaselbl.BackColor = System.Drawing.Color.Transparent;
            this.lowercaselbl.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowercaselbl.Location = new System.Drawing.Point(59, 443);
            this.lowercaselbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lowercaselbl.Name = "lowercaselbl";
            this.lowercaselbl.Size = new System.Drawing.Size(346, 20);
            this.lowercaselbl.TabIndex = 23;
            this.lowercaselbl.Text = "• Password should contain at least one lower case letter.";
            // 
            // uppercaselbl
            // 
            this.uppercaselbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uppercaselbl.AutoSize = true;
            this.uppercaselbl.BackColor = System.Drawing.Color.Transparent;
            this.uppercaselbl.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uppercaselbl.Location = new System.Drawing.Point(59, 469);
            this.uppercaselbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uppercaselbl.Name = "uppercaselbl";
            this.uppercaselbl.Size = new System.Drawing.Size(349, 20);
            this.uppercaselbl.TabIndex = 24;
            this.uppercaselbl.Text = "• Password should contain at least one upper case letter.\r\n";
            // 
            // numericvallbl
            // 
            this.numericvallbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numericvallbl.AutoSize = true;
            this.numericvallbl.BackColor = System.Drawing.Color.Transparent;
            this.numericvallbl.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericvallbl.Location = new System.Drawing.Point(59, 493);
            this.numericvallbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numericvallbl.Name = "numericvallbl";
            this.numericvallbl.Size = new System.Drawing.Size(334, 20);
            this.numericvallbl.TabIndex = 25;
            this.numericvallbl.Text = "• Password should contain at least one numeric value.\r\n";
            // 
            // specialcharlbl
            // 
            this.specialcharlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.specialcharlbl.AutoSize = true;
            this.specialcharlbl.BackColor = System.Drawing.Color.Transparent;
            this.specialcharlbl.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specialcharlbl.Location = new System.Drawing.Point(59, 419);
            this.specialcharlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.specialcharlbl.Name = "specialcharlbl";
            this.specialcharlbl.Size = new System.Drawing.Size(352, 20);
            this.specialcharlbl.TabIndex = 26;
            this.specialcharlbl.Text = "• Password should contain at least one special character.\r\n";
            // 
            // passlenlbl
            // 
            this.passlenlbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passlenlbl.AutoSize = true;
            this.passlenlbl.BackColor = System.Drawing.Color.Transparent;
            this.passlenlbl.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passlenlbl.Location = new System.Drawing.Point(59, 517);
            this.passlenlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passlenlbl.Name = "passlenlbl";
            this.passlenlbl.Size = new System.Drawing.Size(290, 20);
            this.passlenlbl.TabIndex = 27;
            this.passlenlbl.Text = "• Password should be between 8-15 characters.\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(629, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(0, 0);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // phoneicon
            // 
            this.phoneicon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneicon.BackColor = System.Drawing.Color.Transparent;
            this.phoneicon.Image = ((System.Drawing.Image)(resources.GetObject("phoneicon.Image")));
            this.phoneicon.Location = new System.Drawing.Point(469, 23);
            this.phoneicon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.phoneicon.Name = "phoneicon";
            this.phoneicon.Size = new System.Drawing.Size(48, 36);
            this.phoneicon.TabIndex = 29;
            // 
            // emailicon
            // 
            this.emailicon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailicon.BackColor = System.Drawing.Color.Transparent;
            this.emailicon.Image = ((System.Drawing.Image)(resources.GetObject("emailicon.Image")));
            this.emailicon.Location = new System.Drawing.Point(25, 178);
            this.emailicon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.emailicon.Name = "emailicon";
            this.emailicon.Size = new System.Drawing.Size(37, 36);
            this.emailicon.TabIndex = 30;
            // 
            // passicon
            // 
            this.passicon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passicon.BackColor = System.Drawing.Color.Transparent;
            this.passicon.Image = ((System.Drawing.Image)(resources.GetObject("passicon.Image")));
            this.passicon.Location = new System.Drawing.Point(24, 248);
            this.passicon.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.passicon.Name = "passicon";
            this.passicon.Size = new System.Drawing.Size(41, 47);
            this.passicon.TabIndex = 31;
            // 
            // fnameicon
            // 
            this.fnameicon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fnameicon.BackColor = System.Drawing.Color.Transparent;
            this.fnameicon.Image = ((System.Drawing.Image)(resources.GetObject("fnameicon.Image")));
            this.fnameicon.Location = new System.Drawing.Point(25, 25);
            this.fnameicon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fnameicon.Name = "fnameicon";
            this.fnameicon.Size = new System.Drawing.Size(37, 36);
            this.fnameicon.TabIndex = 32;
            // 
            // lnameicon
            // 
            this.lnameicon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnameicon.BackColor = System.Drawing.Color.Transparent;
            this.lnameicon.Image = ((System.Drawing.Image)(resources.GetObject("lnameicon.Image")));
            this.lnameicon.Location = new System.Drawing.Point(25, 104);
            this.lnameicon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnameicon.Name = "lnameicon";
            this.lnameicon.Size = new System.Drawing.Size(37, 36);
            this.lnameicon.TabIndex = 33;
            // 
            // signupScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(931, 575);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lnameicon);
            this.Controls.Add(this.fnameicon);
            this.Controls.Add(this.passicon);
            this.Controls.Add(this.emailicon);
            this.Controls.Add(this.phoneicon);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passlenlbl);
            this.Controls.Add(this.specialcharlbl);
            this.Controls.Add(this.numericvallbl);
            this.Controls.Add(this.uppercaselbl);
            this.Controls.Add(this.lowercaselbl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
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
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Red;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "signupScreen";
            this.Text = "NewUser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label phoneicon;
        private System.Windows.Forms.Label emailicon;
        private System.Windows.Forms.Label passicon;
        private System.Windows.Forms.Label fnameicon;
        private System.Windows.Forms.Label lnameicon;
    }
}