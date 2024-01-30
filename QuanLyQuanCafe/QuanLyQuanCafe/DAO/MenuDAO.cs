using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class MenuDAO
    {
       private static MenuDAO instance;

        public static MenuDAO Instance 
        {

            get { if (instance == null) instance = new MenuDAO(); return MenuDAO.instance; }
            private set { MenuDAO.instance = value; }
        }
        private MenuDAO() { }
        public List<Menu> GetMenubyBanAn(int id)
        {
            List<Menu> listmenu = new List<Menu>();
            string query = "Select mon.TenMonAn, ct.SoLuong , mon.Gia ,mon.Gia * ct.SoLuong as thanhtien  from dbo.ChiTietHoaDon as ct, dbo.HoaDon as hd,  dbo.MonAn as mon \r\nwhere ct.IdHoaDon = hd.Id and ct.IdMonAn = mon.Id and hd.TrangThai = 0 and hd.IdBanan = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Menu menu = new Menu(item);
                listmenu.Add(menu);
            }    
            return listmenu;

        }
    }
}
