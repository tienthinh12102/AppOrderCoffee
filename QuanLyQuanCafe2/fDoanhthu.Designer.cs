namespace QuanLyQuanCafe2
{
    partial class fDoanhthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDoanhthu));
            this.USP_GetListBillByDateReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyQuanCafeDataSet4 = new QuanLyQuanCafe2.QuanLyQuanCafeDataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_GetListBillByDateReportTableAdapter = new QuanLyQuanCafe2.QuanLyQuanCafeDataSet4TableAdapters.USP_GetListBillByDateReportTableAdapter();
            this.dtpk1 = new System.Windows.Forms.DateTimePicker();
            this.dtpk2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyQuanCafeDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // USP_GetListBillByDateReportBindingSource
            // 
            this.USP_GetListBillByDateReportBindingSource.DataMember = "USP_GetListBillByDateReport";
            this.USP_GetListBillByDateReportBindingSource.DataSource = this.QuanLyQuanCafeDataSet4;
            // 
            // QuanLyQuanCafeDataSet4
            // 
            this.QuanLyQuanCafeDataSet4.DataSetName = "QuanLyQuanCafeDataSet4";
            this.QuanLyQuanCafeDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_GetListBillByDateReportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanCafe2.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // USP_GetListBillByDateReportTableAdapter
            // 
            this.USP_GetListBillByDateReportTableAdapter.ClearBeforeFill = true;
            // 
            // dtpk1
            // 
            this.dtpk1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpk1.Location = new System.Drawing.Point(0, 427);
            this.dtpk1.Name = "dtpk1";
            this.dtpk1.Size = new System.Drawing.Size(234, 22);
            this.dtpk1.TabIndex = 1;
            // 
            // dtpk2
            // 
            this.dtpk2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpk2.Location = new System.Drawing.Point(566, 427);
            this.dtpk2.Name = "dtpk2";
            this.dtpk2.Size = new System.Drawing.Size(233, 22);
            this.dtpk2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(355, 427);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fDoanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpk2);
            this.Controls.Add(this.dtpk1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fDoanhthu";
            this.Text = "Doanh thu";
            this.Load += new System.EventHandler(this.fDoanhthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyQuanCafeDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_GetListBillByDateReportBindingSource;
        private QuanLyQuanCafeDataSet4 QuanLyQuanCafeDataSet4;
        private QuanLyQuanCafeDataSet4TableAdapters.USP_GetListBillByDateReportTableAdapter USP_GetListBillByDateReportTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpk1;
        private System.Windows.Forms.DateTimePicker dtpk2;
        private System.Windows.Forms.Button button1;
    }
}