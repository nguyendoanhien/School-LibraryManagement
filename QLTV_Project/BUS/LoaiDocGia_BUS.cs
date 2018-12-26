#region
using System.Data;
using DAO;
#endregion

namespace BUS
{
    public class LoaiDocGia_BUS
    {
        private readonly LoaiDocGia_DAO LoaiDocGia_dao = new LoaiDocGia_DAO();

        public DataTable getLoaiDocGia()
        {
            return LoaiDocGia_dao.getLoaiDocGia();
        }

        public DataTable LoadCboLoaiDG()
        {
            return LoaiDocGia_dao.LoadCbo();
        }
    }
}