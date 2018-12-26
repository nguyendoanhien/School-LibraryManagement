#region
using System;
using System.Windows.Forms;
using BUS;
#endregion

namespace QuanLyThuVien
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
            sttTime.Text = Get_Day();
            LoadBangDocGia();
            LoadBangDauSach();
            LoadComBoBoxLoaiDocGia();
            LoadComBoBoxLoaiDauSach();
        }

        public string Get_Day()
        {
            var ngay = DateTime.Now.Day.ToString();
            var thang = DateTime.Now.Month.ToString();
            var nam = DateTime.Now.Year.ToString();
            var gio = DateTime.Now.Hour.ToString();
            var phut = DateTime.Now.Minute.ToString();
            var giay = DateTime.Now.Second.ToString();
            return ngay + "/" + thang + "/" + nam + " " + gio + ":" + phut + ":" + giay;
        }

        public void LoadBangDocGia()
        {
            dgvDocGia.DataSource = DocGia_BUS.LoadBangDocGia();
        }

        private void frmChinh_Load(object sender, EventArgs e)
        {
            //HideTabPage(tabPage4);
        }

        private void HideTabPage(TabPage tp)
        {
            if (tabControl1.TabPages.Contains(tp))
                tabControl1.TabPages.Remove(tp);
        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmMuon = new frmPhieuMuon();
            frmMuon.Show();
        }

        private void phiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmMuon = new frmPhieuTra();
            frmMuon.Show();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmNhap = new frmPhieuNhap();
            frmNhap.Show();
        }

        private void phiếuGiaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmGiao = new frmPhieuGiao();
            frmGiao.Show();
        }

        private void tKĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmThemDG = new frmThemDocGia();
            if (frmThemDG.ShowDialog() == DialogResult.OK) LoadBangDocGia();
        }

        private void tTĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnXoaDocGia_Click(object sender, EventArgs e)
        {
            var a = dgvDocGia.CurrentCell.RowIndex;
            var hihi = dgvDocGia.Rows[a].Cells[0].Value.ToString().Trim();
            MessageBox.Show(hihi);

            var docgia_bus = new DocGia_BUS();
            if (docgia_bus.XoaDocGia(int.Parse(hihi)))
            {
                MessageBox.Show("Đã xoá thành công");
                LoadBangDocGia();
            }
            else
            {
                MessageBox.Show("Không thành công!!");
            }
        }

        private DauSach_BUS dausach_bus = new DauSach_BUS();

        public void LoadBangDauSach()
        {
            dgvDSSach.DataSource = DauSach_BUS.LoadDauSach();
        }

        private void txtTenNguoiDN_Click(object sender, EventArgs e)
        {
        }

        public void LoadComBoBoxLoaiDocGia()
        {
            var docGia_BUS = new DocGia_BUS();
            cbxLoaiDG.DisplayMember = "TenLoaiDocGia";
            cbxLoaiDG.ValueMember = "MaLoaiDocGia";
            cbxLoaiDG.DataSource = docGia_BUS.LoadComBoBoxLoaiDocGia("DocGiaLoai").Tables[0];
        }

        public void LoadComBoBoxLoaiDauSach()
        {
            var dauSachLoai_BUS = new DauSachLoai_BUS();
            cbxDauSachLoai.DataSource = dauSachLoai_BUS.LoadComBoBoxDauSachLoai("DauSachLoai").Tables[0];
            cbxDauSachLoai.DisplayMember = "TenLoaiDauSach";
            cbxDauSachLoai.ValueMember = "MaLoaiDauSach";
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ret = MessageBox.Show("Hỏi thoát", "Bạn có muốn thoát?", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (ret == DialogResult.OK) Close();
        }
    }
}