namespace Movie_Booking_System.Screens.FoodOrders
{
    partial class userFoodOrder
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
            this.FoodId = new System.Windows.Forms.ComboBox();
            this.addOrderBut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FoodName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OrderCount = new System.Windows.Forms.TextBox();
            this.OrderPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.avaliablecount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ClearButt = new System.Windows.Forms.Button();
            this.LoadOrderButt = new System.Windows.Forms.Button();
            this.DeleteOrdButton = new System.Windows.Forms.Button();
            this.UserId1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TotalOrCo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.UsedCount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FoodId
            // 
            this.FoodId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FoodId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FoodId.FormattingEnabled = true;
            this.FoodId.Location = new System.Drawing.Point(134, 107);
            this.FoodId.Name = "FoodId";
            this.FoodId.Size = new System.Drawing.Size(109, 28);
            this.FoodId.TabIndex = 0;
            this.FoodId.SelectedIndexChanged += new System.EventHandler(this.FoodId_SelectedIndexChanged);
            // 
            // addOrderBut
            // 
            this.addOrderBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOrderBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addOrderBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.addOrderBut.Location = new System.Drawing.Point(624, 307);
            this.addOrderBut.Name = "addOrderBut";
            this.addOrderBut.Size = new System.Drawing.Size(146, 53);
            this.addOrderBut.TabIndex = 1;
            this.addOrderBut.Text = "Add Order";
            this.addOrderBut.UseVisualStyleBackColor = true;
            this.addOrderBut.Click += new System.EventHandler(this.addOrderBut_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(11, 307);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(595, 230);
            this.dataGridView1.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Food ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Food Name:";
            // 
            // FoodName
            // 
            this.FoodName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FoodName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.FoodName.FormattingEnabled = true;
            this.FoodName.Location = new System.Drawing.Point(430, 107);
            this.FoodName.Name = "FoodName";
            this.FoodName.Size = new System.Drawing.Size(144, 28);
            this.FoodName.TabIndex = 4;
            this.FoodName.SelectedIndexChanged += new System.EventHandler(this.FoodName_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Order Count:";
            // 
            // OrderCount
            // 
            this.OrderCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.OrderCount.Location = new System.Drawing.Point(134, 151);
            this.OrderCount.Name = "OrderCount";
            this.OrderCount.Size = new System.Drawing.Size(109, 26);
            this.OrderCount.TabIndex = 7;
            this.OrderCount.TextChanged += new System.EventHandler(this.OrderCount_TextChanged);
            // 
            // OrderPrice
            // 
            this.OrderPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.OrderPrice.Location = new System.Drawing.Point(430, 154);
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.ReadOnly = true;
            this.OrderPrice.Size = new System.Drawing.Size(144, 26);
            this.OrderPrice.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(300, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Order Price:";
            // 
            // avaliablecount
            // 
            this.avaliablecount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.avaliablecount.Location = new System.Drawing.Point(134, 201);
            this.avaliablecount.Name = "avaliablecount";
            this.avaliablecount.ReadOnly = true;
            this.avaliablecount.Size = new System.Drawing.Size(109, 26);
            this.avaliablecount.TabIndex = 11;
            this.avaliablecount.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Av. Count:";
            // 
            // ClearButt
            // 
            this.ClearButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ClearButt.Location = new System.Drawing.Point(624, 366);
            this.ClearButt.Name = "ClearButt";
            this.ClearButt.Size = new System.Drawing.Size(146, 53);
            this.ClearButt.TabIndex = 12;
            this.ClearButt.Text = "Clear";
            this.ClearButt.UseVisualStyleBackColor = true;
            this.ClearButt.Click += new System.EventHandler(this.ClearButt_Click);
            // 
            // LoadOrderButt
            // 
            this.LoadOrderButt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadOrderButt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadOrderButt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.LoadOrderButt.Location = new System.Drawing.Point(624, 425);
            this.LoadOrderButt.Name = "LoadOrderButt";
            this.LoadOrderButt.Size = new System.Drawing.Size(146, 53);
            this.LoadOrderButt.TabIndex = 13;
            this.LoadOrderButt.Text = "Load Orders";
            this.LoadOrderButt.UseVisualStyleBackColor = true;
            this.LoadOrderButt.Click += new System.EventHandler(this.LoadOrderButt_Click);
            // 
            // DeleteOrdButton
            // 
            this.DeleteOrdButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteOrdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteOrdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.DeleteOrdButton.Location = new System.Drawing.Point(624, 484);
            this.DeleteOrdButton.Name = "DeleteOrdButton";
            this.DeleteOrdButton.Size = new System.Drawing.Size(146, 53);
            this.DeleteOrdButton.TabIndex = 15;
            this.DeleteOrdButton.Text = "Delete Order";
            this.DeleteOrdButton.UseVisualStyleBackColor = true;
            this.DeleteOrdButton.Click += new System.EventHandler(this.DeleteOrdButton_Click);
            // 
            // UserId1
            // 
            this.UserId1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.UserId1.Location = new System.Drawing.Point(430, 204);
            this.UserId1.Name = "UserId1";
            this.UserId1.ReadOnly = true;
            this.UserId1.Size = new System.Drawing.Size(144, 26);
            this.UserId1.TabIndex = 17;
            this.UserId1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(300, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "User ID:";
            // 
            // TotalOrCo
            // 
            this.TotalOrCo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.TotalOrCo.Location = new System.Drawing.Point(134, 250);
            this.TotalOrCo.Name = "TotalOrCo";
            this.TotalOrCo.ReadOnly = true;
            this.TotalOrCo.Size = new System.Drawing.Size(109, 26);
            this.TotalOrCo.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total Count:";
            // 
            // UsedCount
            // 
            this.UsedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.UsedCount.Location = new System.Drawing.Point(430, 250);
            this.UsedCount.Name = "UsedCount";
            this.UsedCount.ReadOnly = true;
            this.UsedCount.Size = new System.Drawing.Size(144, 26);
            this.UsedCount.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(300, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Used Count:";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.textBox7.Location = new System.Drawing.Point(179, 27);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(194, 38);
            this.textBox7.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 31);
            this.label9.TabIndex = 22;
            this.label9.Text = "Order ID:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(410, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 31);
            this.label10.TabIndex = 24;
            this.label10.Text = "Total Price:";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.textBox8.Location = new System.Drawing.Point(580, 27);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(138, 38);
            this.textBox8.TabIndex = 25;
            // 
            // userFoodOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 543);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.UsedCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TotalOrCo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.UserId1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DeleteOrdButton);
            this.Controls.Add(this.LoadOrderButt);
            this.Controls.Add(this.ClearButt);
            this.Controls.Add(this.avaliablecount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrderPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OrderCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FoodName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addOrderBut);
            this.Controls.Add(this.FoodId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "userFoodOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "userFoodOrder";
            this.Load += new System.EventHandler(this.userFoodOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox FoodId;
        private System.Windows.Forms.Button addOrderBut;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FoodName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OrderCount;
        private System.Windows.Forms.TextBox OrderPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox avaliablecount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ClearButt;
        private System.Windows.Forms.Button LoadOrderButt;
        private System.Windows.Forms.Button DeleteOrdButton;
        private System.Windows.Forms.TextBox UserId1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TotalOrCo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox UsedCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}