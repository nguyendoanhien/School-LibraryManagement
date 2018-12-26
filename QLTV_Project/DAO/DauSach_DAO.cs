#region
using System;
using System.Data;
using System.Data.SqlClient;
#endregion

namespace DAO
{
    public class DauSach_DAO : ConnectDatabase
    {
        public static DataTable LoadDauSach()
        {
            try
            {
                // Ket noi
                var conn = GetConnString();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                var sql = "LoadDauSach";
                SqlParameter[] pars = { };
                var soLuongOK = SqlHelper.ExecuteReader(conn, sql, CommandType.StoredProcedure, pars);

                var dataTable = new DataTable();
                dataTable.Load(soLuongOK);
                if (dataTable.Rows.Count > 0) return dataTable;

                // Query và kiểm tra
            }
            catch (Exception e)
            {
            }

            return null;
        }

        public static DataSet LoadComBoDauSach(string tenbang)
        {
            try
            {
                // Ket noi
                var conn = GetConnString();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                var sql = "SELECT * from DauSachLoai ";
                return getdataset(sql, tenbang, _conn);

                // Query và kiểm tra
            }
            catch (Exception e)
            {
            }

            return null;
        }

        public static DataTable TimSach(string mucTim, string tenTim)
        {
            try
            {
                // Ket noi
                var conn = GetConnString();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                var sql = "TimSachDeMuon";
                SqlParameter[] pars =
                {
                    new SqlParameter("@mucTim", SqlDbType.NVarChar) {Value = mucTim},
                    new SqlParameter("@tenTim", SqlDbType.NVarChar) {Value = tenTim}
                };
                var soLuongOK = SqlHelper.ExecuteReader(conn, sql, CommandType.StoredProcedure, pars);

                var dataTable = new DataTable();
                dataTable.Load(soLuongOK);
                if (dataTable.Rows.Count > 0) return dataTable;

                // Query và kiểm tra
            }
            catch (Exception e)
            {
            }

            return null;
        }

        public static DataTable LoadSachMuon(int maDocGia)
        {
            try
            {
                // Ket noi
                var conn = GetConnString();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                var sql = "LoadSachMuon";
                SqlParameter[] pars =
                {
                    new SqlParameter("@maDocGia", SqlDbType.Int) {Value = maDocGia}
                };
                var soLuongOK = SqlHelper.ExecuteReader(conn, sql, CommandType.StoredProcedure, pars);

                var dataTable = new DataTable();
                dataTable.Load(soLuongOK);
                if (dataTable.Rows.Count > 0) return dataTable;

                // Query và kiểm tra
            }
            catch (Exception e)
            {
            }

            return null;
        }

        public static DataTable LoadDtgvMuon(int maSach, int maDocGia)
        {
            try
            {
                // Ket noi
                var conn = GetConnString();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                var sql = "LoadDtgvMuon";
                SqlParameter[] pars =
                {
                    new SqlParameter("@maSach", SqlDbType.Int) {Value = maSach},
                    new SqlParameter("@maDocGia", SqlDbType.Int) {Value = maDocGia}
                };
                var soLuongOK = SqlHelper.ExecuteReader(conn, sql, CommandType.StoredProcedure, pars);

                var dataTable = new DataTable();
                dataTable.Load(soLuongOK);
                if (dataTable.Rows.Count > 0) return dataTable;

                // Query và kiểm tra
            }
            catch (Exception e)
            {
            }

            return null;
        }
    }
}