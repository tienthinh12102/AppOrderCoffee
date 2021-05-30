using QuanLyQuanCafe2.DAO;
using QuanLyQuanCafe2.DTO;
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
    public partial class fReport : Form
    {
       
       

       
        public fReport()
        {
            InitializeComponent();
            LoadComboboxTable(comboBox1);
        }
        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }




        private void Report_Load(object sender, EventArgs e)
        {
            int id2 = (comboBox1.SelectedItem as Table).ID;
            // TODO: This line of code loads data into the 'QuanLyQuanCafeDataSet5.USP_ThanhToan' table. You can move, or remove it, as needed.
            this.USP_ThanhToanTableAdapter.Fill(this.QuanLyQuanCafeDataSet5.USP_ThanhToan,id2);
            // TODO: This line of code loads data into the 'QuanLyQuanCafeDataSet4.USP_GetListBillByDateReport' table. You can move, or remove it, as needed.
            //this.USP_GetListBillByDateReportTableAdapter.Fill(this.QuanLyQuanCafeDataSet4.USP_GetListBillByDateReport,dtpk1.Value, dtpk2.Value);
            this.reportViewer1.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            USP_ThanhToanTableAdapter.Fill(QuanLyQuanCafeDataSet5.USP_ThanhToan, (comboBox1.SelectedItem as Table).ID);
            reportViewer1.RefreshReport();
        }
    }
}
