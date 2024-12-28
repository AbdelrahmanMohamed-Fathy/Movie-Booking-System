namespace Movie_Booking_System.Controls
{
    partial class Viewreportscontrol
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
            this.panelviewrep = new System.Windows.Forms.Panel();
            this.btnOrdersreports = new System.Windows.Forms.Button();
            this.btnbookreports = new System.Windows.Forms.Button();
            this.panelviewrep.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelviewrep
            // 
            this.panelviewrep.BackColor = System.Drawing.Color.Transparent;
            this.panelviewrep.Controls.Add(this.btnOrdersreports);
            this.panelviewrep.Controls.Add(this.btnbookreports);
            this.panelviewrep.Location = new System.Drawing.Point(3, 322);
            this.panelviewrep.Name = "panelviewrep";
            this.panelviewrep.Size = new System.Drawing.Size(250, 500);
            this.panelviewrep.TabIndex = 7;
            // 
            // btnOrdersreports
            // 
            this.btnOrdersreports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrdersreports.BackColor = System.Drawing.Color.Transparent;
            this.btnOrdersreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdersreports.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdersreports.ForeColor = System.Drawing.Color.Teal;
            this.btnOrdersreports.Location = new System.Drawing.Point(12, 127);
            this.btnOrdersreports.Name = "btnOrdersreports";
            this.btnOrdersreports.Size = new System.Drawing.Size(196, 59);
            this.btnOrdersreports.TabIndex = 4;
            this.btnOrdersreports.Text = "Order Reports.";
            this.btnOrdersreports.UseVisualStyleBackColor = false;
            this.btnOrdersreports.Click += new System.EventHandler(this.btnOrdersreports_Click);
            // 
            // btnbookreports
            // 
            this.btnbookreports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnbookreports.BackColor = System.Drawing.Color.Transparent;
            this.btnbookreports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbookreports.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbookreports.ForeColor = System.Drawing.Color.Teal;
            this.btnbookreports.Location = new System.Drawing.Point(12, 192);
            this.btnbookreports.Name = "btnbookreports";
            this.btnbookreports.Size = new System.Drawing.Size(196, 60);
            this.btnbookreports.TabIndex = 5;
            this.btnbookreports.Text = "Book Reports.";
            this.btnbookreports.UseVisualStyleBackColor = false;
            this.btnbookreports.Click += new System.EventHandler(this.btnbookreports_Click);
            // 
            // Viewreportscontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelviewrep);
            this.Name = "Viewreportscontrol";
            this.Size = new System.Drawing.Size(667, 767);
            this.panelviewrep.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelviewrep;
        private System.Windows.Forms.Button btnOrdersreports;
        private System.Windows.Forms.Button btnbookreports;
    }
}
