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
            
            dtgvDsSachTra_KhoiTao();
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
            dtgvDsSachMuon_KhoiTao();
        }

        private void dtgvDsSachMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maPhieuTra = dtgvDsSachMuon.Rows[e.RowIndex].Cells[1].Value.ToString();
            string maPhieuMuon = dtgvDsSachMuon.Rows[e.RowIndex].Cells[2].Value.ToString();
            string maDauSach = dtgvDsSachMuon.Rows[e.RowIndex].Cells[3].Value.ToString();
            string ngayHenTra = dtgvDsSachMuon.Rows[e.RowIndex].Cells[4].Value.ToString();
            //int index = dtgvDsSachTra.RowCount - 1;
            
            DataGridViewRow row = (DataGridViewRow)dtgvDsSachTra.Rows[0].Clone();
            row.Cells[1].Value = maPhieuTra;
            row.Cells[2].Value = maPhieuMuon;
            row.Cells[3].Value = maDauSach;
            row.Cells[4].Value = ngayHenTra;
            dtgvDsSachTra.Rows.Add(row);
        }

        private void dtgvDsSachMuon_KhoiTao()
        {
          if(dtgvDsSachMuon!=null)
            { 
            dtgvDsSachMuon.Columns[1].HeaderText = "Mã phiếu trả";
            dtgvDsSachMuon.Columns[2].HeaderText = "Mã phiếu mượn";
            dtgvDsSachMuon.Columns[3].HeaderText = "Mã đầu sách";
            dtgvDsSachMuon.Columns[4].HeaderText = "Ngày hẹn trả";
            }
        }
        private void dtgvDsSachTra_KhoiTao()
        {
            dtgvDsSachTra.ColumnCount += 4;
            dtgvDsSachTra.Columns[1].Name = "Mã phiếu trả";
            dtgvDsSachTra.Columns[2].Name = "Mã phiếu mượn";
            dtgvDsSachTra.Columns[3].Name = "Mã đầu sách";
            dtgvDsSachTra.Columns[4].Name = "Ngày hẹn trả";
        }


    }
}
