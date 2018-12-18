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
    public partial class frmDauSachDuocMuon : Form
    {
        public frmDauSachDuocMuon()
        {
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
            dgvDSSach.DataSource = DauSach_BUS.LoadDauSach();
        }

        private void txtTimSachMuon_TextChanged(object sender, EventArgs e)
        {
            string s = cbxMucTim.SelectedItem.ToString();
            dgvDSSach.DataSource = DauSach_BUS.TimSach(s,txtTimSachMuon.Text);
        }
        private string maDauSach;
        private string maSach;
        private string tenDauSach;
        private int NgayTra;
        public string MaDauSach { get => maDauSach; set => maDauSach = value; }
        public string MaSach { get => maSach; set => maSach = value; }
        public string TenDauSach { get => tenDauSach; set => tenDauSach = value; }
        public int NgayTra1 { get => NgayTra; set => NgayTra = value; }

        public void dgvDSSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.maDauSach = dgvDSSach.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.maSach = dgvDSSach.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.tenDauSach = dgvDSSach.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.NgayTra = int.Parse(dgvDSSach.Rows[e.RowIndex].Cells[5].Value.ToString());
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

       
    }
    }


