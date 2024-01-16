using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class HoaDon
    {
        public HoaDon(int id, DateTime? dateCheckIn, DateTime? dateCheckOut, int trangthai)
        {
            this.iD = id;
            this.dateCheckIn = dateCheckIn;
            this.dateCheckOut = dateCheckOut;
            this.trangThai = trangthai;
        }
        public HoaDon(DataRow row)
        {
            this.iD = (int)row["Id"];
            this.DateCheckIn = (DateTime?)row["ThoiGianVao"];
            var DateCheckOutTemp = row["ThoiGianRa"];
            if(DateCheckOutTemp.ToString() != "" )
                this.DateCheckOut = (DateTime?)row["ThoiGianRa"];
            this.trangThai = (int)row["TrangThai"];
        }
        private int iD;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private int trangThai;

        public int ID { get => iD; set => iD = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
    }
}
