using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class Menu
    {
        public Menu (string tenMonan, int soLuong, float donGia, float thanhTien)
        {
            this.tenMonan = tenMonan;
            this.soLuong = soLuong;
            this.donGia = donGia;
            this.thanhTien = thanhTien;

        }
        public Menu(DataRow row)
        {
            this.tenMonan = row["TenMonAn"].ToString();
            this.soLuong = (int)row["SoLuong"];
            this.donGia = (float)Convert.ToDouble(row["Gia"].ToString());
            this.thanhTien = (float)Convert.ToDouble(row["thanhtien"].ToString());

        }
        private int soLuong;
        private float donGia;
        private float thanhTien;
        private string tenMonan;

        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string TenMonan { get => tenMonan; set => tenMonan = value; }
    }
}
