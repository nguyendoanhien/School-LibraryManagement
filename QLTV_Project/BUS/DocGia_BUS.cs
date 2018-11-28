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

        public DataTable LoadBangDocGia()
        {
            DocGia_DAO docgia_dao = new DocGia_DAO();
            return docgia_dao.LoadBangDocGia();
        }

        public bool XoaDocGia(int maCanXoa)
        {
            DocGia_DAO docgia_dao = new DocGia_DAO();
            return docgia_dao.XoaDocGia(maCanXoa);
        }

        public DataTable LoadComBoBoxLoaiDocGia()
        {
            DocGia_DAO docgia_dao = new DocGia_DAO();
            return docgia_dao.LoadComBoBoxLoaiDocGia();
        }
    }
}
