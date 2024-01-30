using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class MonAnDAO
    {
        private static MonAnDAO instance;

        public static MonAnDAO Instance
        {
            get { if (instance == null) instance = new MonAnDAO(); return MonAnDAO.instance; }
            private set { MonAnDAO.instance = value; }
        }
        private MonAnDAO() { }
        public List<MonAn> GetMonAnTheoDanhMucID(int id)
        {
            List<MonAn> list = new List<MonAn>();
            string query = "Select * from dbo.MonAn where IdDanhMuc = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MonAn danhmuc = new MonAn(item);
                list.Add(danhmuc);
            }
            return list;

        }
    }
}
