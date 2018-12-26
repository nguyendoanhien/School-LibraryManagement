#region
using System;
using System.Windows.Forms;
using BUS;
using DTO;
using ExtensionMethods;
#endregion

namespace QuanLyThuVien
{
    public partial class frmPhieuTra : Form
    {
        public frmPhieuTra()
        {
            InitializeComponent();
            cbMaPhieuMuon_KhoiTao();
            dtgvDsSachTra_KhoiTao();
            HienThiMaPhieuTra();
        }

        private readonly PhieuTra_BUS phieuTra_BUS = new PhieuTra_BUS();

        private void cbMaPhieuMuon_KhoiTao()
        {
            if (txtMaDocGia.Text != "")
            {
                cbMaPhieuMuon.ValueMember = "MaPhieuMuon";
                cbMaPhieuMuon.DisplayMember = "MaPhieuMuon";
                cbMaPhieuMuon.DataSource = PhieuMuon_BUS.GetPhieuMuonFromMaDocGia(txtMaDocGia.Text.ToInt32());
                if (cbMaPhieuMuon != null)
                    cbMaPhieuMuon.SelectedIndex = 0;
            }
        }

        public void HienThiMaPhieuTra()
        {
            lblMaPhieuTra.Text = phieuTra_BUS.MaPhieuTra() + "";
            var nv = (NhanVien) MySessions.Sessions["user"];
            MaThuThu.Text = nv.MaNhanVien + "";
        }

        public void HienThiSachDangMuon()
        {
            if (phieuTra_BUS.KiemTraRong(txtMaDocGia.Text) == 0) MessageBox.Show("Bạn không có sách đã mượn!!");
            dtgvDsSachMuon.DataSource =
                phieuTra_BUS.LoadDanhSachMuon(txtMaDocGia.Text, cbMaPhieuMuon.SelectedValue.ToString());
        }

        private void btnTimPhieuMuon_Click(object sender, EventArgs e)
        {
            cbMaPhieuMuon_KhoiTao();
            //dtgvDsSachMuon_KhoiTao();
        }

        private void dtgvDsSachMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var maPhieuMuon = dtgvDsSachMuon.Rows[e.RowIndex].Cells["MaPhieuMuon"].Value.ToString();
            var maDauSach = dtgvDsSachMuon.Rows[e.RowIndex].Cells["MaDauSach"].Value.ToString();
            var maSach = dtgvDsSachMuon.Rows[e.RowIndex].Cells["STT"].Value.ToString();
            var tenDauSach = dtgvDsSachMuon.Rows[e.RowIndex].Cells["TenDauSach"].Value.ToString();
            var ngayHenTra = dtgvDsSachMuon.Rows[e.RowIndex].Cells["NgayHenTra"].Value.ToString();
            var ngayTra = dateTra.Value.ToString();

            //if (phieuTra_BUS.KT_PhieuTraChiTiet(lblMaPhieuTra.Text,maDauSach)==0)
            //int index = dtgvDsSachTra.RowCount - 1;
            var d = 0;
            for (var rows = 0; rows < dtgvDsSachTra.Rows.Count - 1; rows++)
            {
                var traMaPhieuMuon = dtgvDsSachTra.Rows[rows].Cells["MaPhieuMuon"].Value.ToString();
                var traMaDauSach = dtgvDsSachTra.Rows[rows].Cells["MaDauSach"].Value.ToString();
                var traMaSach = dtgvDsSachTra.Rows[rows].Cells["STT"].Value.ToString();
                if (traMaPhieuMuon == maPhieuMuon
                    && traMaDauSach == maDauSach
                    && traMaSach == maSach)
                    d++;
            }

            if (d == 0)
            {
                var row = (DataGridViewRow) dtgvDsSachTra.Rows[0].Clone();
                row.Cells[0].Value = maPhieuMuon;
                row.Cells[1].Value = maDauSach;
                row.Cells[2].Value = maSach;
                row.Cells[3].Value = tenDauSach;
                row.Cells[4].Value = ngayHenTra;
                row.Cells[5].Value = phieuTra_BUS.TienPhat(maDauSach, phieuTra_BUS.TinhNgay(ngayHenTra, ngayTra));
                dtgvDsSachTra.Rows.Add(row);
            }
            else
            {
                MessageBox.Show("Sách Này Đã Được Thêm Rồi");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            phieuTra_BUS.ThemPhieu(MaThuThu.Text, dateTra.Text);
            phieuTra_BUS.ThemPhieuTra(lblMaPhieuTra.Text, cbMaPhieuMuon.SelectedValue.ToString(), txtMaDocGia.Text);
            var a = Convert.ToInt32(lblMaPhieuTra.Text);
            int MaDauSach;
            string maSach;
            int MaPhieuMuon;
            string NgayTra;
            string TienPhat;
            var MaNV = Convert.ToInt32(MaThuThu.Text);
            int TienPhat1;
            //int i=13;
            for (var rows = 0; rows < dtgvDsSachTra.Rows.Count - 1; rows++)
            {
                MaPhieuMuon = Convert.ToInt32(dtgvDsSachTra.Rows[rows].Cells["MaPhieuMuon"].Value.ToString());
                MaDauSach = Convert.ToInt32(dtgvDsSachTra.Rows[rows].Cells["MaDauSach"].Value.ToString());
                maSach = dtgvDsSachTra.Rows[rows].Cells["STT"].Value.ToString();
                NgayTra = dateTra.Value.ToString();


                if (dtgvDsSachTra.Rows[rows].Cells[4].Value != null)
                    TienPhat = dtgvDsSachTra.Rows[rows].Cells["MucPhat"].Value.ToString();
                else
                    TienPhat = "0";
                ;

                TienPhat1 = Convert.ToInt32(TienPhat);

                phieuTra_BUS.ThemPhieuTraChiTiet(MaDauSach, maSach, a, MaNV, NgayTra, TienPhat1);

                phieuTra_BUS.UPDATE_PhieuMuonChiTiet(MaDauSach, maSach, MaPhieuMuon);
            }

            MessageBox.Show("Bạn đã thêm thành công!!");
        }

        private void dtgvDsSachTra_KhoiTao()
        {
            dtgvDsSachTra.ColumnCount += 6;
            dtgvDsSachTra.Columns[0].Name = "MaPhieuMuon";
            dtgvDsSachTra.Columns[1].Name = "MaDauSach";
            dtgvDsSachTra.Columns[2].Name = "STT";
            dtgvDsSachTra.Columns[3].Name = "TenDauSach";
            dtgvDsSachTra.Columns[4].Name = "NgayHenTra";
            dtgvDsSachTra.Columns[5].Name = "MucPhat";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmPhieuTra_Load(object sender, EventArgs e)
        {
        }

        private void cbMaPhieuMuon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbMaPhieuMuon.SelectedValue != null)
                HienThiSachDangMuon();
        }
    }
}