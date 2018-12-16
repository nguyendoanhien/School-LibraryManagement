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
            //DauSachLoai_BUS dauSachLoai_BUS = new DauSachLoai_BUS();
            //cbxMucTim.DataSource = dauSachLoai_BUS.LoadComBoBoxDauSachLoai("DauSachLoai").Tables[0];
            //cbxMucTim.DisplayMember = "TenLoaiDauSach";
            //cbxMucTim.ValueMember = "MaLoaiDauSach";
        }

        public void LoadBangDauSach()
        {
            DauSachLoai_BUS dauSachLoai_bus = new DauSachLoai_BUS();
            dgvDSSach.DataSource = DauSach_BUS.LoadDauSach();
        }

        private void txtTimSachMuon_TextChanged(object sender, EventArgs e)
        {
            //BindingSource bs = new BindingSource();
            //bs.DataSource = dgvDSSach.DataSource;
            //bs.Filter = columnNameToSearch + " like '%" + textBox1.Text + "%'";
            //dataGridView1.DataSource = bs;
        }
    }


}
