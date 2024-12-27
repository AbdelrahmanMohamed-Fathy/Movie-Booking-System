namespace Movie_Booking_System.Screens.AdminScreens
{
    partial class ordersReport
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
            this.reportsData = new Movie_Booking_System.ReportsData();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.foodStatsTableAdapter = new Movie_Booking_System.ReportsDataTableAdapters.FoodStatsTableAdapter();
            this.foodStatsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reportsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodStatsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportsData
            // 
            this.reportsData.DataSetName = "ReportsData";
            this.reportsData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.foodStatsBindingSource2;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Movie_Booking_System.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // foodStatsTableAdapter
            // 
            this.foodStatsTableAdapter.ClearBeforeFill = true;
            // 
            // foodStatsBindingSource2
            // 
            this.foodStatsBindingSource2.DataMember = "FoodStats";
            this.foodStatsBindingSource2.DataSource = this.reportsData;
            // 
            // ordersReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ordersReport";
            this.Text = "ordersReport";
            this.Load += new System.EventHandler(this.ordersReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodStatsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ReportsData reportsData;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ReportsDataTableAdapters.FoodStatsTableAdapter foodStatsTableAdapter;
        private System.Windows.Forms.BindingSource foodStatsBindingSource2;
    }
}