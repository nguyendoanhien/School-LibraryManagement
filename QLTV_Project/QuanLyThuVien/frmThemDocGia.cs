using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace QuanLyThuVien
{
    public partial class frmThemDocGia : Form
    {
        public frmThemDocGia()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                picBoxAvatar.ImageLocation = ofd.FileName;
            }
        }

        private void frmThemDocGia_Load(object sender, EventArgs e)
        {
            LoaiDocGia_BUS loaidocgia_bus = new LoaiDocGia_BUS();
            foreach (DataRow dr in loaidocgia_bus.LoadCboLoaiDG().Rows)
            {
                cboLoaiDG.Items.Add(dr["TenLoaiDocGia"].ToString());
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bool GioiTinh;
            if (rdoGioiTinh.Checked)
                GioiTinh = true;
            else
                GioiTinh =  false;
            DocGia_BUS docgia_bus = new DocGia_BUS();
            if(txtHoTen.Text != "" || txtEmail.Text != "")
            { 
                NguoiDung ng = new NguoiDung(0, txtHoTen.Text, GioiTinh, txtEmail.Text, dtmNgayTao.Value);
                if(docgia_bus.ThemNguoiDung(ng))
                {
                    MessageBox.Show("Đã thêm vào thành công");
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin nhập thông tin đầy đủ");
            }
        }
    }
}
