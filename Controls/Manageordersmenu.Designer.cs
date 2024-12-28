namespace Movie_Booking_System.Controls
{
    partial class Manageordersmenu
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
            this.datagridallorders = new System.Windows.Forms.DataGridView();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.cmbxOrderID = new System.Windows.Forms.ComboBox();
            this.btnmarkfullfilled = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datagridallorders)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridallorders
            // 
            this.datagridallorders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.datagridallorders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridallorders.Dock = System.Windows.Forms.DockStyle.Right;
            this.datagridallorders.GridColor = System.Drawing.Color.Teal;
            this.datagridallorders.Location = new System.Drawing.Point(353, 0);
            this.datagridallorders.Name = "datagridallorders";
            this.datagridallorders.RowHeadersWidth = 51;
            this.datagridallorders.RowTemplate.Height = 24;
            this.datagridallorders.Size = new System.Drawing.Size(474, 758);
            this.datagridallorders.TabIndex = 2;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.Teal;
            this.btnDeleteOrder.Location = new System.Drawing.Point(49, 439);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(171, 60);
            this.btnDeleteOrder.TabIndex = 8;
            this.btnDeleteOrder.Text = "Delete Order.";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // cmbxOrderID
            // 
            this.cmbxOrderID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbxOrderID.BackColor = System.Drawing.Color.MintCream;
            this.cmbxOrderID.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxOrderID.ForeColor = System.Drawing.Color.Gray;
            this.cmbxOrderID.FormattingEnabled = true;
            this.cmbxOrderID.Location = new System.Drawing.Point(49, 137);
            this.cmbxOrderID.Name = "cmbxOrderID";
            this.cmbxOrderID.Size = new System.Drawing.Size(169, 36);
            this.cmbxOrderID.TabIndex = 7;
            this.cmbxOrderID.Text = "Order ID.";
            // 
            // btnmarkfullfilled
            // 
            this.btnmarkfullfilled.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnmarkfullfilled.BackColor = System.Drawing.Color.Transparent;
            this.btnmarkfullfilled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmarkfullfilled.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmarkfullfilled.ForeColor = System.Drawing.Color.Teal;
            this.btnmarkfullfilled.Location = new System.Drawing.Point(49, 349);
            this.btnmarkfullfilled.Name = "btnmarkfullfilled";
            this.btnmarkfullfilled.Size = new System.Drawing.Size(171, 60);
            this.btnmarkfullfilled.TabIndex = 9;
            this.btnmarkfullfilled.Text = "Mark Fulfilled.";
            this.btnmarkfullfilled.UseVisualStyleBackColor = false;
            this.btnmarkfullfilled.Click += new System.EventHandler(this.btnmarkfullfilled_Click);
            // 
            // Manageordersmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.btnmarkfullfilled);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.cmbxOrderID);
            this.Controls.Add(this.datagridallorders);
            this.Name = "Manageordersmenu";
            this.Size = new System.Drawing.Size(827, 758);
            ((System.ComponentModel.ISupportInitialize)(this.datagridallorders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridallorders;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.ComboBox cmbxOrderID;
        private System.Windows.Forms.Button btnmarkfullfilled;
    }
}
