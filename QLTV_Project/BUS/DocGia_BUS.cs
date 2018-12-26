#region
using System.Data;
using DAO;
using DTO;
#endregion

namespace BUS
{
    public class DocGia_BUS
    {
        public bool ThemNguoiDung(NguoiDung ng)
        {
            var docgia_dao = new DocGia_DAO();
            return docgia_dao.themNguoiDung(ng);
        }

        public bool ThemDocGia(DocGia dg)
        {
            var docgia_dao = new DocGia_DAO();
            return docgia_dao.ThemDocGia(dg);
        }

        public string TraVeGiaTriMaLoaiDG(string a)
        {
            var docgia_dao = new DocGia_DAO();
            return docgia_dao.TraVeGiaTriMaLoaiDG(a);
        }

        public int MaMax()
        {
            var docgia_dao = new DocGia_DAO();
            return docgia_dao.MaMax();
        }

        public static DataTable LoadBangDocGia()
        {
            return DocGia_DAO.LoadBangDocGia();
        }

        public bool XoaDocGia(int maCanXoa)
        {
            var docgia_dao = new DocGia_DAO();
            return docgia_dao.XoaDocGia(maCanXoa);
        }

        public DataSet LoadComBoBoxLoaiDocGia(string tenbang)
        {
            return DocGia_DAO.LoadComBoBoxLoaiDocGia(tenbang);
        }

        public static bool KiemTraDuocMuon(int maDocGia)
        {
            return DocGia_DAO.KiemTraDuocMuon(maDocGia);
        }

        public static bool Kt_SachMuon(int maDocGia, int maDauSach)
        {
            return DocGia_DAO.KT_SachMuon(maDocGia, maDauSach);
        }

        public static bool KiemTraDocGia(int maDocGia)
        {
            return DocGia_DAO.KiemTraDocGia(maDocGia);
        }

        public static int? LaySachMuonToiDa(int maDocGia)
        {
            return DocGia_DAO.LaySachMuonToiDa(maDocGia);
        }
    }
}