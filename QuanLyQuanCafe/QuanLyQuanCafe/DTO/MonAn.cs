using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class MonAn
    {
        public MonAn(int id, int danhMuc_id, string tenMonan, float donGia)
        {
            this.id = id;
            this.Danhmucid1 = danhMuc_id;
            this.tenMonAn = tenMonan;
            this.donGia = donGia;

        }
        public MonAn(DataRow row)
        {
            this.id = (int)row["Id"];
            this.Danhmucid1 = (int)row["IdDanhMuc"];
            this.tenMonAn = row["TenMonAn"].ToString();
            this.donGia = (float)Convert.ToDouble(row["Gia"].ToString()) ;

        }
        private int id;
        private int Danhmucid;
        private string tenMonAn;
        private float donGia;

        public int Id { get => id; set => id = value; }
     
        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public int Danhmucid1 { get => Danhmucid; set => Danhmucid = value; }
    }
}
