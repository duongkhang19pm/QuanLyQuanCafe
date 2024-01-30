using QuanLyQuanCafe.DAO;
using QuanLyQuanCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            LoadDanhMuc();
        }

        void LoadDanhMuc()
        {
            List<DanhMuc> lsDanhMuc = DanhMucDAO.Instance.GetDanhMuc();
            cbDanhMuc.DataSource = lsDanhMuc;
            cbDanhMuc.DisplayMember = "TenDanhMuc";
        }
        void LoadMonAnTheoDanhMuc(int id)
        {
            List<MonAn> lsMonAn = MonAnDAO.Instance.GetMonAnTheoDanhMucID(id);
            cbMonAn.DataSource = lsMonAn;
            cbMonAn.DisplayMember = "TenMonAn";

        }
        void LoadBanAn()
        {
            List<BanAn> bananlist = BanAnDAO.Instance.LoadBanAnList();
            foreach (BanAn item in bananlist)
            {
                Button btn = new Button() { Width = BanAnDAO.BanWidth, Height = BanAnDAO.BanHeight };
                btn.Text = item.TenBanan + Environment.NewLine + item.TrangThai;
                btn.Click += btn_click;
                btn.Tag = item;

                switch (item.TrangThai)
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

        void ShowHoaDon(int id)
        {
            lsvHoadon.Items.Clear();
            List<Menu> listHDChiTiet = MenuDAO.Instance.GetMenubyBanAn(id);
            float TongTien = 0;
            foreach (Menu item in listHDChiTiet)
            {
                ListViewItem lsvitem = new ListViewItem(item.TenMonan.ToString());
                lsvitem.SubItems.Add(item.SoLuong.ToString());
                lsvitem.SubItems.Add(item.DonGia.ToString());
                lsvitem.SubItems.Add(item.ThanhTien.ToString());
                TongTien += item.ThanhTien;
                lsvHoadon.Items.Add(lsvitem);
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            Thread.CurrentThread.CurrentCulture = culture;
            txtTongtien.Text = TongTien.ToString("c");
        }


        private void btn_click(object? sender, EventArgs e)
        {
            int BanID = ((sender as Button).Tag as BanAn).ID;
            lsvHoadon.Tag = (sender as Button).Tag;

            ShowHoaDon(BanID);
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

        private void cbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedIndex == null)
                return;

            DanhMuc selected = cb.SelectedItem as DanhMuc;
            id = selected.Id;

            LoadMonAnTheoDanhMuc(id);
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            BanAn banan = lsvHoadon.Tag as BanAn;
            int idHoaDon = HoaDonDAO.Instance.GetUncheckHoaDonIDbyBanID(banan.ID);
            int idMonAn = (cbMonAn.SelectedItem as MonAn).Id;
            int soLuong = (int)nmSlMon.Value;
            if(idHoaDon == -1)
            {
                HoaDonDAO.Instance.ThemHoaDon(banan.ID);
                HoaDonChiTietDAO.Instance.ThemHoaDonChiTiet(HoaDonDAO.Instance.GetMaxIdHoaDon(), idMonAn, soLuong);

            }   
            else
            {
                HoaDonChiTietDAO.Instance.ThemHoaDonChiTiet(idHoaDon, idMonAn, soLuong); 
            }    
        }
    }
}
