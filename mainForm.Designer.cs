﻿namespace Movie_Booking_System
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnGoBack = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.mainPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(772, 495);
            this.mainPanel.TabIndex = 0;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.SystemColors.Control;
            this.btnGoBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoBack.Image = ((System.Drawing.Image)(resources.GetObject("btnGoBack.Image")));
            this.btnGoBack.Location = new System.Drawing.Point(8, 6);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(32, 32);
            this.btnGoBack.TabIndex = 1;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // mainForm
            // 
            this.ClientSize = new System.Drawing.Size(772, 495);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.Text = "Movie Booking System";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label btnGoBack;
    }
}

