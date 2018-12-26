#region
using System;
using System.Windows.Forms;
using BUS;
using DTO;
using ExtensionMethods;
using QuanLyThuVien.Properties;
#endregion

namespace QuanLyThuVien
{
    public partial class frmDangNhap : Form
    {
        private readonly NhanVien nv = new NhanVien();

        public frmDangNhap()
        {
            InitializeComponent();
        }

        public frmDangNhap(string maThuThu)
        {
            MaThuThu = txtTenDangNhap.Text;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                Close();
        }

        public string MaThuThu { get; set; }

        private void XuLyNhoTaiKhoan()
        {
            if (chkRemember.Checked)
            {
                Settings.Default.user = txtTenDangNhap.Text;
                Settings.Default.pass = txtMatKhau.Text;
            }
            else
            {
                Settings.Default.user = "";
                Settings.Default.pass = "";
            }

            Settings.Default.Save();
        }

        private void LuuSessionDangNhap()
        {
            MySessions.Sessions.Add("user", nv);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            nv.MaNhanVien = txtTenDangNhap.Text.ToInt32();
            nv.MatKhau = txtMatKhau.Text;


            if (NhanVien_BUS.KiemTraNhanVien(nv))
            {
                LuuSessionDangNhap();
                XuLyNhoTaiKhoan();
                MessageBox.Show("Đăng nhập thành công");
                Hide();
                var frm = new frmChinh();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                }

                Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = Settings.Default.user;
            txtMatKhau.Text = Settings.Default.pass;
        }
    }
}