using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;
namespace BUS
{
    public class DauSachLoai_BUS
    {
        DauSach_DAO dausach_dao = new DauSach_DAO();
        public DataSet LoadComBoBoxDauSachLoai(string tenbang)
        {
            return dausach_dao.LoadComBoDauSach(tenbang);
        }
    }
}
