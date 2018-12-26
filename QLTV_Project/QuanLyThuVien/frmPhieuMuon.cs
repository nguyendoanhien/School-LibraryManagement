#region
using System;
using System.Windows.Forms;
using BUS;
using DTO;
using ExtensionMethods;
#endregion

namespace QuanLyThuVien
{
    public partial class frmPhieuMuon : Form
    {
        private readonly PhieuMuon_BUS phieumuon_bus = new PhieuMuon_BUS();
        public DataGridView DgvSachMuon { get; set; }

        public frmPhieuMuon()
        {
            InitializeComponent();
            HienThiMaPhieuMuon();
            HienThiMaNhanVien();
            btnChiTietSach.Enabled = false;
        }

        public void HienThiMaPhieuMuon()
        {
            lblMaPhieuMuon.Text = phieumuon_bus.LayMaPhieuMuon() + "";
        }

        public void HienThiMaNhanVien()
        {
            //Load "mã nhân viên" đăng nhập
            var nv = (NhanVien) MySessions.Sessions["user"];
            txtMaNhanVien.Text = nv.MaNhanVien + "";
        }

        private void KT_DocGia_Click(object sender, EventArgs e)
        {
            var docGia_BUS = new DocGia_BUS();
            if (txtMaDocGia.Text == "")
            {
                MessageBox.Show("Nhập mã độc giả!!!");
                txtMaDocGia.Focus();
            }
            else if (!DocGia_BUS.KiemTraDocGia(int.Parse(txtMaDocGia.Text)))
            {
                MessageBox.Show("Đây không phải là độc giả");
                btnChiTietSach.Enabled = false;
            }
            else if (!DocGia_BUS.KiemTraDuocMuon(txtMaDocGia.Text.ToInt32()))
            {
                btnChiTietSach.Enabled = false;
                MessageBox.Show("Không được mượn sách nha", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDocGia.Text = "";
                txtMaDocGia.Focus();
            }
            else
            {
                btnChiTietSach.Enabled = true;

                MessageBox.Show("Hợp Lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnChiTietSach_Click(object sender, EventArgs e)
        {
            if (KiemTraTraCuuSach())
            {
                var frm = new frmDauSachDuocMuon(dgvSachMuon);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    var MaDauSach = frm.MaDauSach;
                    lblMaDauSach.Text = MaDauSach;
                    var MaSach = frm.MaSach;
                    lblMaSach.Text = MaSach;
                    var TenDauSach = frm.TenDauSach;
                    lblTenSach.Text = TenDauSach;
                    var ngayThem = frm.NgayTra1;
                    dateTra.Value = dateMuon.Value.AddDays(ngayThem);
                }
            }
            else
            {
                MessageBox.Show("Mượn hết đc r thím");
            }
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (lblMaDauSach.Text == "")
            {
                MessageBox.Show("Phải chọn sách !!!");
            }
            //else if (DocGia_BUS.Kt_SachMuon(int.Parse(txtMaDocGia.Text), int.Parse(lblMaDauSach.Text)))
            //{
            //    MessageBox.Show("Sách này đã mượn rồi");
            //}
            else
            {
                var index = dgvSachMuon.Rows.Add();
                dgvSachMuon.Rows[index].Cells["MaSach"].Value = lblMaSach.Text;
                dgvSachMuon.Rows[index].Cells["MaDauSach"].Value = lblMaDauSach.Text;
                dgvSachMuon.Rows[index].Cells["TenDauSach"].Value = lblTenSach.Text;
                dgvSachMuon.Rows[index].Cells["NgayTra"].Value = dateTra.Value;
                lblTenSach.Text = "";
                lblMaSach.Text = "";
                lblMaDauSach.Text = "";
                dateTra.Value = DateTime.Now;
            }
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dgvSachMuon.SelectedRows)
                if (dgvSachMuon.Rows.Count == 1)
                    MessageBox.Show("Không có dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    dgvSachMuon.Rows.RemoveAt(item.Index);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            var phieuMuon_BUS = new PhieuMuon_BUS();
            if (phieuMuon_BUS.Insert_Phieu(int.Parse(txtMaNhanVien.Text), dateMuon.Value))
                MessageBox.Show("Đã thêm phiếu!!");
            if (phieuMuon_BUS.Insert_PhieuMuon(int.Parse(lblMaPhieuMuon.Text), int.Parse(txtMaDocGia.Text)))
                MessageBox.Show("Đã thêm phiếu mượn!!!");
            for (var i = 0; i < dgvSachMuon.Rows.Count - 1; i++)
            {
                var maDauSach = dgvSachMuon.Rows[i].Cells[0].Value.ToString();
                var maSach = dgvSachMuon.Rows[i].Cells[1].Value.ToString();
                var tenSach = dgvSachMuon.Rows[i].Cells[2].Value.ToString();
                var ngayTra = DateTime.Parse(dgvSachMuon.Rows[i].Cells[3].Value.ToString());
                var ngayTra1 = ngayTra.ToString("yyyy - MM - dd HH: mm:ss.fff");
                if (phieuMuon_BUS.Insert_PhieuMuonChiTiet(int.Parse(maSach), int.Parse(lblMaPhieuMuon.Text),
                    int.Parse(maDauSach), ngayTra1)) MessageBox.Show("Đã thêm phiếu mượn chi tiết");
            }

            dgvSachMuon.Rows.Clear();
            dgvSachMuon.Refresh();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMaDocGia_TextChanged(object sender, EventArgs e)
        {
            btnChiTietSach.Enabled = false;
        }

        private bool KiemTraTraCuuSach()
        {
            var slSachSeMuon = dgvSachMuon.Rows.Count - 1;
            var slSachToiDa = DocGia_BUS.LaySachMuonToiDa(txtMaDocGia.Text.ToInt32());
            if (slSachToiDa == null) return false;
            if (slSachSeMuon == slSachToiDa) return false;
            return true;
        }
    }
}