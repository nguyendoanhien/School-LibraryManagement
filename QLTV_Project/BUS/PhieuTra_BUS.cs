#region
using DAO;
#endregion

namespace BUS
{
    public class PhieuTra_BUS
    {
        private readonly PhieuTra_DAO phieuTra_DAO = new PhieuTra_DAO();

        public int MaPhieuTra()
        {
            return phieuTra_DAO.MaPhieuTra();
        }

        public bool LuuPhieuTra()
        {
            return phieuTra_DAO.LuuPhieuTra();
        }
    }
}