#region
using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using DTO;
#endregion

namespace QuanLyThuVien
{
    public partial class frmThemDocGia : Form
    {
        private readonly DocGia_BUS docgia_bus = new DocGia_BUS();

        public frmThemDocGia()
        {
            InitializeComponent();
            var mangdung = docgia_bus.MaMax();
            txtMaDG.Text = mangdung + 1 + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK) picBoxAvatar.ImageLocation = ofd.FileName;
        }

        private void frmThemDocGia_Load(object sender, EventArgs e)
        {
            var loaidocgia_bus = new LoaiDocGia_BUS();
            foreach (DataRow dr in loaidocgia_bus.LoadCboLoaiDG().Rows)
                cboLoaiDG.Items.Add(dr["TenLoaiDocGia"].ToString());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // check radiobutton
            bool GioiTinh;
            if (rdoGioiTinh.Checked)
                GioiTinh = true;
            else
                GioiTinh = false;
            //check combobox
            var item = cboLoaiDG.GetItemText(cboLoaiDG.SelectedItem);
            var loaidg = item;


            var maloaidg = int.Parse(docgia_bus.TraVeGiaTriMaLoaiDG(loaidg));

            if (txtHoTen.Text != "" || txtEmail.Text != "")
            {
                var ng = new NguoiDung(0, txtHoTen.Text, GioiTinh, txtEmail.Text, dtmNgayTao.Value);
                if (docgia_bus.ThemNguoiDung(ng))
                {
                    var mangdung = docgia_bus.MaMax();
                    var dg = new DocGia(mangdung, maloaidg);
                    if (docgia_bus.ThemDocGia(dg))
                        MessageBox.Show("Đã thêm đôc giả vào thành công");
                    btnThoat.Focus();
                }
                else
                {
                    MessageBox.Show("Không thành công");
                }
            }
            else
            {
                MessageBox.Show("Xin nhập thông tin đầy đủ");
            }
        }
    }
}