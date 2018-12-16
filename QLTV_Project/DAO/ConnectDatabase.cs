using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;
using System.Data;
using System.Data.OleDb;

namespace DAO
{
    public class ConnectDatabase
    {

        private static string _connString = "Server=DESKTOP-TEQ1LNV\\SQLEXPRESS;Database=QLTV;Integrated Security=true";
        public static SqlConnection _conn = new SqlConnection("Server=DESKTOP-TEQ1LNV\\SQLEXPRESS;Database=QLTV;Integrated Security=true");

         public static string GetConnString()
        {
            return _connString;
        }

        public static DataSet getdataset(string sql, string tenbang, SqlConnection _conn)
        {

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            da.Fill(ds, tenbang);
            return ds;
        }
    }
}
