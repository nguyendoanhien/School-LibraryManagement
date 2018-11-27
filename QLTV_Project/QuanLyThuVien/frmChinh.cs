using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Data.Sql;
using DTO;
using BUS;
namespace QuanLyThuVien
{
    public partial class frmChinh : Form
    {
        public frmChinh()
        {
            InitializeComponent();
            this.sttTime.Text = Get_Day();
            LoadBangDocGia();
            
        }
        

        public string Get_Day()
        {
            string ngay = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string nam = DateTime.Now.Year.ToString();
            string gio = DateTime.Now.Hour.ToString();
            string phut = DateTime.Now.Minute.ToString();
            string giay = DateTime.Now.Second.ToString();
            return ngay + "/" + thang + "/" + nam + " " + gio + ":" + phut + ":" + giay;

        }
        public void LoadBangDocGia()
        {
            DocGia_BUS docgia_bus = new DocGia_BUS();
            dgvDocGia.DataSource = docgia_bus.LoadBangDocGia();
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
            frmPhieuMuon frmMuon = new frmPhieuMuon();
            frmMuon.Show();
        }

        private void phiếuTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuTra frmMuon = new frmPhieuTra();
            frmMuon.Show();
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuNhap frmNhap = new frmPhieuNhap();
            frmNhap.Show();
        }

        private void phiếuGiaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuGiao frmGiao = new frmPhieuGiao();
            frmGiao.Show();
        }

        private void tKĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThemDocGia frmThemDG = new frmThemDocGia();
            if(frmThemDG.ShowDialog() == DialogResult.OK)
            {
                LoadBangDocGia();
            }
        }

        private void tTĐộcGiảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaDocGia_Click(object sender, EventArgs e)
        {
            int a = dgvDocGia.CurrentCell.RowIndex;
            string hihi = dgvDocGia.Rows[a].Cells[0].Value.ToString().Trim();
            MessageBox.Show(hihi);

            DocGia_BUS docgia_bus = new DocGia_BUS();
            if (docgia_bus.XoaDocGia(int.Parse(hihi)))
            {
                MessageBox.Show("Đã xoá thành công");
                LoadBangDocGia();
            }
            else MessageBox.Show("Không thành công!!");
        }
    }
}
