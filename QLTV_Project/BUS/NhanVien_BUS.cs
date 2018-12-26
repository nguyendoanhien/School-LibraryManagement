#region
using DAO;
using DTO;
#endregion

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