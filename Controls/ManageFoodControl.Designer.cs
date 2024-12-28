namespace Movie_Booking_System.Controls
{
    partial class ManageFoodControl
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
            this.panelmngfood = new System.Windows.Forms.Panel();
            this.btnManageOrders = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.panelmngfood.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmngfood
            // 
            this.panelmngfood.BackColor = System.Drawing.Color.Transparent;
            this.panelmngfood.Controls.Add(this.btnManageOrders);
            this.panelmngfood.Controls.Add(this.btnInventory);
            this.panelmngfood.Location = new System.Drawing.Point(0, 250);
            this.panelmngfood.Name = "panelmngfood";
            this.panelmngfood.Size = new System.Drawing.Size(250, 500);
            this.panelmngfood.TabIndex = 6;
            // 
            // btnManageOrders
            // 
            this.btnManageOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageOrders.BackColor = System.Drawing.Color.Transparent;
            this.btnManageOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageOrders.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageOrders.ForeColor = System.Drawing.Color.Teal;
            this.btnManageOrders.Location = new System.Drawing.Point(12, 127);
            this.btnManageOrders.Name = "btnManageOrders";
            this.btnManageOrders.Size = new System.Drawing.Size(196, 59);
            this.btnManageOrders.TabIndex = 4;
            this.btnManageOrders.Text = "Manage Orders.";
            this.btnManageOrders.UseVisualStyleBackColor = false;
            this.btnManageOrders.Click += new System.EventHandler(this.btnManageOrders_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.Teal;
            this.btnInventory.Location = new System.Drawing.Point(12, 192);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(196, 60);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "Manage Inventory.";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // ManageFoodControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelmngfood);
            this.Name = "ManageFoodControl";
            this.Size = new System.Drawing.Size(665, 781);
            this.panelmngfood.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmngfood;
        private System.Windows.Forms.Button btnManageOrders;
        private System.Windows.Forms.Button btnInventory;
    }
}
