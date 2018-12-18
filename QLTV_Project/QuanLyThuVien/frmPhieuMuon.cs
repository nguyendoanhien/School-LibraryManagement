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
            HienThiMaNhanVien();
        }


        public void HienThiMaPhieuMuon()
        {
            lblMaPhieuMuon.Text = phieumuon_bus.LayMaPhieuMuon() + "";
        }



        public void HienThiMaNhanVien()
        {
            //Load "mã nhân viên" đăng nhập
            //NhanVien nv = (NhanVien)MySessions.Sessions["user"];
            //txtMaNhanVien.Text = nv.MaNhanVien+"";


        }

        private void KT_DocGia_Click(object sender, EventArgs e)
        {
            //DocGia_BUS docGia_BUS = new DocGia_BUS();
            //if (txtMaDocGia.Text == "")
            //{
            //    MessageBox.Show("Nhập mã độc giả!!!");
            //    txtMaDocGia.Focus();
            //}
            //else if (docGia_BUS.Kt_DocGia(int.Parse(txtMaDocGia.Text)) == 1)
            //{
            //    MessageBox.Show("Có thể mượn sách");
            //}
            //else if (docGia_BUS.Kt_DocGia(int.Parse(txtMaDocGia.Text)) == 0)
            //{
            //    MessageBox.Show("Đây không phải là độc giả");
            //}
            //else
            //{
            //    MessageBox.Show("Không được mượn sách nha", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    txtMaDocGia.Text = "";
            //    txtMaDocGia.Focus();
            //}
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
        
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            if (lblMaDauSach.Text == "")
            {
                MessageBox.Show("Phải chọn sách !!!");
            }
            else if(DocGia_BUS.Kt_SachMuon(int.Parse(txtMaDocGia.Text), int.Parse(lblMaDauSach.Text)))
            {
                MessageBox.Show("Sách này đã mượn rồi");
            }
            else
            {
                bool KT = true;
                for (int j = 0; j < dgvSachMuon.Rows.Count;j++)
                {
                    if (dgvSachMuon.Rows[j].Cells[0].Value != null && lblMaDauSach.Text == dgvSachMuon.Rows[j].Cells[0].Value.ToString())
                    {
                        KT = false;
                        break;
                    }

                }
                if (KT == true)
                {
                    var index = dgvSachMuon.Rows.Add();
                    dgvSachMuon.Rows[index].Cells["Column2"].Value = lblMaSach.Text;
                    dgvSachMuon.Rows[index].Cells["Column1"].Value = lblMaDauSach.Text;
                    dgvSachMuon.Rows[index].Cells["Column3"].Value = lblTenSach.Text;
                    dgvSachMuon.Rows[index].Cells["Column4"].Value = dateTra.Value;
                    lblTenSach.Text = "";
                    lblMaSach.Text = "";
                    lblMaDauSach.Text = "";
                    dateTra.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Sách này đã mượn");
                }
            }
        }
        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvSachMuon.SelectedRows)
            {
                dgvSachMuon.Rows.RemoveAt(item.Index);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMaDocGia_MouseLeave(object sender, EventArgs e)
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
                MessageBox.Show("Không được mượn sách nha", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaDocGia.Text = "";
                txtMaDocGia.Focus();
            }
        }
        
    }
}
