#region
using DAO;
#endregion

namespace BUS
{
    public class PhieuNhap_BUS
    {
        private readonly PhieuNhap_DAO phieunhap_dao = new PhieuNhap_DAO();

        public int MaPhieuNhap()
        {
            return phieunhap_dao.MaPhieuNhap();
        }

        public bool XoaDauSach(int gtxoa)
        {
            return phieunhap_dao.XoaDauSach(gtxoa);
        }

        public bool ThemDauSach(int gtthem)
        {
            return phieunhap_dao.XoaDauSach(gtthem);
        }
    }
}