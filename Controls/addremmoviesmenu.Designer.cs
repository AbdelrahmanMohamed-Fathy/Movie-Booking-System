namespace Movie_Booking_System.Controls
{
    partial class addremmoviesmenu
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
            this.components = new System.ComponentModel.Container();
            this.lblfooddesc = new System.Windows.Forms.Label();
            this.txtbxdesc = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.btnRemMovie = new System.Windows.Forms.Button();
            this.txtbxMovieName = new Movie_Booking_System.Controls.PlaceHolderTextBox();
            this.datagridallmovies = new System.Windows.Forms.DataGridView();
            this.cmbxMovieID = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtbxdirector = new Movie_Booking_System.Controls.PlaceHolderTextBox();
            this.lblruntime = new Movie_Booking_System.Controls.PlaceHolderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridallmovies)).BeginInit();
            this.SuspendLayout();
            // 
            // lblfooddesc
            // 
            this.lblfooddesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblfooddesc.AutoSize = true;
            this.lblfooddesc.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfooddesc.ForeColor = System.Drawing.Color.Teal;
            this.lblfooddesc.Location = new System.Drawing.Point(32, 198);
            this.lblfooddesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfooddesc.Name = "lblfooddesc";
            this.lblfooddesc.Size = new System.Drawing.Size(104, 19);
            this.lblfooddesc.TabIndex = 27;
            this.lblfooddesc.Text = "Movie Description.";
            // 
            // txtbxdesc
            // 
            this.txtbxdesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxdesc.BackColor = System.Drawing.Color.MintCream;
            this.txtbxdesc.Location = new System.Drawing.Point(34, 220);
            this.txtbxdesc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbxdesc.Multiline = true;
            this.txtbxdesc.Name = "txtbxdesc";
            this.txtbxdesc.Size = new System.Drawing.Size(189, 83);
            this.txtbxdesc.TabIndex = 26;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnAddMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMovie.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.ForeColor = System.Drawing.Color.Teal;
            this.btnAddMovie.Location = new System.Drawing.Point(56, 379);
            this.btnAddMovie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(128, 49);
            this.btnAddMovie.TabIndex = 24;
            this.btnAddMovie.Text = "Add Food Item.";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // btnRemMovie
            // 
            this.btnRemMovie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRemMovie.BackColor = System.Drawing.Color.Transparent;
            this.btnRemMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemMovie.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemMovie.ForeColor = System.Drawing.Color.Teal;
            this.btnRemMovie.Location = new System.Drawing.Point(56, 432);
            this.btnRemMovie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemMovie.Name = "btnRemMovie";
            this.btnRemMovie.Size = new System.Drawing.Size(128, 49);
            this.btnRemMovie.TabIndex = 23;
            this.btnRemMovie.Text = "Remove Food Item.";
            this.btnRemMovie.UseVisualStyleBackColor = false;
            this.btnRemMovie.Click += new System.EventHandler(this.btnRemMovie_Click);
            // 
            // txtbxMovieName
            // 
            this.txtbxMovieName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxMovieName.AutoSize = true;
            this.txtbxMovieName.BackColor = System.Drawing.Color.MintCream;
            this.txtbxMovieName.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMovieName.ForeColor = System.Drawing.Color.Black;
            this.txtbxMovieName.Location = new System.Drawing.Point(34, 99);
            this.txtbxMovieName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtbxMovieName.MaximumSize = new System.Drawing.Size(18825, 26);
            this.txtbxMovieName.MinimumSize = new System.Drawing.Size(0, 26);
            this.txtbxMovieName.Name = "txtbxMovieName";
            this.txtbxMovieName.PlaceHolderText = "Movie Name.";
            this.txtbxMovieName.PlaceHolderTextColor = System.Drawing.Color.Silver;
            this.txtbxMovieName.Size = new System.Drawing.Size(188, 26);
            this.txtbxMovieName.TabIndex = 20;
            this.txtbxMovieName.UseSystemPasswordChar = false;
            // 
            // datagridallmovies
            // 
            this.datagridallmovies.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.datagridallmovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridallmovies.Dock = System.Windows.Forms.DockStyle.Right;
            this.datagridallmovies.GridColor = System.Drawing.Color.Teal;
            this.datagridallmovies.Location = new System.Drawing.Point(288, 0);
            this.datagridallmovies.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datagridallmovies.Name = "datagridallmovies";
            this.datagridallmovies.RowHeadersWidth = 51;
            this.datagridallmovies.RowTemplate.Height = 24;
            this.datagridallmovies.Size = new System.Drawing.Size(356, 604);
            this.datagridallmovies.TabIndex = 18;
            this.datagridallmovies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridallmovies_CellContentClick);
            // 
            // cmbxMovieID
            // 
            this.cmbxMovieID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbxMovieID.BackColor = System.Drawing.Color.MintCream;
            this.cmbxMovieID.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxMovieID.ForeColor = System.Drawing.Color.Gray;
            this.cmbxMovieID.FormattingEnabled = true;
            this.cmbxMovieID.Location = new System.Drawing.Point(56, 307);
            this.cmbxMovieID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbxMovieID.Name = "cmbxMovieID";
            this.cmbxMovieID.Size = new System.Drawing.Size(128, 27);
            this.cmbxMovieID.TabIndex = 19;
            this.cmbxMovieID.Text = "Movie ID.";
            // 
            // txtbxdirector
            // 
            this.txtbxdirector.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtbxdirector.AutoSize = true;
            this.txtbxdirector.BackColor = System.Drawing.Color.MintCream;
            this.txtbxdirector.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxdirector.ForeColor = System.Drawing.Color.Black;
            this.txtbxdirector.Location = new System.Drawing.Point(34, 128);
            this.txtbxdirector.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.txtbxdirector.MaximumSize = new System.Drawing.Size(21525, 26);
            this.txtbxdirector.MinimumSize = new System.Drawing.Size(0, 26);
            this.txtbxdirector.Name = "txtbxdirector";
            this.txtbxdirector.PlaceHolderText = "Director.";
            this.txtbxdirector.PlaceHolderTextColor = System.Drawing.Color.Silver;
            this.txtbxdirector.Size = new System.Drawing.Size(188, 26);
            this.txtbxdirector.TabIndex = 21;
            this.txtbxdirector.UseSystemPasswordChar = false;
            // 
            // lblruntime
            // 
            this.lblruntime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblruntime.AutoSize = true;
            this.lblruntime.BackColor = System.Drawing.Color.MintCream;
            this.lblruntime.Font = new System.Drawing.Font("Bahnschrift SemiBold Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblruntime.ForeColor = System.Drawing.Color.Black;
            this.lblruntime.Location = new System.Drawing.Point(34, 156);
            this.lblruntime.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.lblruntime.MaximumSize = new System.Drawing.Size(21525, 26);
            this.lblruntime.MinimumSize = new System.Drawing.Size(0, 26);
            this.lblruntime.Name = "lblruntime";
            this.lblruntime.PlaceHolderText = "Director.";
            this.lblruntime.PlaceHolderTextColor = System.Drawing.Color.Silver;
            this.lblruntime.Size = new System.Drawing.Size(188, 26);
            this.lblruntime.TabIndex = 30;
            this.lblruntime.UseSystemPasswordChar = false;
            // 
            // addremmoviesmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(236)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.lblruntime);
            this.Controls.Add(this.lblfooddesc);
            this.Controls.Add(this.txtbxdesc);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.btnRemMovie);
            this.Controls.Add(this.txtbxdirector);
            this.Controls.Add(this.txtbxMovieName);
            this.Controls.Add(this.cmbxMovieID);
            this.Controls.Add(this.datagridallmovies);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "addremmoviesmenu";
            this.Size = new System.Drawing.Size(644, 604);
            ((System.ComponentModel.ISupportInitialize)(this.datagridallmovies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblfooddesc;
        private System.Windows.Forms.TextBox txtbxdesc;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button btnRemMovie;
        private PlaceHolderTextBox txtbxMovieName;
        private System.Windows.Forms.DataGridView datagridallmovies;
        private System.Windows.Forms.ComboBox cmbxMovieID;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private PlaceHolderTextBox txtbxdirector;
        private PlaceHolderTextBox lblruntime;
    }
}
