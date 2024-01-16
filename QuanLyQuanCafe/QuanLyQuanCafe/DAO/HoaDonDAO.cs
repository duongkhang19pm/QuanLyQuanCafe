using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return HoaDonDAO.instance; }
            private set { HoaDonDAO.instance = value; }
        }
        private HoaDonDAO() { }
        // thành công thì hoa don id
        // thất bại -1
        public int GetUncheckHoaDonIDbyBanID(int id)
        {

            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from dbo.HoaDon where IdBanan = "+ id +" and trangthai = 1");
            if (data.Rows.Count > 0)
            {
                HoaDon hoadon = new HoaDon(data.Rows[0]);
                return hoadon.ID;
            }
            return -1;

        }
    }
}
