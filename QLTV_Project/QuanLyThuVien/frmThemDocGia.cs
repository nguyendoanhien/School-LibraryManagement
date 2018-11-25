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
    public partial class frmThemDocGia : Form
    {
        public frmThemDocGia()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                picBoxAvatar.ImageLocation = ofd.FileName;
            }
        }

        private void frmThemDocGia_Load(object sender, EventArgs e)
        {
            LoaiDocGia_BUS loaidocgia_bus = new LoaiDocGia_BUS();
            foreach (DataRow dr in loaidocgia_bus.LoadCboLoaiDG().Rows)
            {
                cboLoaiDG.Items.Add(dr["TenLoai"].ToString());
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
