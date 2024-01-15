using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class BanAn
    {
        public BanAn(int id, string tenBanan, string trangThai)
        {
            this.ID = id;
            this.TenBanan = tenBanan;
            this.trangThai = trangThai;
        }
        public BanAn(DataRow row)
        {
            this.iD = (int)row["id"];
            this.tenBanan = (string)row["TenBan"];
            this.trangThai = (string)row["TrangThai"];

        }
        private int iD;
        private string tenBanan;
        private string trangThai;

        public int ID { get => iD; set => iD = value; }
        
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string TenBanan { get => tenBanan; set => tenBanan = value; }
    }
}
