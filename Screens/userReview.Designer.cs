namespace Movie_Booking_System.Screens
{
    partial class userReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userReview));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.movieName = new System.Windows.Forms.Label();
            this.Star1 = new System.Windows.Forms.Label();
            this.Star2 = new System.Windows.Forms.Label();
            this.Star4 = new System.Windows.Forms.Label();
            this.Star3 = new System.Windows.Forms.Label();
            this.Star5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(328, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 118);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.label1.Font = new System.Drawing.Font("Impact", 18F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(374, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rate This";
            // 
            // movieName
            // 
            this.movieName.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieName.Location = new System.Drawing.Point(2, 166);
            this.movieName.Name = "movieName";
            this.movieName.Size = new System.Drawing.Size(776, 51);
            this.movieName.TabIndex = 3;
            this.movieName.Text = ".....";
            this.movieName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Star1
            // 
            this.Star1.AutoSize = true;
            this.Star1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Star1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Star1.Location = new System.Drawing.Point(214, 227);
            this.Star1.Name = "Star1";
            this.Star1.Size = new System.Drawing.Size(65, 63);
            this.Star1.TabIndex = 4;
            this.Star1.Text = "☆";
            this.Star1.Click += new System.EventHandler(this.Star1_Click);
            this.Star1.MouseEnter += new System.EventHandler(this.Star1_MouseEnter);
            this.Star1.MouseLeave += new System.EventHandler(this.Star1_MouseLeave);
            // 
            // Star2
            // 
            this.Star2.AutoSize = true;
            this.Star2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Star2.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Star2.Location = new System.Drawing.Point(285, 227);
            this.Star2.Name = "Star2";
            this.Star2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Star2.Size = new System.Drawing.Size(65, 63);
            this.Star2.TabIndex = 5;
            this.Star2.Text = "☆";
            this.Star2.Click += new System.EventHandler(this.Star2_Click);
            this.Star2.MouseEnter += new System.EventHandler(this.Star2_MouseEnter);
            this.Star2.MouseLeave += new System.EventHandler(this.Star2_MouseLeave);
            // 
            // Star4
            // 
            this.Star4.AutoSize = true;
            this.Star4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Star4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Star4.Location = new System.Drawing.Point(427, 227);
            this.Star4.Name = "Star4";
            this.Star4.Size = new System.Drawing.Size(65, 63);
            this.Star4.TabIndex = 6;
            this.Star4.Text = "☆";
            this.Star4.Click += new System.EventHandler(this.Star4_Click);
            this.Star4.MouseEnter += new System.EventHandler(this.Star4_MouseEnter);
            this.Star4.MouseLeave += new System.EventHandler(this.Star4_MouseLeave);
            // 
            // Star3
            // 
            this.Star3.AutoSize = true;
            this.Star3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Star3.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Star3.Location = new System.Drawing.Point(356, 227);
            this.Star3.Name = "Star3";
            this.Star3.Size = new System.Drawing.Size(65, 63);
            this.Star3.TabIndex = 7;
            this.Star3.Text = "☆";
            this.Star3.Click += new System.EventHandler(this.Star3_Click);
            this.Star3.MouseEnter += new System.EventHandler(this.Star3_MouseEnter);
            this.Star3.MouseLeave += new System.EventHandler(this.Star3_MouseLeave);
            // 
            // Star5
            // 
            this.Star5.AutoSize = true;
            this.Star5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Star5.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Star5.Location = new System.Drawing.Point(498, 227);
            this.Star5.Name = "Star5";
            this.Star5.Size = new System.Drawing.Size(65, 63);
            this.Star5.TabIndex = 8;
            this.Star5.Text = "☆";
            this.Star5.Click += new System.EventHandler(this.Star5_Click);
            this.Star5.MouseEnter += new System.EventHandler(this.Star5_MouseEnter);
            this.Star5.MouseLeave += new System.EventHandler(this.Star5_MouseLeave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Submit Rating";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // userReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Star5);
            this.Controls.Add(this.Star3);
            this.Controls.Add(this.Star4);
            this.Controls.Add(this.Star2);
            this.Controls.Add(this.Star1);
            this.Controls.Add(this.movieName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userReview";
            this.Text = "userReview";
            this.Load += new System.EventHandler(this.userReview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label movieName;
        private System.Windows.Forms.Label Star1;
        private System.Windows.Forms.Label Star2;
        private System.Windows.Forms.Label Star4;
        private System.Windows.Forms.Label Star3;
        private System.Windows.Forms.Label Star5;
        private System.Windows.Forms.Button button1;
    }
}