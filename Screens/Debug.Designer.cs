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
            this.btnBookReport = new System.Windows.Forms.Button();
            this.Admindashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEmployeeTicket
            // 
            this.btnEmployeeTicket.Location = new System.Drawing.Point(147, 75);
            this.btnEmployeeTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmployeeTicket.Name = "btnEmployeeTicket";
            this.btnEmployeeTicket.Size = new System.Drawing.Size(124, 44);
            this.btnEmployeeTicket.TabIndex = 0;
            this.btnEmployeeTicket.Text = "Empolyee Ticket Form";
            this.btnEmployeeTicket.UseVisualStyleBackColor = true;
            this.btnEmployeeTicket.Click += new System.EventHandler(this.btnEmployeeTicket_Click);
            // 
            // btnUserTicket
            // 
            this.btnUserTicket.Location = new System.Drawing.Point(279, 75);
            this.btnUserTicket.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUserTicket.Name = "btnUserTicket";
            this.btnUserTicket.Size = new System.Drawing.Size(124, 44);
            this.btnUserTicket.TabIndex = 1;
            this.btnUserTicket.Text = "User Ticket Form";
            this.btnUserTicket.UseVisualStyleBackColor = true;
            this.btnUserTicket.Click += new System.EventHandler(this.btnUserTicket_Click);
            // 
            // btnBookReport
            // 
            this.btnBookReport.Location = new System.Drawing.Point(411, 75);
            this.btnBookReport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBookReport.Name = "btnBookReport";
            this.btnBookReport.Size = new System.Drawing.Size(124, 44);
            this.btnBookReport.TabIndex = 2;
            this.btnBookReport.Text = "Booking Report";
            this.btnBookReport.UseVisualStyleBackColor = true;
            this.btnBookReport.Click += new System.EventHandler(this.btnBookReport_Click);
            // 
            // Admindashboard
            // 
            this.Admindashboard.Location = new System.Drawing.Point(562, 75);
            this.Admindashboard.Name = "Admindashboard";
            this.Admindashboard.Size = new System.Drawing.Size(129, 44);
            this.Admindashboard.TabIndex = 3;
            this.Admindashboard.Text = "Admin Dashboard";
            this.Admindashboard.UseVisualStyleBackColor = true;
            this.Admindashboard.Click += new System.EventHandler(this.Admindashboard_Click);
            // 
            // Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Admindashboard);
            this.Controls.Add(this.btnBookReport);
            this.Controls.Add(this.btnUserTicket);
            this.Controls.Add(this.btnEmployeeTicket);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Debug";
            this.Text = "Debug";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeTicket;
        private System.Windows.Forms.Button btnUserTicket;
        private System.Windows.Forms.Button btnBookReport;
        private System.Windows.Forms.Button Admindashboard;
    }
}