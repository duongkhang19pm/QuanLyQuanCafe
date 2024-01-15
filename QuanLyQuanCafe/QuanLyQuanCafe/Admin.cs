using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
           
        }
     
        void LoadTaiKhoanList()
        {
            string query = "EXEC dbo.USP_GetAccountByUserName @tenDangnhap";
           
            dtgvTK.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] {"A1"});
        }    
        private void btndatlaimk_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan thongtincanhan = new ThongTinCaNhan();
            thongtincanhan.ShowDialog();
        }
    }
}
