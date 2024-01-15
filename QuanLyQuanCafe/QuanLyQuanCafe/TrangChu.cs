using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanCafe
{
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            LoadBanAn();
        }

        void LoadBanAn()
        {
            List<BanAn> bananlist = BanAnDAO.Instance.LoadBanAnList();
            foreach (BanAn item in bananlist)
            {
                Button btn = new Button() { Width = BanAnDAO.BanWidth, Height = BanAnDAO.BanHeight };
                btn.Text = item.TenBanan + Environment.NewLine + item.TrangThai;
                switch(item.TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.Yellow;
                        break;


                }
                flpBan.Controls.Add(btn);

            }

        }
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ThongTinCaNhan thongtincn = new ThongTinCaNhan();
            thongtincn.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }
    }
}
