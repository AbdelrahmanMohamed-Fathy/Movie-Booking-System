namespace Movie_Booking_System.Screens
{
    partial class userScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userScreen));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOrderFood = new System.Windows.Forms.Button();
            this.btnHelpTicket = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.MintCream;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(145, 11);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(644, 578);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnHelpTicket);
            this.panel1.Controls.Add(this.btnOrderFood);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 600);
            this.panel1.TabIndex = 1;
            // 
            // btnOrderFood
            // 
            this.btnOrderFood.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOrderFood.FlatAppearance.BorderSize = 0;
            this.btnOrderFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderFood.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderFood.ForeColor = System.Drawing.Color.MintCream;
            this.btnOrderFood.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderFood.Image")));
            this.btnOrderFood.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOrderFood.Location = new System.Drawing.Point(2, 11);
            this.btnOrderFood.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderFood.Name = "btnOrderFood";
            this.btnOrderFood.Size = new System.Drawing.Size(129, 29);
            this.btnOrderFood.TabIndex = 2;
            this.btnOrderFood.Text = "Want to eat?";
            this.btnOrderFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrderFood.UseVisualStyleBackColor = true;
            this.btnOrderFood.Click += new System.EventHandler(this.btnOrderFood_Click);
            // 
            // btnHelpTicket
            // 
            this.btnHelpTicket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHelpTicket.FlatAppearance.BorderSize = 0;
            this.btnHelpTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelpTicket.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelpTicket.ForeColor = System.Drawing.Color.MintCream;
            this.btnHelpTicket.Image = ((System.Drawing.Image)(resources.GetObject("btnHelpTicket.Image")));
            this.btnHelpTicket.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnHelpTicket.Location = new System.Drawing.Point(2, 87);
            this.btnHelpTicket.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelpTicket.Name = "btnHelpTicket";
            this.btnHelpTicket.Size = new System.Drawing.Size(129, 29);
            this.btnHelpTicket.TabIndex = 3;
            this.btnHelpTicket.Text = " Need Help?";
            this.btnHelpTicket.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelpTicket.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelpTicket.UseVisualStyleBackColor = true;
            this.btnHelpTicket.Click += new System.EventHandler(this.btnHelpTicket_Click);
            // 
            // userScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userScreen";
            this.Text = "userScreen";
            this.Load += new System.EventHandler(this.userScreen_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOrderFood;
        private System.Windows.Forms.Button btnHelpTicket;
    }
}