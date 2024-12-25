namespace Movie_Booking_System.Screens.HelpTickets
{
    partial class userSubmitHelpTicket
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
            this.txtbxContent = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtbxHeader = new Movie_Booking_System.Controls.PlaceHolderTextBox();
            this.lblSuccess = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbxContent
            // 
            this.txtbxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxContent.Location = new System.Drawing.Point(12, 117);
            this.txtbxContent.Multiline = true;
            this.txtbxContent.Name = "txtbxContent";
            this.txtbxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxContent.Size = new System.Drawing.Size(571, 187);
            this.txtbxContent.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSubmit.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(593, 242);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 62);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtbxHeader
            // 
            this.txtbxHeader.AutoSize = true;
            this.txtbxHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxHeader.Location = new System.Drawing.Point(12, 62);
            this.txtbxHeader.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.txtbxHeader.MaximumSize = new System.Drawing.Size(46600, 44);
            this.txtbxHeader.MinimumSize = new System.Drawing.Size(0, 44);
            this.txtbxHeader.Name = "txtbxHeader";
            this.txtbxHeader.PlaceHolderText = "Header";
            this.txtbxHeader.PlaceHolderTextColor = System.Drawing.Color.Silver;
            this.txtbxHeader.Size = new System.Drawing.Size(229, 44);
            this.txtbxHeader.TabIndex = 8;
            this.txtbxHeader.TextChanged += new System.EventHandler(this.txtbxHeader_TextChanged);
            // 
            // lblSuccess
            // 
            this.lblSuccess.AutoSize = true;
            this.lblSuccess.BackColor = System.Drawing.Color.Black;
            this.lblSuccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuccess.ForeColor = System.Drawing.Color.Lime;
            this.lblSuccess.Location = new System.Drawing.Point(133, 9);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(430, 37);
            this.lblSuccess.TabIndex = 9;
            this.lblSuccess.Text = "Ticket submitted successfully";
            this.lblSuccess.Visible = false;
            // 
            // userSubmitHelpTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 316);
            this.Controls.Add(this.lblSuccess);
            this.Controls.Add(this.txtbxHeader);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtbxContent);
            this.Name = "userSubmitHelpTicket";
            this.Text = "userSubmitHelpTicket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxContent;
        private System.Windows.Forms.Button btnSubmit;
        private Controls.PlaceHolderTextBox txtbxHeader;
        private System.Windows.Forms.Label lblSuccess;
    }
}