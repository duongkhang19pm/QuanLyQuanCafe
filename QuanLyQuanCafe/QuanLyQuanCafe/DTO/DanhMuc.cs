using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DTO
{
    public class DanhMuc
    {
        public DanhMuc(int id, string tenDanhmuc)

        {
            this.Id = id;
            this.tenDanhmuc = tenDanhmuc;

        }
        public DanhMuc(DataRow row)
        {
            this.id = (int)row["Id"];
            this.tenDanhmuc = row["TenDanhMuc"].ToString();
        }
        private int id;
        private string tenDanhmuc;

        public int Id { get => id; set => id = value; }
        public string TenDanhmuc { get => tenDanhmuc; set => tenDanhmuc = value; }
    }
}
