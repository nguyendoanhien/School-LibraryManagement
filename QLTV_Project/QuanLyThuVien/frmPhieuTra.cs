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
namespace QuanLyThuVien
{
    public partial class frmPhieuTra : Form
    {
        public frmPhieuTra()
        {
            InitializeComponent();
            HienThi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        PhieuTra_BUS phieuTra_BUS = new PhieuTra_BUS();
        public void HienThi()
        {
            lblMaPhieuTra.Text = phieuTra_BUS.MaPhieuTra() + "";
        }

        public void HienThiSachDangMuon()
        {
            dtgvDsSachMuon.DataSource = phieuTra_BUS.LoadSachMuon(int.Parse(txtMaPhieuMuon.Text));
        }

        private void btnTimPhieuMuon_Click(object sender, EventArgs e)
        {
            HienThiSachDangMuon();
        }

        private void dtgvDsSachMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maPhieuTra = dtgvDsSachMuon.Rows[e.RowIndex].Cells[1].Value.ToString();
            string maPhieuMuon = dtgvDsSachMuon.Rows[e.RowIndex].Cells[2].Value.ToString();
            string maDauSach = dtgvDsSachMuon.Rows[e.RowIndex].Cells[3].Value.ToString();
            string ngayHenTra = dtgvDsSachMuon.Rows[e.RowIndex].Cells[4].Value.ToString();
            //int index = dtgvDsSachTra.RowCount - 1;
            DataGridViewRow row = (DataGridViewRow)dtgvDsSachTra.Rows[0].Clone();
            row.Cells[0].Value = maPhieuTra;
            row.Cells[1].Value = maPhieuMuon;
            row.Cells[2].Value = maDauSach;
            row.Cells[3].Value = ngayHenTra;
            dtgvDsSachTra.Rows.Add(row);
        }
    }
}
