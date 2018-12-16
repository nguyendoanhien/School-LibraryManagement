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
    public partial class frmPhieuMuon : Form
    {
        PhieuMuon_BUS phieumuon_bus = new PhieuMuon_BUS();
        public frmPhieuMuon()
        {
            InitializeComponent();
            HienThiMaPhieuMuon();
            
        }
        

        public void HienThiMaPhieuMuon()
        {
            lblMaPhieuMuon.Text = phieumuon_bus.LayMaPhieuMuon() + "";
        }

        public void HienThiMaNhanVien()
        {
        }

        private void KT_DocGia_Click(object sender, EventArgs e)
        {
            DocGia_BUS docGia_BUS = new DocGia_BUS();
            if (txtMaDocGia.Text == "")
            {
                MessageBox.Show("Nhập mã độc giả!!!");
                txtMaDocGia.Focus();
            }
            else if (docGia_BUS.Kt_DocGia(int.Parse(txtMaDocGia.Text)) == 1)
            {
                MessageBox.Show("Có thể mượn sách");
            }
            else if (docGia_BUS.Kt_DocGia(int.Parse(txtMaDocGia.Text)) == 0)
            {
                MessageBox.Show("Đây không phải là độc giả");
            }
            else
            { 
                MessageBox.Show("Không được mượn sách nha","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtMaDocGia.Text = "";
                txtMaDocGia.Focus();
            }
        }

        private void btnChiTietSach_Click(object sender, EventArgs e)
        {
            frmDauSachDuocMuon frm = new frmDauSachDuocMuon();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                string MaDauSach = frm.MaDauSach;
                lblMaDauSach.Text = MaDauSach;
                string MaSach = frm.MaSach;
                lblMaSach.Text = MaSach;
                string TenDauSach = frm.TenDauSach;
                lblTenSach.Text = TenDauSach;
                int ngayThem = frm.NgayTra1;
                dateTra.Value = dateMuon.Value.AddDays(ngayThem);
            }
        }

        private void txtMaDocGia_TextChanged(object sender, EventArgs e)
        {

        }

        //private void dtgvDsSachMuon_KhoiTao()
        //{
        //    if (dgvSachMuon != null)
        //    {
        //        dgvSachMuon.Columns[0].HeaderText = "Mã sách";
        //        dgvSachMuon.Columns[1].HeaderText = "Mã đầu sách";
        //        dgvSachMuon.Columns[2].HeaderText = "Tên đầu sách";
        //        dgvSachMuon.Columns[3].HeaderText = "Ngày hẹn trả";
        //    }
        //}

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            dgvSachMuon.Columns[0].HeaderText = "Mã sách";
            dgvSachMuon.Columns[1].HeaderText = "Mã đầu sách";
            dgvSachMuon.Columns[2].HeaderText = "Tên đầu sách";
            dgvSachMuon.Columns[3].HeaderText = "Ngày hẹn trả";
            var index = dgvSachMuon.Rows.Add();
            dgvSachMuon.Rows[index].Cells["Mã sách"].Value = lblMaSach.Text;
            dgvSachMuon.Rows[index].Cells["Mã đầu sách"].Value = lblMaDauSach.Text;
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
