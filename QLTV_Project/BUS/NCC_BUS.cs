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
    public class NCC_BUS
    {
        NCC_DAO NCC_dao = new NCC_DAO();
        public DataTable getNCC()
        {
            return NCC_dao.getNCC();
        }
    }
}
