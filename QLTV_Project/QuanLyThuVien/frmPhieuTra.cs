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
            HienThiMaPhieuTra();
            HienThiMaNhanVien();
        }

        PhieuTra_BUS phieuTra_BUS = new PhieuTra_BUS();
        public void HienThiMaPhieuTra()
        {
            lblMaPhieuTra.Text = phieuTra_BUS.MaPhieuTra() + "";
        }

        public void HienThiMaNhanVien()
        {
            //Load "mã nhân viên" đăng nhập
            //NhanVien nv = (NhanVien)MySessions.Sessions["user"];
            //txtMaNhanVien.Text = nv.MaNhanVien + "";


        }
        public void HienThiSachDangMuon()
        {
        }

        private void btnTimPhieuMuon_Click(object sender, EventArgs e)
        {
        }

        private void dtgvDsSachMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgvDsSachMuon.DataSource == null)
            {
                MessageBox.Show("Không có sách mượn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                foreach (DataGridViewRow row in dtgvDsSachMuon.SelectedRows)
                {
                    if(dtgvDsSachMuon.Rows[e.RowIndex].Cells[1].Value.ToString() == null)
                    {
                        MessageBox.Show("Không có sách mượn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    { 
                        //int index = dtgvDsSachTra.RowCount - 2;
                        string MaPhieuMuon = dtgvDsSachMuon.Rows[e.RowIndex].Cells[1].Value.ToString();
                        string MaDauSach = dtgvDsSachMuon.Rows[e.RowIndex].Cells[2].Value.ToString();
                        string MaSach = dtgvDsSachMuon.Rows[e.RowIndex].Cells[3].Value.ToString();
                        string TenDauSach = dtgvDsSachMuon.Rows[e.RowIndex].Cells[4].Value.ToString();
                        string NgayHenTra = dtgvDsSachMuon.Rows[e.RowIndex].Cells[5].Value.ToString();
                        string TienPhat = dtgvDsSachMuon.Rows[e.RowIndex].Cells[6].Value.ToString();
                        DateTime FutureDate = Convert.ToDateTime(NgayHenTra);
                        DateTime TodayDate = DateTime.Now;
                        DataGridViewRow rowt = (DataGridViewRow)dtgvDsSachTra.Rows[0].Clone();
                        rowt.Cells[1].Value = MaPhieuMuon;
                        rowt.Cells[2].Value = MaDauSach;
                        rowt.Cells[3].Value = MaSach;
                        rowt.Cells[4].Value = TenDauSach;
                        rowt.Cells[5].Value = NgayHenTra;
                        int days = (TodayDate - FutureDate).Days;
                        int tienphat = days * int.Parse(TienPhat);
                        if (tienphat < 0)
                        {
                            rowt.Cells[6].Value = 0;
                        }
                        else
                            rowt.Cells[6].Value = tienphat;
                        dtgvDsSachTra.Rows.Add(rowt);
                        dtgvDsSachMuon.Rows.Remove(row);
                    }
                }
            }
           
            
            
           
        }

        //private void dtgvDsSachMuon_KhoiTao()
        //{
        //  if(dtgvDsSachMuon!=null)
        //    { 
        //    dtgvDsSachMuon.Columns[1].HeaderText = "Mã phiếu mượn";
        //    dtgvDsSachMuon.Columns[2].HeaderText = "Mã đầu sách";
        //    dtgvDsSachMuon.Columns[3].HeaderText = "Mã sách";
        //    dtgvDsSachMuon.Columns[4].HeaderText = "Ngày hẹn trả";
        //    }
        //}
        private void dtgvDsSachTra_KhoiTao()
        {
            dtgvDsSachTra.ColumnCount += 6;
            dtgvDsSachTra.Columns[1].Name = "Mã phiếu mượn";
            dtgvDsSachTra.Columns[2].Name = "Mã đầu sách";
            dtgvDsSachTra.Columns[3].Name = "Mã sách";
            dtgvDsSachTra.Columns[4].Name = "Tên đầu sách";
            dtgvDsSachTra.Columns[5].Name = "Ngày hẹn trả";
            dtgvDsSachTra.Columns[6].Name = "Tiền phạt";
        }



        private void btnLuu_Click(object sender, EventArgs e)
        {
            phieuTra_BUS.LuuPhieuTra();
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTimSachMuonCuaDocGia_Click(object sender, EventArgs e)
        {
            dtgvDsSachMuon.DataSource = DauSach_BUS.LoadSachMuon(int.Parse(txtMaDocGia.Text));
        }

        private void dtgvDsSachTra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dtgvDsSachTra.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu");
            }
            else
            {
                foreach (DataGridViewRow row in dtgvDsSachTra.Rows)
                {
                    string MaPhieuMuon = dtgvDsSachTra.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string MaDauSach = dtgvDsSachTra.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string MaSach = dtgvDsSachTra.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string TenDauSach = dtgvDsSachTra.Rows[e.RowIndex].Cells[4].Value.ToString();
                    string NgayHenTra = dtgvDsSachTra.Rows[e.RowIndex].Cells[5].Value.ToString();
                    string TienPhat = dtgvDsSachTra.Rows[e.RowIndex].Cells[6].Value.ToString();
                    //DataGridViewRow rowt = (DataGridViewRow)dtgvDsSachTra.Rows[0].Clone();
                    //rowt.Cells[1].Value = MaPhieuMuon;
                    //rowt.Cells[2].Value = MaDauSach;
                    //rowt.Cells[3].Value = MaSach;
                    //rowt.Cells[4].Value = TenDauSach;
                    //rowt.Cells[5].Value = NgayHenTra;
                    //dtgvDsSachMuon.Rows.Add(rowt);
                    dtgvDsSachMuon.DataSource = DauSach_BUS.LoadDtgvSachMuon( int.Parse(MaSach), int.Parse(txtMaDocGia.Text));
                }
            }
            
        }
    }
}
