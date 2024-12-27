namespace Movie_Booking_System.Screens.AdminScreens
{
    partial class adminDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminDashBoard));
            this.Menuicon = new System.Windows.Forms.Label();
            this.AdminMenu = new System.Windows.Forms.Panel();
            this.Helptickets = new System.Windows.Forms.Button();
            this.btnManageAcc = new System.Windows.Forms.Button();
            this.btnManageCinemas = new System.Windows.Forms.Button();
            this.AdminMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menuicon
            // 
            this.Menuicon.BackColor = System.Drawing.Color.Teal;
            this.Menuicon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menuicon.Image = ((System.Drawing.Image)(resources.GetObject("Menuicon.Image")));
            this.Menuicon.Location = new System.Drawing.Point(155, 9);
            this.Menuicon.Name = "Menuicon";
            this.Menuicon.Size = new System.Drawing.Size(34, 34);
            this.Menuicon.TabIndex = 0;
            this.Menuicon.Click += new System.EventHandler(this.Menuicon_Click);
            // 
            // AdminMenu
            // 
            this.AdminMenu.BackColor = System.Drawing.Color.Teal;
            this.AdminMenu.Controls.Add(this.btnManageCinemas);
            this.AdminMenu.Controls.Add(this.btnManageAcc);
            this.AdminMenu.Controls.Add(this.Helptickets);
            this.AdminMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdminMenu.Location = new System.Drawing.Point(0, 0);
            this.AdminMenu.Name = "AdminMenu";
            this.AdminMenu.Size = new System.Drawing.Size(211, 553);
            this.AdminMenu.TabIndex = 1;
            // 
            // Helptickets
            // 
            this.Helptickets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Helptickets.FlatAppearance.BorderSize = 0;
            this.Helptickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Helptickets.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helptickets.ForeColor = System.Drawing.Color.MintCream;
            this.Helptickets.Location = new System.Drawing.Point(3, 127);
            this.Helptickets.Name = "Helptickets";
            this.Helptickets.Size = new System.Drawing.Size(198, 36);
            this.Helptickets.TabIndex = 1;
            this.Helptickets.Text = "Help Tickets.";
            this.Helptickets.UseVisualStyleBackColor = true;
            // 
            // btnManageAcc
            // 
            this.btnManageAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageAcc.FlatAppearance.BorderSize = 0;
            this.btnManageAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAcc.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAcc.ForeColor = System.Drawing.Color.MintCream;
            this.btnManageAcc.Location = new System.Drawing.Point(3, 236);
            this.btnManageAcc.Name = "btnManageAcc";
            this.btnManageAcc.Size = new System.Drawing.Size(198, 36);
            this.btnManageAcc.TabIndex = 2;
            this.btnManageAcc.Text = "Manage Accounts.";
            this.btnManageAcc.UseVisualStyleBackColor = true;
            // 
            // btnManageCinemas
            // 
            this.btnManageCinemas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageCinemas.FlatAppearance.BorderSize = 0;
            this.btnManageCinemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCinemas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCinemas.ForeColor = System.Drawing.Color.MintCream;
            this.btnManageCinemas.Location = new System.Drawing.Point(3, 365);
            this.btnManageCinemas.Name = "btnManageCinemas";
            this.btnManageCinemas.Size = new System.Drawing.Size(198, 36);
            this.btnManageCinemas.TabIndex = 3;
            this.btnManageCinemas.Text = "Manage Cinemas.";
            this.btnManageCinemas.UseVisualStyleBackColor = true;
            // 
            // adminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.Menuicon);
            this.Controls.Add(this.AdminMenu);
            this.Name = "adminDashBoard";
            this.Text = "adminDashBoard";
            this.AdminMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Menuicon;
        private System.Windows.Forms.Panel AdminMenu;
        private System.Windows.Forms.Button btnManageCinemas;
        private System.Windows.Forms.Button btnManageAcc;
        private System.Windows.Forms.Button Helptickets;
    }
}