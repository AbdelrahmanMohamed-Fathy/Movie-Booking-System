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
            this.btnOrderReport = new System.Windows.Forms.Button();
            this.Admindashboard = new System.Windows.Forms.Button();
            this.btnUserReport = new System.Windows.Forms.Button();
            this.btnBookReport = new System.Windows.Forms.Button();
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
            // btnOrderReport
            // 
            this.btnOrderReport.Location = new System.Drawing.Point(308, 61);
            this.btnOrderReport.Name = "btnOrderReport";
            this.btnOrderReport.Size = new System.Drawing.Size(93, 36);
            this.btnOrderReport.TabIndex = 2;
            this.btnOrderReport.Text = "Orders Report";
            this.btnOrderReport.UseVisualStyleBackColor = true;
            this.btnOrderReport.Click += new System.EventHandler(this.btnOrderReport_Click);
            // 
            // Admindashboard
            // 
            this.Admindashboard.Location = new System.Drawing.Point(422, 61);
            this.Admindashboard.Margin = new System.Windows.Forms.Padding(2);
            this.Admindashboard.Name = "Admindashboard";
            this.Admindashboard.Size = new System.Drawing.Size(97, 36);
            this.Admindashboard.TabIndex = 3;
            this.Admindashboard.Text = "Admin Dashboard";
            this.Admindashboard.UseVisualStyleBackColor = true;
            this.Admindashboard.Click += new System.EventHandler(this.Admindashboard_Click);
            // 
            // btnUserReport
            // 
            this.btnUserReport.Location = new System.Drawing.Point(308, 145);
            this.btnUserReport.Name = "btnUserReport";
            this.btnUserReport.Size = new System.Drawing.Size(93, 36);
            this.btnUserReport.TabIndex = 4;
            this.btnUserReport.Text = "Users Report";
            this.btnUserReport.UseVisualStyleBackColor = true;
            this.btnUserReport.Click += new System.EventHandler(this.btnUserReport_Click);
            // 
            // btnBookReport
            // 
            this.btnBookReport.Location = new System.Drawing.Point(308, 103);
            this.btnBookReport.Name = "btnBookReport";
            this.btnBookReport.Size = new System.Drawing.Size(93, 36);
            this.btnBookReport.TabIndex = 5;
            this.btnBookReport.Text = "Booking Report";
            this.btnBookReport.UseVisualStyleBackColor = true;
            this.btnBookReport.Click += new System.EventHandler(this.btnBookReport_Click);
            // 
            // Debug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBookReport);
            this.Controls.Add(this.btnUserReport);
            this.Controls.Add(this.Admindashboard);
            this.Controls.Add(this.btnOrderReport);
            this.Controls.Add(this.btnUserTicket);
            this.Controls.Add(this.btnEmployeeTicket);
            this.Name = "Debug";
            this.Text = "Debug";
            this.Load += new System.EventHandler(this.Debug_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmployeeTicket;
        private System.Windows.Forms.Button btnUserTicket;
        private System.Windows.Forms.Button btnOrderReport;
        private System.Windows.Forms.Button Admindashboard;
        private System.Windows.Forms.Button btnUserReport;
        private System.Windows.Forms.Button btnBookReport;
    }
}