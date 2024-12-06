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
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtbxUsername = new System.Windows.Forms.TextBox();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblLogin.Location = new System.Drawing.Point(314, 165);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(3);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(80, 31);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // txtbxUsername
            // 
            this.txtbxUsername.Location = new System.Drawing.Point(264, 202);
            this.txtbxUsername.Name = "txtbxUsername";
            this.txtbxUsername.Size = new System.Drawing.Size(182, 20);
            this.txtbxUsername.TabIndex = 1;
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.Location = new System.Drawing.Point(264, 228);
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.Size = new System.Drawing.Size(182, 20);
            this.txtbxPassword.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(275, 254);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(160, 23);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(275, 284);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(160, 23);
            this.btnContinue.TabIndex = 4;
            this.btnContinue.Text = "Continue as Guest";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.ControlBox = false;
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.txtbxUsername);
            this.Controls.Add(this.lblLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginScreen";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "loginScreen";
            this.Load += new System.EventHandler(this.loginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtbxUsername;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnContinue;
    }
}