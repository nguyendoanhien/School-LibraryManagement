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
        public DataSet LoadComBoBoxDauSachLoai(string tenbang)
        {
            return DauSach_DAO.LoadComBoDauSach(tenbang);
        }


    }
}
