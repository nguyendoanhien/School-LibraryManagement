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
using ExtensionMethods;

namespace QuanLyThuVien
{
    public partial class frmPhieuMuon : Form
    {
        PhieuMuon_BUS phieumuon_bus = new PhieuMuon_BUS();



        public DataGridView DgvSachMuon
        {
            get;
            set;
        }
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
            NhanVien nv = (NhanVien)MySessions.Sessions["user"];
            txtMaNhanVien.Text = nv.MaNhanVien + "";


        }

        private void KT_DocGia_Click(object sender, EventArgs e)
        {
          

            DocGia_BUS docGia_BUS = new DocGia_BUS();
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
            else if(!DocGia_BUS.KiemTraDuocMuon(txtMaDocGia.Text.ToInt32()))
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
                frmDauSachDuocMuon frm = new frmDauSachDuocMuon(dgvSachMuon);
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
            foreach (DataGridViewRow item in this.dgvSachMuon.SelectedRows)
            {
                if (dgvSachMuon.Rows.Count == 1)
                {
                    MessageBox.Show("Không có dữ liệu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    dgvSachMuon.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            PhieuMuon_BUS phieuMuon_BUS = new PhieuMuon_BUS();
            if (phieuMuon_BUS.Insert_Phieu(int.Parse(txtMaNhanVien.Text), dateMuon.Value))
                MessageBox.Show("Đã thêm phiếu!!");
            if (phieuMuon_BUS.Insert_PhieuMuon(int.Parse(lblMaPhieuMuon.Text), int.Parse(txtMaDocGia.Text)))
                MessageBox.Show("Đã thêm phiếu mượn!!!");
            for (int i = 0; i < dgvSachMuon.Rows.Count - 1; i++)
            {
                string maDauSach = dgvSachMuon.Rows[i].Cells[0].Value.ToString();
                string maSach = dgvSachMuon.Rows[i].Cells[1].Value.ToString();
                string tenSach = dgvSachMuon.Rows[i].Cells[2].Value.ToString();
                DateTime ngayTra = DateTime.Parse(dgvSachMuon.Rows[i].Cells[3].Value.ToString());
                string ngayTra1 = ngayTra.ToString("yyyy - MM - dd HH: mm:ss.fff");
                if (phieuMuon_BUS.Insert_PhieuMuonChiTiet(int.Parse(maSach), int.Parse(lblMaPhieuMuon.Text), int.Parse(maDauSach), ngayTra1))
                {
                    MessageBox.Show("Đã thêm phiếu mượn chi tiết");
                }
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
            int slSachSeMuon = dgvSachMuon.Rows.Count-1;
            int? slSachToiDa = DocGia_BUS.LaySachMuonToiDa(txtMaDocGia.Text.ToInt32());
            if (slSachToiDa == null) return false;
            if (slSachSeMuon == slSachToiDa) return false;
            return true;
        }
    }
}