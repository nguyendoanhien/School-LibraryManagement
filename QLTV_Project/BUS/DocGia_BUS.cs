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
    }
}
