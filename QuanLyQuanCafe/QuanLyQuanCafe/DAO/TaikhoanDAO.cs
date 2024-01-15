using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class TaikhoanDAO
    {
        private static TaikhoanDAO instance;

        public static TaikhoanDAO Instance
        {
            get { if (instance == null) instance = new TaikhoanDAO(); return instance; }
            private set => instance = value;
        }
        private TaikhoanDAO() { }
        public bool Login(string tenDanhnhap, string matKhau)
        {
            string query = "USP_Login @@tenDangnhap , @matKhau";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] {tenDanhnhap,matKhau});
            return result.Rows.Count > 0;

        }
    }
}
