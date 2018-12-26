#region
using System.Data;
using DAO;
#endregion

namespace BUS
{
    public class NCC_BUS
    {
        private readonly NCC_DAO NCC_dao = new NCC_DAO();

        public DataTable getNCC()
        {
            return NCC_dao.getNCC();
        }
    }
}