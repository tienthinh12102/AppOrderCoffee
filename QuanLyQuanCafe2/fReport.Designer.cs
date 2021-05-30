namespace QuanLyQuanCafe2
{
    partial class fReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fReport));
            this.USP_ThanhToanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyQuanCafeDataSet5 = new QuanLyQuanCafe2.QuanLyQuanCafeDataSet5();
            this.USP_GetListBillByDateReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QuanLyQuanCafeDataSet4 = new QuanLyQuanCafe2.QuanLyQuanCafeDataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.USP_GetListBillByDateReportTableAdapter = new QuanLyQuanCafe2.QuanLyQuanCafeDataSet4TableAdapters.USP_GetListBillByDateReportTableAdapter();
            this.USP_ThanhToanTableAdapter = new QuanLyQuanCafe2.QuanLyQuanCafeDataSet5TableAdapters.USP_ThanhToanTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ThanhToanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyQuanCafeDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyQuanCafeDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // USP_ThanhToanBindingSource
            // 
            this.USP_ThanhToanBindingSource.DataMember = "USP_ThanhToan";
            this.USP_ThanhToanBindingSource.DataSource = this.QuanLyQuanCafeDataSet5;
            // 
            // QuanLyQuanCafeDataSet5
            // 
            this.QuanLyQuanCafeDataSet5.DataSetName = "QuanLyQuanCafeDataSet5";
            this.QuanLyQuanCafeDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            reportDataSource1.Value = this.USP_ThanhToanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanCafe2.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(641, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // USP_GetListBillByDateReportTableAdapter
            // 
            this.USP_GetListBillByDateReportTableAdapter.ClearBeforeFill = true;
            // 
            // USP_ThanhToanTableAdapter
            // 
            this.USP_ThanhToanTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(127, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 423);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_ThanhToanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyQuanCafeDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_GetListBillByDateReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyQuanCafeDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_GetListBillByDateReportBindingSource;
        private QuanLyQuanCafeDataSet4 QuanLyQuanCafeDataSet4;
        private QuanLyQuanCafeDataSet4TableAdapters.USP_GetListBillByDateReportTableAdapter USP_GetListBillByDateReportTableAdapter;
        private System.Windows.Forms.BindingSource USP_ThanhToanBindingSource;
        private QuanLyQuanCafeDataSet5 QuanLyQuanCafeDataSet5;
        private QuanLyQuanCafeDataSet5TableAdapters.USP_ThanhToanTableAdapter USP_ThanhToanTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}