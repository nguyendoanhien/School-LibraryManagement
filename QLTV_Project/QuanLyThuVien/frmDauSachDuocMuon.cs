#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BUS;
#endregion

namespace QuanLyThuVien
{
    public partial class frmDauSachDuocMuon : Form
    {
        private readonly DataGridView cuaFrmPhieuMuon;

        public frmDauSachDuocMuon(DataGridView cuaFrmPhieuMuon)
        {
            this.cuaFrmPhieuMuon = cuaFrmPhieuMuon;
            InitializeComponent();
            LoadComBoBoxLoaiDauSach();
            LoadBangDauSach();
        }

        public void LoadComBoBoxLoaiDauSach()
        {
            cbxMucTim.Items.Add("MaDauSach");
            cbxMucTim.Items.Add("TenDauSach");
            cbxMucTim.Items.Add("TenLoaiDauSach");
            cbxMucTim.SelectedIndex = 0;

            //DauSachLoai_BUS dauSachLoai_BUS = new DauSachLoai_BUS();
            //cbxMucTim.DataSource = dauSachLoai_BUS.LoadComBoBoxDauSachLoai("DauSachLoai").Tables[0];
            //cbxMucTim.DisplayMember = "TenLoaiDauSach";
            //cbxMucTim.ValueMember = "MaLoaiDauSach";
        }

        public void LoadBangDauSach()
        {
            dgvDSSach.DataSource = null;
            dgvDSSach.DataSource = DauSach_BUS.LoadDauSach();
            var vtSeXoa = new List<int>();
            if (cuaFrmPhieuMuon.Rows.Count > 1)
                for (var i = 0; i < dgvDSSach.Rows.Count - 1; i++)
                for (var j = 0; j < cuaFrmPhieuMuon.Rows.Count - 1; j++)
                {
                    var meMaDauSach = dgvDSSach.Rows[i].Cells["MaDauSach"].Value.ToString();
                    var meMaSach = dgvDSSach.Rows[i].Cells["STT"].Value.ToString();
                    var youMaDauSach = cuaFrmPhieuMuon.Rows[j].Cells["MaDauSach"].Value.ToString();
                    var youMaSach = cuaFrmPhieuMuon.Rows[j].Cells["MaSach"].Value.ToString();
                    if (youMaDauSach == meMaDauSach && youMaSach == meMaSach)
                    {
                        vtSeXoa.Add(i);
                        break;
                    }
                }

            foreach (var i in vtSeXoa.ToArray().Reverse()) dgvDSSach.Rows.RemoveAt(i);
        }

        private void txtTimSachMuon_TextChanged(object sender, EventArgs e)
        {
            var s = cbxMucTim.SelectedItem.ToString();
            dgvDSSach.DataSource = DauSach_BUS.TimSach(s, txtTimSachMuon.Text);
        }

        public string MaDauSach { get; set; }
        public string MaSach { get; set; }
        public string TenDauSach { get; set; }
        public int NgayTra1 { get; set; }

        public void dgvDSSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MaDauSach = dgvDSSach.Rows[e.RowIndex].Cells["MaDauSach"].Value.ToString();
            MaSach = dgvDSSach.Rows[e.RowIndex].Cells["STT"].Value.ToString();
            TenDauSach = dgvDSSach.Rows[e.RowIndex].Cells["TenDauSach"].Value.ToString();
            NgayTra1 = int.Parse(dgvDSSach.Rows[e.RowIndex].Cells["SoNgayMuonToiDa"].Value.ToString());
            DialogResult = DialogResult.OK;
        }
    }
}