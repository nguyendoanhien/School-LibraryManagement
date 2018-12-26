#region
using System.Windows.Forms;
using BUS;
#endregion

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
            var docGia_BUS = new DocGia_BUS();
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