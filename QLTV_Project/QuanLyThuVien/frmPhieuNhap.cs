#region
using System;
using System.Windows.Forms;
using BUS;
#endregion

namespace QuanLyThuVien
{
    public partial class frmPhieuNhap : Form
    {
        private readonly PhieuNhap_BUS phieunhap_bus = new PhieuNhap_BUS();

        public frmPhieuNhap()
        {
            InitializeComponent();
            lblMaPhieuNhap.Text = phieunhap_bus.MaPhieuNhap() + "";
        }

        private void btnDSNCC_Click(object sender, EventArgs e)
        {
            var frm = new frmNhaCungCap();
            if (frm.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var gtThem = 1;
            phieunhap_bus.ThemDauSach(gtThem);
        }

        private void btnDSDauSach_Click(object sender, EventArgs e)
        {
            var frm = new frmDauSach();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                var index = frm.dgvDSDauSach.CurrentCell.RowIndex;
                var dgvselected = frm.dgvDSDauSach.Rows[index].Cells[0].Value.ToString().Trim();
                MessageBox.Show(dgvselected);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var gtxoa = 1;
            phieunhap_bus.XoaDauSach(gtxoa);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}