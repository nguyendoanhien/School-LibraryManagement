using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class NCC_DAO: ConnectDatabase
    {
        public DataTable getNCC()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NCC", _conn);
            DataTable dtNCC = new DataTable();
            da.Fill(dtNCC);
            return dtNCC;
        }
    }
}
