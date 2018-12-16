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
            DauSachLoai_BUS dauSachLoai_BUS = new DauSachLoai_BUS();
            cbxDauSachLoai.DataSource = dauSachLoai_BUS.LoadComBoBoxDauSachLoai("DauSachLoai").Tables[0];
            cbxDauSachLoai.DisplayMember = "TenLoaiDauSach";
            cbxDauSachLoai.ValueMember = "MaLoaiDauSach";
        }

        public void LoadBangDauSach()
        {
            DauSachLoai_BUS dauSachLoai_bus = new DauSachLoai_BUS();
            dgvDSSach.DataSource = DauSach_BUS.LoadDauSach();
        }


    }


}
