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
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 374);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(512, 176);
            this.dataGridView1.TabIndex = 0;
            // 
            // combobxTicketId
            // 
            this.combobxTicketId.BackColor = System.Drawing.Color.MintCream;
            this.combobxTicketId.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combobxTicketId.ForeColor = System.Drawing.Color.Silver;
            this.combobxTicketId.FormattingEnabled = true;
            this.combobxTicketId.Location = new System.Drawing.Point(25, 81);
            this.combobxTicketId.Name = "combobxTicketId";
            this.combobxTicketId.Size = new System.Drawing.Size(121, 26);
            this.combobxTicketId.TabIndex = 1;
            this.combobxTicketId.Text = "Ticket ID.";
            this.combobxTicketId.SelectedIndexChanged += new System.EventHandler(this.combobxTicketId_SelectedIndexChanged);
            // 
            // lblTicketHeader
            // 
            this.lblTicketHeader.AutoSize = true;
            this.lblTicketHeader.Location = new System.Drawing.Point(22, 166);
            this.lblTicketHeader.Name = "lblTicketHeader";
            this.lblTicketHeader.Size = new System.Drawing.Size(56, 16);
            this.lblTicketHeader.TabIndex = 2;
            this.lblTicketHeader.Text = "Header.";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(25, 215);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Adminticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
    }
}
