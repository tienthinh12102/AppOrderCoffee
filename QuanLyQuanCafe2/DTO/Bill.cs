using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe2.DTO
{
    public class Bill
    {
        public Bill(int id,DateTime dateCheckin,DateTime dateCheckout,int status,int discount = 0)
        {
            this.ID = id;
            this.dateCheckIn = dateCheckin;
            this.dateCheckOut = dateCheckout;
            this.Status = status;
            this.Discount = discount;
        }

        public Bill(DataRow row)
        {
            this.ID = (int)row["id"];
            this.DateCheckIn = (DateTime?)row["dateCheckin"];

            var dateCheckOutTemp = row["dateCheckOut"];
            if (dateCheckOutTemp.ToString()!= "") { this.dateCheckOut = (DateTime?)dateCheckOutTemp; }
         
            this.Status = (int)row["status"];
            this.Discount = (int)row["discount"];
        }

        private int discount;

        private DateTime? dateCheckOut;
        private int iD;
        private int status;
        private DateTime? dateCheckIn;

        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public int Status { get => status; set => status = value; }
        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckout { get => dateCheckOut; set => dateCheckOut = value; }
        public int Discount { get => discount; set => discount = value; }
    }
}
