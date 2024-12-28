namespace Movie_Booking_System.Screens
{
    partial class employeeDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employeeDashBoard));
            this.AdminMenu = new System.Windows.Forms.Panel();
            this.lblManageAcc = new System.Windows.Forms.Label();
            this.lblHelpTicket = new System.Windows.Forms.Label();
            this.btnManageAcc = new System.Windows.Forms.Button();
            this.Helptickets = new System.Windows.Forms.Button();
            this.dashboardadmin = new System.Windows.Forms.Panel();
            this.AdminMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminMenu
            // 
            this.AdminMenu.BackColor = System.Drawing.Color.Teal;
            this.AdminMenu.Controls.Add(this.lblManageAcc);
            this.AdminMenu.Controls.Add(this.lblHelpTicket);
            this.AdminMenu.Controls.Add(this.btnManageAcc);
            this.AdminMenu.Controls.Add(this.Helptickets);
            this.AdminMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.AdminMenu.Location = new System.Drawing.Point(0, 0);
            this.AdminMenu.Margin = new System.Windows.Forms.Padding(2);
            this.AdminMenu.Name = "AdminMenu";
            this.AdminMenu.Size = new System.Drawing.Size(199, 600);
            this.AdminMenu.TabIndex = 2;
            // 
            // lblManageAcc
            // 
            this.lblManageAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblManageAcc.Image = ((System.Drawing.Image)(resources.GetObject("lblManageAcc.Image")));
            this.lblManageAcc.Location = new System.Drawing.Point(11, 373);
            this.lblManageAcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblManageAcc.Name = "lblManageAcc";
            this.lblManageAcc.Size = new System.Drawing.Size(29, 30);
            this.lblManageAcc.TabIndex = 5;
            // 
            // lblHelpTicket
            // 
            this.lblHelpTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHelpTicket.Image = ((System.Drawing.Image)(resources.GetObject("lblHelpTicket.Image")));
            this.lblHelpTicket.Location = new System.Drawing.Point(11, 181);
            this.lblHelpTicket.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHelpTicket.Name = "lblHelpTicket";
            this.lblHelpTicket.Size = new System.Drawing.Size(29, 30);
            this.lblHelpTicket.TabIndex = 4;
            // 
            // btnManageAcc
            // 
            this.btnManageAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnManageAcc.FlatAppearance.BorderSize = 0;
            this.btnManageAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageAcc.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAcc.ForeColor = System.Drawing.Color.MintCream;
            this.btnManageAcc.Location = new System.Drawing.Point(44, 373);
            this.btnManageAcc.Margin = new System.Windows.Forms.Padding(2);
            this.btnManageAcc.Name = "btnManageAcc";
            this.btnManageAcc.Size = new System.Drawing.Size(148, 29);
            this.btnManageAcc.TabIndex = 2;
            this.btnManageAcc.Text = "Fullfill Orders.";
            this.btnManageAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageAcc.UseVisualStyleBackColor = true;
            this.btnManageAcc.Click += new System.EventHandler(this.btnManageAcc_Click);
            // 
            // Helptickets
            // 
            this.Helptickets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Helptickets.FlatAppearance.BorderSize = 0;
            this.Helptickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Helptickets.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helptickets.ForeColor = System.Drawing.Color.MintCream;
            this.Helptickets.Location = new System.Drawing.Point(44, 182);
            this.Helptickets.Margin = new System.Windows.Forms.Padding(2);
            this.Helptickets.Name = "Helptickets";
            this.Helptickets.Size = new System.Drawing.Size(148, 29);
            this.Helptickets.TabIndex = 1;
            this.Helptickets.Text = "View Help Tickets.";
            this.Helptickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Helptickets.UseVisualStyleBackColor = true;
            this.Helptickets.Click += new System.EventHandler(this.Helptickets_Click);
            // 
            // dashboardadmin
            // 
            this.dashboardadmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dashboardadmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.dashboardadmin.Location = new System.Drawing.Point(200, 0);
            this.dashboardadmin.Margin = new System.Windows.Forms.Padding(2);
            this.dashboardadmin.Name = "dashboardadmin";
            this.dashboardadmin.Size = new System.Drawing.Size(601, 600);
            this.dashboardadmin.TabIndex = 3;
            // 
            // employeeDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dashboardadmin);
            this.Controls.Add(this.AdminMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employeeDashBoard";
            this.Text = "employeeDashBoard";
            this.AdminMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AdminMenu;
        private System.Windows.Forms.Label lblManageAcc;
        private System.Windows.Forms.Label lblHelpTicket;
        private System.Windows.Forms.Button btnManageAcc;
        private System.Windows.Forms.Button Helptickets;
        private System.Windows.Forms.Panel dashboardadmin;
    }
}