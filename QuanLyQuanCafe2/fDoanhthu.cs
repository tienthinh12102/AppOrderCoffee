using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe2
{
    public partial class fDoanhthu : Form
    {
        public fDoanhthu()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpk1.Value = new DateTime(today.Year, today.Month, 1); //chuyển về đầu tháng
            dtpk2.Value = dtpk1.Value.AddMonths(1).AddDays(-1);
        }

        private void fDoanhthu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanLyQuanCafeDataSet4.USP_GetListBillByDateReport' table. You can move, or remove it, as needed.
            this.USP_GetListBillByDateReportTableAdapter.Fill(this.QuanLyQuanCafeDataSet4.USP_GetListBillByDateReport, dtpk1.Value, dtpk2.Value);

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            USP_GetListBillByDateReportTableAdapter.Fill(QuanLyQuanCafeDataSet4.USP_GetListBillByDateReport, dtpk1.Value, dtpk2.Value);
            reportViewer1.RefreshReport();
        }
    }
}
