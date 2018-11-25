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

        private static string _connString = "Server=DESKTOP-TEQ1LNV\\SQLEXPRESS;Database=QLTV;Integrated Security=true";
        protected SqlConnection _conn = new SqlConnection("Server=DESKTOP-TEQ1LNV\\SQLEXPRESS;Database=QLTV;Integrated Security=true");

         public static string GetConnString()
        {
            return _connString;
        }

    }
}
