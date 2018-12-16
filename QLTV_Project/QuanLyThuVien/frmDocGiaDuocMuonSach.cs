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
    public partial class frmDocGiaDuocMuonSach : Form
    {
        public frmDocGiaDuocMuonSach()
        {
            InitializeComponent();
            LoadDanhMucDocGia();
            LoadDocGia();
        }
        

        public void LoadDanhMucDocGia()
        {
            DocGia_BUS docGia_BUS = new DocGia_BUS();
            cbxLoaiDG.DisplayMember = "TenLoaiDocGia";
            cbxLoaiDG.ValueMember = "MaLoaiDocGia";
            cbxLoaiDG.DataSource = docGia_BUS.LoadComBoBoxLoaiDocGia("DocGiaLoai").Tables[0];
        }
        public void LoadDocGia()
        {
            dgvDocGia.DataSource = DocGia_BUS.LoadBangDocGia();
        }
    }
}
