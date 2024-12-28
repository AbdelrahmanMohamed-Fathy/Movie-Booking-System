namespace Movie_Booking_System.Controls
{
    partial class manageinventorymenu
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
            this.datagridallfood = new System.Windows.Forms.DataGridView();
            this.cmbxFoodID = new System.Windows.Forms.ComboBox();
            this.btnAddFoodItm = new System.Windows.Forms.Button();
            this.btnRemoveFooditm = new System.Windows.Forms.Button();
            this.btnUpdateFooditm = new System.Windows.Forms.Button();
            this.txtbxdesc = new System.Windows.Forms.TextBox();
            this.lblfooddesc = new System.Windows.Forms.Label();
            this.txtbxprice = new Movie_Booking_System.Controls.PlaceHolderTextBox();
            this.txtbxqty = new Movie_Booking_System.Controls.PlaceHolderTextBox();
            this.txtbxfoodname = new Movie_Booking_System.Controls.PlaceHolderTextBox();
            this.txtbxnewqty = new Movie_Booking_System.Controls.PlaceHolderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridallfood)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridallfood
            // 
            this.datagridallfood.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.datagridallfood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridallfood.Dock = System.Windows.Forms.DockStyle.Right;
            this.datagridallfood.GridColor = System.Drawing.Color.Teal;
            this.datagridallfood.Location = new System.Drawing.Point(384, 0);
            this.datagridallfood.Name = "datagridallfood";
            this.datagridallfood.RowHeadersWidth = 51;
            this.datagridallfood.RowTemplate.Height = 24;
            this.datagridallfood.Size = new System.Drawing.Size(474, 802);
            this.datagridallfood.TabIndex = 3;
            // 
            // cmbxFoodID
            // 
            this.cmbxFoodID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbxFoodID.BackColor = System.Drawing.Color.MintCream;
            this.cmbxFoodID.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxFoodID.ForeColor = System.Drawing.Color.Gray;
            this.cmbxFoodID.FormattingEnabled = true;
            this.cmbxFoodID.Location = new System.Drawing.Point(74, 378);
            this.cmbxFoodID.Name = "cmbxFoodID";
            this.cmbxFoodID.Size = new System.Drawing.Size(169, 32);
            this.cmbxFoodID.TabIndex = 8;
            this.cmbxFoodID.Text = "Food ID.";
            // 
            // btnAddFoodItm
            // 
            this.btnAddFoodItm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddFoodItm.BackColor = System.Drawing.Color.Transparent;
            this.btnAddFoodItm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFoodItm.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFoodItm.ForeColor = System.Drawing.Color.Teal;
            this.btnAddFoodItm.Location = new System.Drawing.Point(74, 487);
            this.btnAddFoodItm.Name = "btnAddFoodItm";
            this.btnAddFoodItm.Size = new System.Drawing.Size(171, 60);
            this.btnAddFoodItm.TabIndex = 13;
            this.btnAddFoodItm.Text = "Add Food Item.";
            this.btnAddFoodItm.UseVisualStyleBackColor = false;
            this.btnAddFoodItm.Click += new System.EventHandler(this.btnAddFoodItm_Click);
            // 
            // btnRemoveFooditm
            // 
            this.btnRemoveFooditm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemoveFooditm.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveFooditm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFooditm.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveFooditm.ForeColor = System.Drawing.Color.Teal;
            this.btnRemoveFooditm.Location = new System.Drawing.Point(74, 646);
            this.btnRemoveFooditm.Name = "btnRemoveFooditm";
            this.btnRemoveFooditm.Size = new System.Drawing.Size(171, 60);
            this.btnRemoveFooditm.TabIndex = 12;
            this.btnRemoveFooditm.Text = "Remove Food Item.";
            this.btnRemoveFooditm.UseVisualStyleBackColor = false;
            this.btnRemoveFooditm.Click += new System.EventHandler(this.btnRemoveFooditm_Click);
            // 
            // btnUpdateFooditm
            // 
            this.btnUpdateFooditm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdateFooditm.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateFooditm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateFooditm.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateFooditm.ForeColor = System.Drawing.Color.Teal;
            this.btnUpdateFooditm.Location = new System.Drawing.Point(74, 566);
            this.btnUpdateFooditm.Name = "btnUpdateFooditm";
            this.btnUpdateFooditm.Size = new System.Drawing.Size(171, 60);
            this.btnUpdateFooditm.TabIndex = 14;
            this.btnUpdateFooditm.Text = "Update Food Item.";
            this.btnUpdateFooditm.UseVisualStyleBackColor = false;
            this.btnUpdateFooditm.Click += new System.EventHandler(this.btnUpdateFooditm_Click);
            // 
            // txtbxdesc
            // 
            this.txtbxdesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxdesc.BackColor = System.Drawing.Color.MintCream;
            this.txtbxdesc.Location = new System.Drawing.Point(44, 271);
            this.txtbxdesc.Multiline = true;
            this.txtbxdesc.Name = "txtbxdesc";
            this.txtbxdesc.Size = new System.Drawing.Size(294, 101);
            this.txtbxdesc.TabIndex = 15;
            // 
            // lblfooddesc
            // 
            this.lblfooddesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblfooddesc.AutoSize = true;
            this.lblfooddesc.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfooddesc.ForeColor = System.Drawing.Color.Teal;
            this.lblfooddesc.Location = new System.Drawing.Point(40, 244);
            this.lblfooddesc.Name = "lblfooddesc";
            this.lblfooddesc.Size = new System.Drawing.Size(123, 24);
            this.lblfooddesc.TabIndex = 16;
            this.lblfooddesc.Text = "Food Description.";
            // 
            // txtbxprice
            // 
            this.txtbxprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxprice.AutoSize = true;
            this.txtbxprice.BackColor = System.Drawing.Color.MintCream;
            this.txtbxprice.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxprice.ForeColor = System.Drawing.Color.Black;
            this.txtbxprice.Location = new System.Drawing.Point(44, 214);
            this.txtbxprice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxprice.MaximumSize = new System.Drawing.Size(11600, 32);
            this.txtbxprice.MinimumSize = new System.Drawing.Size(0, 32);
            this.txtbxprice.Name = "txtbxprice";
            this.txtbxprice.PlaceHolderText = "Price.";
            this.txtbxprice.PlaceHolderTextColor = System.Drawing.Color.Silver;
            this.txtbxprice.Size = new System.Drawing.Size(116, 32);
            this.txtbxprice.TabIndex = 11;
            this.txtbxprice.UseSystemPasswordChar = false;
            // 
            // txtbxqty
            // 
            this.txtbxqty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxqty.AutoSize = true;
            this.txtbxqty.BackColor = System.Drawing.Color.MintCream;
            this.txtbxqty.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxqty.ForeColor = System.Drawing.Color.Black;
            this.txtbxqty.Location = new System.Drawing.Point(301, 179);
            this.txtbxqty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxqty.MaximumSize = new System.Drawing.Size(3700, 28);
            this.txtbxqty.MinimumSize = new System.Drawing.Size(0, 28);
            this.txtbxqty.Name = "txtbxqty";
            this.txtbxqty.PlaceHolderText = "Qty.";
            this.txtbxqty.PlaceHolderTextColor = System.Drawing.Color.Silver;
            this.txtbxqty.Size = new System.Drawing.Size(37, 28);
            this.txtbxqty.TabIndex = 10;
            this.txtbxqty.UseSystemPasswordChar = false;
            // 
            // txtbxfoodname
            // 
            this.txtbxfoodname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxfoodname.AutoSize = true;
            this.txtbxfoodname.BackColor = System.Drawing.Color.MintCream;
            this.txtbxfoodname.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxfoodname.ForeColor = System.Drawing.Color.Black;
            this.txtbxfoodname.Location = new System.Drawing.Point(44, 176);
            this.txtbxfoodname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxfoodname.MaximumSize = new System.Drawing.Size(25100, 32);
            this.txtbxfoodname.MinimumSize = new System.Drawing.Size(0, 32);
            this.txtbxfoodname.Name = "txtbxfoodname";
            this.txtbxfoodname.PlaceHolderText = "Food Item Name.";
            this.txtbxfoodname.PlaceHolderTextColor = System.Drawing.Color.Silver;
            this.txtbxfoodname.Size = new System.Drawing.Size(251, 32);
            this.txtbxfoodname.TabIndex = 9;
            this.txtbxfoodname.UseSystemPasswordChar = false;
            // 
            // txtbxnewqty
            // 
            this.txtbxnewqty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxnewqty.AutoSize = true;
            this.txtbxnewqty.BackColor = System.Drawing.Color.MintCream;
            this.txtbxnewqty.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxnewqty.ForeColor = System.Drawing.Color.Black;
            this.txtbxnewqty.Location = new System.Drawing.Point(74, 417);
            this.txtbxnewqty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbxnewqty.MaximumSize = new System.Drawing.Size(3700, 28);
            this.txtbxnewqty.MinimumSize = new System.Drawing.Size(0, 28);
            this.txtbxnewqty.Name = "txtbxnewqty";
            this.txtbxnewqty.PlaceHolderText = "New Qty.";
            this.txtbxnewqty.PlaceHolderTextColor = System.Drawing.Color.Silver;
            this.txtbxnewqty.Size = new System.Drawing.Size(169, 28);
            this.txtbxnewqty.TabIndex = 17;
            this.txtbxnewqty.UseSystemPasswordChar = false;
            // 
            // manageinventorymenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.txtbxnewqty);
            this.Controls.Add(this.lblfooddesc);
            this.Controls.Add(this.txtbxdesc);
            this.Controls.Add(this.btnUpdateFooditm);
            this.Controls.Add(this.btnAddFoodItm);
            this.Controls.Add(this.btnRemoveFooditm);
            this.Controls.Add(this.txtbxprice);
            this.Controls.Add(this.txtbxqty);
            this.Controls.Add(this.txtbxfoodname);
            this.Controls.Add(this.cmbxFoodID);
            this.Controls.Add(this.datagridallfood);
            this.Name = "manageinventorymenu";
            this.Size = new System.Drawing.Size(858, 802);
            ((System.ComponentModel.ISupportInitialize)(this.datagridallfood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridallfood;
        private System.Windows.Forms.ComboBox cmbxFoodID;
        private PlaceHolderTextBox txtbxfoodname;
        private PlaceHolderTextBox txtbxqty;
        private PlaceHolderTextBox txtbxprice;
        private System.Windows.Forms.Button btnAddFoodItm;
        private System.Windows.Forms.Button btnRemoveFooditm;
        private System.Windows.Forms.Button btnUpdateFooditm;
        private System.Windows.Forms.TextBox txtbxdesc;
        private System.Windows.Forms.Label lblfooddesc;
        private PlaceHolderTextBox txtbxnewqty;
    }
}
