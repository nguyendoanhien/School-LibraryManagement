using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DTO;
using DAO;
namespace BUS
{
    public class DocGia_BUS
    {
        public bool ThemNguoiDung(DTO.NguoiDung ng)
        {
            DocGia_DAO docgia_dao = new DocGia_DAO();
            return docgia_dao.themNguoiDung(ng);
        }

        public bool ThemDocGia(DTO.DocGia dg)
        {
            DocGia_DAO docgia_dao = new DocGia_DAO();
            return docgia_dao.ThemDocGia(dg);
        }

        public string TraVeGiaTriMaLoaiDG(string a)
        {
            DocGia_DAO docgia_dao = new DocGia_DAO();
            return docgia_dao.TraVeGiaTriMaLoaiDG(a);
        }

        public int MaMax()
        {
            DocGia_DAO docgia_dao = new DocGia_DAO();
            return docgia_dao.MaMax();
        }

        public static DataTable LoadBangDocGia()
        {
            return DocGia_DAO.LoadBangDocGia();
        }

        public bool XoaDocGia(int maCanXoa)
        {
            DocGia_DAO docgia_dao = new DocGia_DAO();
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
