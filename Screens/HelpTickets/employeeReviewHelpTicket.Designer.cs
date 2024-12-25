namespace Movie_Booking_System.Screens.HelpTickets
{
    partial class employeeReviewHelpTicket
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbboxTicketID = new System.Windows.Forms.ComboBox();
            this.txtbxContent = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnMark = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(436, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbboxTicketID
            // 
            this.cmbboxTicketID.FormattingEnabled = true;
            this.cmbboxTicketID.Location = new System.Drawing.Point(521, 101);
            this.cmbboxTicketID.Name = "cmbboxTicketID";
            this.cmbboxTicketID.Size = new System.Drawing.Size(121, 21);
            this.cmbboxTicketID.Sorted = true;
            this.cmbboxTicketID.TabIndex = 1;
            this.cmbboxTicketID.SelectedIndexChanged += new System.EventHandler(this.cmbboxTicketID_SelectedIndexChanged);
            // 
            // txtbxContent
            // 
            this.txtbxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxContent.Location = new System.Drawing.Point(11, 274);
            this.txtbxContent.Multiline = true;
            this.txtbxContent.Name = "txtbxContent";
            this.txtbxContent.ReadOnly = true;
            this.txtbxContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbxContent.Size = new System.Drawing.Size(571, 187);
            this.txtbxContent.TabIndex = 2;
            this.txtbxContent.Visible = false;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(4, 233);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(127, 37);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Header";
            this.lblHeader.Visible = false;
            // 
            // btnMark
            // 
            this.btnMark.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMark.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMark.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMark.ForeColor = System.Drawing.Color.White;
            this.btnMark.Location = new System.Drawing.Point(649, 101);
            this.btnMark.Margin = new System.Windows.Forms.Padding(4);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(121, 62);
            this.btnMark.TabIndex = 6;
            this.btnMark.Text = "Mark Seen";
            this.btnMark.UseVisualStyleBackColor = false;
            this.btnMark.Visible = false;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(474, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ticket ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(473, 464);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 24);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(418, 464);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(60, 24);
            this.lblFrom.TabIndex = 11;
            this.lblFrom.Text = "From:";
            this.lblFrom.Visible = false;
            // 
            // employeeReviewHelpTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 514);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.txtbxContent);
            this.Controls.Add(this.cmbboxTicketID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "employeeReviewHelpTicket";
            this.Text = "employeeReviewHelpTicket";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbboxTicketID;
        private System.Windows.Forms.TextBox txtbxContent;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblFrom;
    }
}