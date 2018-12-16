using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using ExtensionMethods;
namespace QuanLyThuVien
{
    public partial class frmDangNhap : Form
    {
        private NhanVien nv=new NhanVien();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public frmDangNhap(string maThuThu)
        {
            this.maThuThu = txtTenDangNhap.Text ;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                this.Close();
        }

        private string maThuThu;

        public string MaThuThu { get => maThuThu; set => maThuThu = value; }

        private void XuLyNhoTaiKhoan()
        {
            if (chkRemember.Checked)
            {
                Properties.Settings.Default.user = txtTenDangNhap.Text;
                Properties.Settings.Default.pass = txtMatKhau.Text;
                
            }
            else
            {
                Properties.Settings.Default.user ="";
                Properties.Settings.Default.pass = "";

            }
            Properties.Settings.Default.Save();
        }

        private void LuuSessionDangNhap()
        {
            MySessions.Sessions.Add("user",this.nv);
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
                this.Hide();
                frmChinh frm = new frmChinh();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                }
                this.Close();
            }
            else
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");

            
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = Properties.Settings.Default.user;
            txtMatKhau.Text = Properties.Settings.Default.pass;
        }
    }
}
