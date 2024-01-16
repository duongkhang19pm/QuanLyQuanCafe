using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class HoaDonChiTietDAO
    {
        private static HoaDonChiTietDAO instance;

        public static HoaDonChiTietDAO Instance 
        {
            get { if (instance == null) instance = new HoaDonChiTietDAO(); return HoaDonChiTietDAO.instance; }
            private set { HoaDonChiTietDAO.instance = value; }
        }
        private HoaDonChiTietDAO() { }
        public List<HoaDonChiTiet> GetListHoaDonChiTiet (int id)
        {
            List<HoaDonChiTiet> listHDChiTiet = new List<HoaDonChiTiet>();
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from dbo.ChiTietHoaDon where IdHoaDon = "+ id );
            foreach(DataRow item in data.Rows)
            {
                HoaDonChiTiet chitiet = new HoaDonChiTiet(item);
                listHDChiTiet.Add(chitiet);

            }    
            return listHDChiTiet;
        }    

    }
}
