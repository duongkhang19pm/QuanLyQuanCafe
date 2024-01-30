using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class DanhMucDAO
    {
        private static DanhMucDAO instance;

        public static DanhMucDAO Instance
        {

            get { if (instance == null) instance = new DanhMucDAO(); return DanhMucDAO.instance; }
            private set { DanhMucDAO.instance = value; }
        }
        private DanhMucDAO() { }
        public List<DanhMuc> GetDanhMuc()
        {
            List<DanhMuc> listdanhmuc = new List<DanhMuc>();
            string query = "Select * from dbo.DanhMuc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DanhMuc danhmuc = new DanhMuc(item);
                listdanhmuc.Add(danhmuc);
            }    
            return listdanhmuc;

        }
    }
}
