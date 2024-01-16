using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class HoaDonChiTiet
    {
        public HoaDonChiTiet(int id, int hoaDon_ID,int monAn_ID, int soLuong)
        {
            this.ID = id;
            this.hoaDon_ID = hoaDon_ID;
            this.monAn_ID = monAn_ID;
            this.soLuong = soLuong;

        }
        public HoaDonChiTiet(DataRow row)
        {
            this.iD = (int)row["id"];
            this.hoaDon_ID = (int)row["IdHoaDon"];
            this.monAn_ID = (int)row["IdMonAn"];
            this.soLuong = (int)row["SoLuong"];
        }
        private int iD;
        private int hoaDon_ID;
        private int monAn_ID;
        private int soLuong;

        public int ID { get => iD; set => iD = value; }
        public int HoaDon_ID { get => hoaDon_ID; set => hoaDon_ID = value; }
        public int MonAn_ID { get => monAn_ID; set => monAn_ID = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
