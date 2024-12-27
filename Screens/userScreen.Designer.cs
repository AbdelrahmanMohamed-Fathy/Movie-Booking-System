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
            this.Helptickets = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
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
            this.panel1.Controls.Add(this.Helptickets);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 600);
            this.panel1.TabIndex = 1;
            // 
            // Helptickets
            // 
            this.Helptickets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Helptickets.FlatAppearance.BorderSize = 0;
            this.Helptickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Helptickets.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helptickets.ForeColor = System.Drawing.Color.MintCream;
            this.Helptickets.Image = ((System.Drawing.Image)(resources.GetObject("Helptickets.Image")));
            this.Helptickets.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Helptickets.Location = new System.Drawing.Point(2, 11);
            this.Helptickets.Margin = new System.Windows.Forms.Padding(2);
            this.Helptickets.Name = "Helptickets";
            this.Helptickets.Size = new System.Drawing.Size(129, 29);
            this.Helptickets.TabIndex = 2;
            this.Helptickets.Text = "Want to eat?";
            this.Helptickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Helptickets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Helptickets.UseVisualStyleBackColor = true;
            this.Helptickets.Click += new System.EventHandler(this.Helptickets_Click);
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
        private System.Windows.Forms.Button Helptickets;
    }
}