using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
   public class NhanVien_BUS
    {

        public static bool KiemTraNhanVien(NhanVien obj)
        {
            return NhanVien_DAO.KiemTraNhanVien(obj);

        }
    }
}
