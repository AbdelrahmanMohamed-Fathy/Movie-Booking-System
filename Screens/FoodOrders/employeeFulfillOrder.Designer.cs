namespace Movie_Booking_System.Screens.FoodOrders
{
    partial class employeeFulfillOrder
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCompleteorder = new System.Windows.Forms.Button();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLoadorder = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoadincOrd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(764, 287);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ORDER ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "FOOD ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "FOOD NAME";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ORDER COUNT";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "TOTAL PRICE";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "UNIT PRICE";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "FULFILLED";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "UserID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // btnCompleteorder
            // 
            this.btnCompleteorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompleteorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnCompleteorder.Location = new System.Drawing.Point(599, 305);
            this.btnCompleteorder.Name = "btnCompleteorder";
            this.btnCompleteorder.Size = new System.Drawing.Size(362, 53);
            this.btnCompleteorder.TabIndex = 3;
            this.btnCompleteorder.Text = "Complete Order";
            this.btnCompleteorder.UseVisualStyleBackColor = true;
            this.btnCompleteorder.Click += new System.EventHandler(this.btnCompleteorder_Click);
            // 
            // txtOrderId
            // 
            this.txtOrderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtOrderId.Location = new System.Drawing.Point(97, 318);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(458, 26);
            this.txtOrderId.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Order ID:";
            // 
            // btnLoadorder
            // 
            this.btnLoadorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoadorder.Location = new System.Drawing.Point(782, 71);
            this.btnLoadorder.Name = "btnLoadorder";
            this.btnLoadorder.Size = new System.Drawing.Size(179, 53);
            this.btnLoadorder.TabIndex = 21;
            this.btnLoadorder.Text = "Load All Orders";
            this.btnLoadorder.UseVisualStyleBackColor = true;
            this.btnLoadorder.Click += new System.EventHandler(this.btnLoadorder_Click);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(782, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(179, 53);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoadincOrd
            // 
            this.btnLoadincOrd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadincOrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadincOrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLoadincOrd.Location = new System.Drawing.Point(782, 130);
            this.btnLoadincOrd.Name = "btnLoadincOrd";
            this.btnLoadincOrd.Size = new System.Drawing.Size(179, 53);
            this.btnLoadincOrd.TabIndex = 22;
            this.btnLoadincOrd.Text = "Load Inc. Orders";
            this.btnLoadincOrd.UseVisualStyleBackColor = true;
            this.btnLoadincOrd.Click += new System.EventHandler(this.btnLoadincOrd_Click);
            // 
            // employeeFulfillOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 377);
            this.Controls.Add(this.btnLoadincOrd);
            this.Controls.Add(this.btnLoadorder);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtOrderId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCompleteorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "employeeFulfillOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employeeFulfillOrder";
            this.Load += new System.EventHandler(this.employeeFulfillOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnCompleteorder;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoadorder;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoadincOrd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}