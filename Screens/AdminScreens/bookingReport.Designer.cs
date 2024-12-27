namespace Movie_Booking_System.Screens.AdminScreens
{
    partial class bookingReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportsData = new Movie_Booking_System.ReportsData();
            this.bookingStatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingStatsTableAdapter = new Movie_Booking_System.ReportsDataTableAdapters.BookingStatsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingStatsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bookingStatsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Movie_Booking_System.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportsData
            // 
            this.reportsData.DataSetName = "ReportsData";
            this.reportsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookingStatsBindingSource
            // 
            this.bookingStatsBindingSource.DataMember = "BookingStats";
            this.bookingStatsBindingSource.DataSource = this.reportsData;
            // 
            // bookingStatsTableAdapter
            // 
            this.bookingStatsTableAdapter.ClearBeforeFill = true;
            // 
            // bookingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "bookingReport";
            this.Text = "bookingReport";
            this.Load += new System.EventHandler(this.bookingReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingStatsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportsData reportsData;
        private System.Windows.Forms.BindingSource bookingStatsBindingSource;
        private ReportsDataTableAdapters.BookingStatsTableAdapter bookingStatsTableAdapter;
    }
}