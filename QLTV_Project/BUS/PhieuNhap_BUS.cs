using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
namespace BUS
{
    public class PhieuNhap_BUS
    {
        PhieuNhap_DAO phieunhap_dao = new PhieuNhap_DAO();
        public int MaPhieuNhap()
        {
            return phieunhap_dao.MaPhieuNhap();
        }
    }
}
