namespace Movie_Booking_System.Controls
{
    partial class Adminticket
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.combobxTicketId = new System.Windows.Forms.ComboBox();
            this.lblTicketHeader = new System.Windows.Forms.Label();
            this.txtboxTicketdesc = new System.Windows.Forms.TextBox();
            this.btnMark = new System.Windows.Forms.Button();
            this.btnDeleteTicket = new System.Windows.Forms.Button();
            this.lblfrom = new System.Windows.Forms.Label();
            this.lbluserticket = new System.Windows.Forms.Label();
            this.lblTicketid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MintCream;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Teal;
            this.dataGridView1.Location = new System.Drawing.Point(3, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(512, 176);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Visible = false;
            // 
            // combobxTicketId
            // 
            this.combobxTicketId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combobxTicketId.BackColor = System.Drawing.Color.MintCream;
            this.combobxTicketId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobxTicketId.ForeColor = System.Drawing.Color.Black;
            this.combobxTicketId.FormattingEnabled = true;
            this.combobxTicketId.Location = new System.Drawing.Point(3, 118);
            this.combobxTicketId.Name = "combobxTicketId";
            this.combobxTicketId.Size = new System.Drawing.Size(121, 26);
            this.combobxTicketId.TabIndex = 1;
            this.combobxTicketId.SelectedIndexChanged += new System.EventHandler(this.combobxTicketId_SelectedIndexChanged);
            // 
            // lblTicketHeader
            // 
            this.lblTicketHeader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTicketHeader.AutoSize = true;
            this.lblTicketHeader.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketHeader.Location = new System.Drawing.Point(-3, 181);
            this.lblTicketHeader.Name = "lblTicketHeader";
            this.lblTicketHeader.Size = new System.Drawing.Size(167, 34);
            this.lblTicketHeader.TabIndex = 2;
            this.lblTicketHeader.Text = "Ticket Subject";
            this.lblTicketHeader.Visible = false;
            // 
            // txtboxTicketdesc
            // 
            this.txtboxTicketdesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxTicketdesc.Location = new System.Drawing.Point(3, 215);
            this.txtboxTicketdesc.Multiline = true;
            this.txtboxTicketdesc.Name = "txtboxTicketdesc";
            this.txtboxTicketdesc.ReadOnly = true;
            this.txtboxTicketdesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtboxTicketdesc.Size = new System.Drawing.Size(512, 153);
            this.txtboxTicketdesc.TabIndex = 3;
            this.txtboxTicketdesc.Visible = false;
            // 
            // btnMark
            // 
            this.btnMark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMark.BackColor = System.Drawing.Color.Teal;
            this.btnMark.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMark.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMark.ForeColor = System.Drawing.Color.MintCream;
            this.btnMark.Location = new System.Drawing.Point(237, 114);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(114, 34);
            this.btnMark.TabIndex = 4;
            this.btnMark.Text = "Mark Seen.";
            this.btnMark.UseVisualStyleBackColor = false;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // btnDeleteTicket
            // 
            this.btnDeleteTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteTicket.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteTicket.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnDeleteTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTicket.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTicket.ForeColor = System.Drawing.Color.MintCream;
            this.btnDeleteTicket.Location = new System.Drawing.Point(390, 114);
            this.btnDeleteTicket.Name = "btnDeleteTicket";
            this.btnDeleteTicket.Size = new System.Drawing.Size(125, 34);
            this.btnDeleteTicket.TabIndex = 5;
            this.btnDeleteTicket.Text = "Delete Ticket.";
            this.btnDeleteTicket.UseVisualStyleBackColor = false;
            this.btnDeleteTicket.Click += new System.EventHandler(this.btnDeleteTicket_Click);
            // 
            // lblfrom
            // 
            this.lblfrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblfrom.AutoSize = true;
            this.lblfrom.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfrom.Location = new System.Drawing.Point(328, 188);
            this.lblfrom.Name = "lblfrom";
            this.lblfrom.Size = new System.Drawing.Size(54, 24);
            this.lblfrom.TabIndex = 6;
            this.lblfrom.Text = "From:";
            this.lblfrom.Visible = false;
            // 
            // lbluserticket
            // 
            this.lbluserticket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbluserticket.AutoSize = true;
            this.lbluserticket.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserticket.Location = new System.Drawing.Point(377, 188);
            this.lbluserticket.Name = "lbluserticket";
            this.lbluserticket.Size = new System.Drawing.Size(58, 24);
            this.lbluserticket.TabIndex = 7;
            this.lbluserticket.Text = "Name.";
            this.lbluserticket.Visible = false;
            // 
            // lblTicketid
            // 
            this.lblTicketid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTicketid.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketid.Location = new System.Drawing.Point(3, 76);
            this.lblTicketid.Name = "lblTicketid";
            this.lblTicketid.Size = new System.Drawing.Size(118, 39);
            this.lblTicketid.TabIndex = 8;
            this.lblTicketid.Text = "Ticket ID:";
            // 
            // Adminticket
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lblTicketid);
            this.Controls.Add(this.lbluserticket);
            this.Controls.Add(this.lblfrom);
            this.Controls.Add(this.btnDeleteTicket);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.txtboxTicketdesc);
            this.Controls.Add(this.lblTicketHeader);
            this.Controls.Add(this.combobxTicketId);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Adminticket";
            this.Size = new System.Drawing.Size(518, 553);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combobxTicketId;
        private System.Windows.Forms.Label lblTicketHeader;
        private System.Windows.Forms.TextBox txtboxTicketdesc;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.Button btnDeleteTicket;
        private System.Windows.Forms.Label lblfrom;
        private System.Windows.Forms.Label lbluserticket;
        private System.Windows.Forms.Label lblTicketid;
    }
}
