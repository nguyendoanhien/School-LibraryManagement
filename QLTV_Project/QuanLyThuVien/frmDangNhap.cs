using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
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

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == 7 + "" && txtMatKhau.Text == "hienmup")
            {
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
    }
}
