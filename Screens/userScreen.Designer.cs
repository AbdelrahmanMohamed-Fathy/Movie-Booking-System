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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.placeHolderTextBox1 = new Movie_Booking_System.Controls.PlaceHolderTextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Silver;
            this.textBox1.Location = new System.Drawing.Point(452, 83);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 29);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Enter Movie Name";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // placeHolderTextBox1
            // 
            this.placeHolderTextBox1.AutoSize = true;
            this.placeHolderTextBox1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Italic);
            this.placeHolderTextBox1.ForeColor = System.Drawing.Color.Black;
            this.placeHolderTextBox1.Location = new System.Drawing.Point(248, 201);
            this.placeHolderTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.placeHolderTextBox1.MaximumSize = new System.Drawing.Size(22300, 29);
            this.placeHolderTextBox1.MinimumSize = new System.Drawing.Size(0, 29);
            this.placeHolderTextBox1.Name = "placeHolderTextBox1";
            this.placeHolderTextBox1.PlaceHolderText = "Username";
            this.placeHolderTextBox1.PlaceHolderTextColor = System.Drawing.Color.Silver;
            this.placeHolderTextBox1.Size = new System.Drawing.Size(170, 29);
            this.placeHolderTextBox1.TabIndex = 4;
            this.placeHolderTextBox1.TextChanged += new System.EventHandler(this.placeHolderTextBox1_TextChanged);
            this.placeHolderTextBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.placeHolderTextBox1_KeyPress);
            // 
            // userScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.placeHolderTextBox1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userScreen";
            this.Text = "userScreen";
            this.Load += new System.EventHandler(this.userScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private Controls.PlaceHolderTextBox placeHolderTextBox1;
        private System.Windows.Forms.Label label1;
    }
}