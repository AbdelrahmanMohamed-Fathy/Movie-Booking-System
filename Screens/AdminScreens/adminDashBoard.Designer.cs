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
            this.btnManageCinemas = new System.Windows.Forms.Button();
            this.btnManageAcc = new System.Windows.Forms.Button();
            this.Helptickets = new System.Windows.Forms.Button();
            this.lblHelpTicket = new System.Windows.Forms.Label();
            this.lblManageAcc = new System.Windows.Forms.Label();
            this.lblManageCinemas = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menuicon
            // 
            this.Menuicon.BackColor = System.Drawing.Color.Teal;
            this.Menuicon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Menuicon.Image = ((System.Drawing.Image)(resources.GetObject("Menuicon.Image")));
            this.Menuicon.Location = new System.Drawing.Point(82, 12);
            this.Menuicon.Name = "Menuicon";
            this.Menuicon.Size = new System.Drawing.Size(40, 39);
            this.Menuicon.TabIndex = 0;
            this.Menuicon.Click += new System.EventHandler(this.Menuicon_Click);
            // 
            // AdminMenu
            // 
            this.AdminMenu.BackColor = System.Drawing.Color.Teal;
            this.AdminMenu.Controls.Add(this.lblManageCinemas);
            this.AdminMenu.Controls.Add(this.lblManageAcc);
            this.AdminMenu.Controls.Add(this.lblHelpTicket);
            this.AdminMenu.Controls.Add(this.btnManageCinemas);
            this.AdminMenu.Controls.Add(this.btnManageAcc);
            this.AdminMenu.Controls.Add(this.Helptickets);
            this.AdminMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdminMenu.Location = new System.Drawing.Point(0, 0);
            this.AdminMenu.Name = "AdminMenu";
            this.AdminMenu.Size = new System.Drawing.Size(265, 553);
            this.AdminMenu.TabIndex = 1;
            // 
            // btnManageCinemas
            // 
            this.btnManageCinemas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageCinemas.FlatAppearance.BorderSize = 0;
            this.btnManageCinemas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCinemas.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCinemas.ForeColor = System.Drawing.Color.MintCream;
            this.btnManageCinemas.Location = new System.Drawing.Point(64, 365);
            this.btnManageCinemas.Name = "btnManageCinemas";
            this.btnManageCinemas.Size = new System.Drawing.Size(198, 36);
            this.btnManageCinemas.TabIndex = 3;
            this.btnManageCinemas.Text = "Manage Cinemas.";
            this.btnManageCinemas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageCinemas.UseVisualStyleBackColor = true;
            // 
            // btnManageAcc
            // 
            this.btnManageAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageAcc.FlatAppearance.BorderSize = 0;
            this.btnManageAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAcc.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAcc.ForeColor = System.Drawing.Color.MintCream;
            this.btnManageAcc.Location = new System.Drawing.Point(64, 236);
            this.btnManageAcc.Name = "btnManageAcc";
            this.btnManageAcc.Size = new System.Drawing.Size(198, 36);
            this.btnManageAcc.TabIndex = 2;
            this.btnManageAcc.Text = "Manage Accounts.";
            this.btnManageAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageAcc.UseVisualStyleBackColor = true;
            // 
            // Helptickets
            // 
            this.Helptickets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Helptickets.FlatAppearance.BorderSize = 0;
            this.Helptickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Helptickets.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helptickets.ForeColor = System.Drawing.Color.MintCream;
            this.Helptickets.Location = new System.Drawing.Point(64, 126);
            this.Helptickets.Name = "Helptickets";
            this.Helptickets.Size = new System.Drawing.Size(198, 36);
            this.Helptickets.TabIndex = 1;
            this.Helptickets.Text = "Help Tickets.";
            this.Helptickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Helptickets.UseVisualStyleBackColor = true;
            // 
            // lblHelpTicket
            // 
            this.lblHelpTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHelpTicket.Image = ((System.Drawing.Image)(resources.GetObject("lblHelpTicket.Image")));
            this.lblHelpTicket.Location = new System.Drawing.Point(19, 125);
            this.lblHelpTicket.Name = "lblHelpTicket";
            this.lblHelpTicket.Size = new System.Drawing.Size(39, 37);
            this.lblHelpTicket.TabIndex = 4;
            // 
            // lblManageAcc
            // 
            this.lblManageAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblManageAcc.Image = ((System.Drawing.Image)(resources.GetObject("lblManageAcc.Image")));
            this.lblManageAcc.Location = new System.Drawing.Point(19, 235);
            this.lblManageAcc.Name = "lblManageAcc";
            this.lblManageAcc.Size = new System.Drawing.Size(39, 37);
            this.lblManageAcc.TabIndex = 5;
            // 
            // lblManageCinemas
            // 
            this.lblManageCinemas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblManageCinemas.Image = ((System.Drawing.Image)(resources.GetObject("lblManageCinemas.Image")));
            this.lblManageCinemas.Location = new System.Drawing.Point(19, 364);
            this.lblManageCinemas.Name = "lblManageCinemas";
            this.lblManageCinemas.Size = new System.Drawing.Size(39, 37);
            this.lblManageCinemas.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(264, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 553);
            this.panel1.TabIndex = 2;
            // 
            // adminDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.Label lblManageAcc;
        private System.Windows.Forms.Label lblHelpTicket;
        private System.Windows.Forms.Label lblManageCinemas;
        private System.Windows.Forms.Panel panel1;
    }
}