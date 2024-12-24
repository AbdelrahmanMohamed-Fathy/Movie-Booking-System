namespace Movie_Booking_System.Screens
{
    partial class loginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginScreen));
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblInvalid = new System.Windows.Forms.Label();
            this.Signupclk = new System.Windows.Forms.Button();
            this.visibleconfpass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblLogin.Location = new System.Drawing.Point(419, 203);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(101, 39);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxUsername.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxUsername.Location = new System.Drawing.Point(352, 249);
            this.txtbxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(241, 22);
            this.txtbxUsername.TabIndex = 1;
            this.txtbxUsername.TextChanged += new System.EventHandler(this.txtbxUsername_TextChanged);
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtbxPassword.Location = new System.Drawing.Point(352, 281);
            this.txtbxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(241, 22);
            this.txtbxPassword.TabIndex = 2;
            this.txtbxPassword.UseSystemPasswordChar = true;
            this.txtbxPassword.TextChanged += new System.EventHandler(this.txtbxPassword_TextChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Location = new System.Drawing.Point(367, 342);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(213, 28);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnContinue.Location = new System.Drawing.Point(367, 379);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(213, 28);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Continue as Guest";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblInvalid
            // 
            this.lblInvalid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInvalid.AutoSize = true;
            this.lblInvalid.ForeColor = System.Drawing.Color.Red;
            this.lblInvalid.Location = new System.Drawing.Point(363, 309);
            this.lblInvalid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInvalid.Name = "lblInvalid";
            this.lblInvalid.Size = new System.Drawing.Size(186, 16);
            this.lblInvalid.TabIndex = 5;
            this.lblInvalid.Text = "Invalid username or password";
            this.lblInvalid.Visible = false;
            // 
            // Signupclk
            // 
            this.Signupclk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Signupclk.Location = new System.Drawing.Point(367, 414);
            this.Signupclk.Name = "Signupclk";
            this.Signupclk.Size = new System.Drawing.Size(213, 29);
            this.Signupclk.TabIndex = 6;
            this.Signupclk.Text = "Sign up";
            this.Signupclk.UseVisualStyleBackColor = true;
            this.Signupclk.Click += new System.EventHandler(this.Signupclk_Click);
            // 
            // visibleconfpass
            // 
            this.visibleconfpass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.visibleconfpass.Image = ((System.Drawing.Image)(resources.GetObject("visibleconfpass.Image")));
            this.visibleconfpass.Location = new System.Drawing.Point(600, 281);
            this.visibleconfpass.Name = "visibleconfpass";
            this.visibleconfpass.Size = new System.Drawing.Size(41, 22);
            this.visibleconfpass.TabIndex = 17;
            this.visibleconfpass.Click += new System.EventHandler(this.visibleconfpass_Click);
            // 
            // loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 615);
            this.ControlBox = false;
            this.Controls.Add(this.visibleconfpass);
            this.Controls.Add(this.Signupclk);
            this.Controls.Add(this.lblInvalid);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.txtbxUsername);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "loginScreen";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "loginScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblInvalid;
        private System.Windows.Forms.Button Signupclk;
        private System.Windows.Forms.Label visibleconfpass;
    }
}