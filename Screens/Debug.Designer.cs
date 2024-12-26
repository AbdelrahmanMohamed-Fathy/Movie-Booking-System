namespace Movie_Booking_System.Screens
{
    partial class Debug
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
            this.btnEmployeeTicket = new System.Windows.Forms.Button();
            this.btnUserTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployeeTicket
            // 
            this.btnEmployeeTicket.Location = new System.Drawing.Point(110, 61);
            this.btnEmployeeTicket.Name = "btnEmployeeTicket";
            this.btnEmployeeTicket.Size = new System.Drawing.Size(93, 36);
            this.btnEmployeeTicket.TabIndex = 0;
            this.btnEmployeeTicket.Text = "Empolyee Ticket Form";
            this.btnEmployeeTicket.UseVisualStyleBackColor = true;
            this.btnEmployeeTicket.Click += new System.EventHandler(this.btnEmployeeTicket_Click);
            // 
            // btnUserTicket
            // 
            this.btnUserTicket.Location = new System.Drawing.Point(209, 61);
            this.btnUserTicket.Name = "btnUserTicket";
            this.btnUserTicket.Size = new System.Drawing.Size(93, 36);
            this.btnUserTicket.TabIndex = 1;
            this.btnUserTicket.Text = "User Ticket Form";
            this.btnUserTicket.UseVisualStyleBackColor = true;
            this.btnUserTicket.Click += new System.EventHandler(this.btnUserTicket_Click);
            // 
            // Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUserTicket);
            this.Controls.Add(this.btnEmployeeTicket);
            this.Name = "Debug";
            this.Text = "Debug";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeTicket;
        private System.Windows.Forms.Button btnUserTicket;
    }
}