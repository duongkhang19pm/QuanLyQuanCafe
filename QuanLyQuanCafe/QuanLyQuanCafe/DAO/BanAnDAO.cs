using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanCafe.DAO
{
    public class BanAnDAO
    {
        private static BanAnDAO instance;

        public static BanAnDAO Instance 
        {
            get { if (instance == null) instance = new BanAnDAO(); return BanAnDAO.instance; }
            private set { BanAnDAO.instance = value; }
        }
        public static int BanWidth = 150;
        public static int BanHeight = 150;
        private BanAnDAO() { }
        public List<BanAn> LoadBanAnList()
        {
            List<BanAn> bananlist = new List<BanAn>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetBanAnList");
            foreach(DataRow item in data.Rows)
            {
                BanAn banAn = new BanAn(item);
                bananlist.Add(banAn);
            }
            return bananlist;
        }
    }
}
