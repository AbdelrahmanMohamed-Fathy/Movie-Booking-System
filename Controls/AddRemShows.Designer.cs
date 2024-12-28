namespace Movie_Booking_System.Controls
{
    partial class AddRemShows
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
            this.txtboxstart = new Movie_Booking_System.Controls.PlaceHolderTextBox();
            this.btnAddShow = new System.Windows.Forms.Button();
            this.btnRemShow = new System.Windows.Forms.Button();
            this.txtbxcinematype = new Movie_Booking_System.Controls.PlaceHolderTextBox();
            this.txtbxMovieName = new Movie_Booking_System.Controls.PlaceHolderTextBox();
            this.datagridshows = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datagridshows)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxstart
            // 
            this.txtboxstart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtboxstart.AutoSize = true;
            this.txtboxstart.BackColor = System.Drawing.Color.MintCream;
            this.txtboxstart.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxstart.ForeColor = System.Drawing.Color.Black;
            this.txtboxstart.Location = new System.Drawing.Point(42, 231);
            this.txtboxstart.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtboxstart.MaximumSize = new System.Drawing.Size(21525, 26);
            this.txtboxstart.MinimumSize = new System.Drawing.Size(0, 26);
            this.txtboxstart.Name = "txtboxstart";
            this.txtboxstart.PlaceHolderText = "Start Time.";
            this.txtboxstart.PlaceHolderTextColor = System.Drawing.Color.Silver;
            this.txtboxstart.Size = new System.Drawing.Size(188, 26);
            this.txtboxstart.TabIndex = 38;
            this.txtboxstart.UseSystemPasswordChar = false;
            this.txtboxstart.TextChanged += new System.EventHandler(this.lblruntime_TextChanged);
            // 
            // btnAddShow
            // 
            this.btnAddShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddShow.BackColor = System.Drawing.Color.Transparent;
            this.btnAddShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShow.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddShow.ForeColor = System.Drawing.Color.Teal;
            this.btnAddShow.Location = new System.Drawing.Point(67, 280);
            this.btnAddShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddShow.Name = "btnAddShow";
            this.btnAddShow.Size = new System.Drawing.Size(128, 49);
            this.btnAddShow.TabIndex = 35;
            this.btnAddShow.Text = "Add Show.";
            this.btnAddShow.UseVisualStyleBackColor = false;
            // 
            // btnRemShow
            // 
            this.btnRemShow.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemShow.BackColor = System.Drawing.Color.Transparent;
            this.btnRemShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemShow.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemShow.ForeColor = System.Drawing.Color.Teal;
            this.btnRemShow.Location = new System.Drawing.Point(67, 333);
            this.btnRemShow.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemShow.Name = "btnRemShow";
            this.btnRemShow.Size = new System.Drawing.Size(128, 49);
            this.btnRemShow.TabIndex = 34;
            this.btnRemShow.Text = "Remove Show.";
            this.btnRemShow.UseVisualStyleBackColor = false;
            // 
            // txtbxcinematype
            // 
            this.txtbxcinematype.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxcinematype.AutoSize = true;
            this.txtbxcinematype.BackColor = System.Drawing.Color.MintCream;
            this.txtbxcinematype.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxcinematype.ForeColor = System.Drawing.Color.Black;
            this.txtbxcinematype.Location = new System.Drawing.Point(42, 203);
            this.txtbxcinematype.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtbxcinematype.MaximumSize = new System.Drawing.Size(21525, 26);
            this.txtbxcinematype.MinimumSize = new System.Drawing.Size(0, 26);
            this.txtbxcinematype.Name = "txtbxcinematype";
            this.txtbxcinematype.PlaceHolderText = "Cinema Type.";
            this.txtbxcinematype.PlaceHolderTextColor = System.Drawing.Color.Silver;
            this.txtbxcinematype.Size = new System.Drawing.Size(188, 26);
            this.txtbxcinematype.TabIndex = 33;
            this.txtbxcinematype.UseSystemPasswordChar = false;
            this.txtbxcinematype.TextChanged += new System.EventHandler(this.txtbxdirector_TextChanged);
            // 
            // txtbxMovieName
            // 
            this.txtbxMovieName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxMovieName.AutoSize = true;
            this.txtbxMovieName.BackColor = System.Drawing.Color.MintCream;
            this.txtbxMovieName.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMovieName.ForeColor = System.Drawing.Color.Black;
            this.txtbxMovieName.Location = new System.Drawing.Point(42, 174);
            this.txtbxMovieName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtbxMovieName.MaximumSize = new System.Drawing.Size(18825, 26);
            this.txtbxMovieName.MinimumSize = new System.Drawing.Size(0, 26);
            this.txtbxMovieName.Name = "txtbxMovieName";
            this.txtbxMovieName.PlaceHolderText = "Movie Name.";
            this.txtbxMovieName.PlaceHolderTextColor = System.Drawing.Color.Silver;
            this.txtbxMovieName.Size = new System.Drawing.Size(188, 26);
            this.txtbxMovieName.TabIndex = 32;
            this.txtbxMovieName.UseSystemPasswordChar = false;
            this.txtbxMovieName.TextChanged += new System.EventHandler(this.txtbxMovieName_TextChanged);
            // 
            // datagridshows
            // 
            this.datagridshows.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.datagridshows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridshows.Dock = System.Windows.Forms.DockStyle.Right;
            this.datagridshows.GridColor = System.Drawing.Color.Teal;
            this.datagridshows.Location = new System.Drawing.Point(267, 0);
            this.datagridshows.Margin = new System.Windows.Forms.Padding(2);
            this.datagridshows.Name = "datagridshows";
            this.datagridshows.RowHeadersWidth = 51;
            this.datagridshows.RowTemplate.Height = 24;
            this.datagridshows.Size = new System.Drawing.Size(356, 508);
            this.datagridshows.TabIndex = 39;
            // 
            // AddRemShows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.datagridshows);
            this.Controls.Add(this.txtboxstart);
            this.Controls.Add(this.btnAddShow);
            this.Controls.Add(this.btnRemShow);
            this.Controls.Add(this.txtbxcinematype);
            this.Controls.Add(this.txtbxMovieName);
            this.Name = "AddRemShows";
            this.Size = new System.Drawing.Size(623, 508);
            ((System.ComponentModel.ISupportInitialize)(this.datagridshows)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PlaceHolderTextBox txtboxstart;
        private System.Windows.Forms.Button btnAddShow;
        private System.Windows.Forms.Button btnRemShow;
        private PlaceHolderTextBox txtbxcinematype;
        private PlaceHolderTextBox txtbxMovieName;
        private System.Windows.Forms.DataGridView datagridshows;
    }
}
