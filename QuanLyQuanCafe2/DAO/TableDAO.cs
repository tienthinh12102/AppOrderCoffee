using QuanLyQuanCafe2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe2.DAO
{
    public class TableDAO
    {
        private static TableDAO instance;
        public static TableDAO Instance
        {
            get { if (instance == null) instance = new TableDAO(); return TableDAO.instance; }
            private set { TableDAO.instance = value; }
        }

        public static int TableWidth = 65;
        public static int TableHeight = 65;

        private TableDAO() { }

        public void SwitchTable(int id1,int id2)
        {
            DataProvider.Instance.ExecuteQuery("USP_SwitchTable @idTable1 , @idTable2", new object[]{ id1, id2});
        }

        public List<Table> GetListTable()
        {
            List<DTO.Table> list = new List<DTO.Table>();

            string query = "select * from tablefood";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                DTO.Table table = new DTO.Table(item);
                list.Add(table);
            }
            return list;
        }

        public List<Table> LoadTableList()
        {
            List<Table> tableList = new List<Table>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");

            foreach (DataRow item in data.Rows)           
            {
                Table table = new Table(item);
                tableList.Add(table);

            }

            return tableList;
        }
        public bool InsertTable(string name, string status)
        {
            string query = string.Format("INSERT dbo.TableFood ( name ,status )VALUES(   N'{0}', N'{1}')", name, status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool UpdateTable(int id, string name, string status)
        {
            string query = string.Format("UPDATE dbo.TableFood SET name = N'{1}',status = N'{2}' WHERE id = {0}",id,name,status);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
        public bool DeleteTable(int id)
        {
            BillDAO.Instance.DeleteBillByTableID(id);
            string query = string.Format("DELETE dbo.TableFood WHERE id = {0}", id);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
