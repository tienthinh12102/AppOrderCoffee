using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe2.DTO
{
    public class Account
    {
        public Account(string userName,string displayName, int type, string passWord = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.Tyle = type;
            this.PassWord = passWord;
        }
        public Account(DataRow row)
        {
            this.UserName = row["userName"].ToString();
            this.DisplayName = row["displayName"].ToString();
            this.Tyle = (int)row["type"];
            this.PassWord = row["passWord"].ToString();
        }


        private string userName;
        private string displayName;
        private string passWord;
        private int tyle;

        public string UserName { get => userName; set => userName = value; }
        public string DisplayName { get => displayName; set => displayName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public int Tyle { get => tyle; set => tyle = value; }
    }
}
