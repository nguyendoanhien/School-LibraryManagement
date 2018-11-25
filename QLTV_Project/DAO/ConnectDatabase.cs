using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;
namespace DAO
{
    public class ConnectDatabase
    {
        

        protected SqlConnection _conn = new SqlConnection("Server=HIENCOMPUTER\\DOANHIEN;Database=QuanLyThuVien;Integrated Security=true");

    }
}
