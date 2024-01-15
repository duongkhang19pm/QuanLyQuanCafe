using QuanLyQuanCafe.DAO;

namespace QuanLyQuanCafe
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangnhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            if(Login(tenDangnhap,matKhau))
            {
                TrangChu trangchu = new TrangChu();
                this.Hide();
                trangchu.ShowDialog();
                this.Show();
            }    
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");

            }    
            

        }
        bool Login (string tenDangnhap, string matKhau)
        {
            return TaikhoanDAO.Instance.Login(tenDangnhap, matKhau);   
        }
        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát phần mềm không ?", "Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK) 
                e.Cancel = true;
        }
    }
}
