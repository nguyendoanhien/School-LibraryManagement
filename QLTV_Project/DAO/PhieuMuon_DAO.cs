using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using System.Data.SqlClient;
using System.Data;
using DTO;
namespace DAO
{
    public class PhieuMuon_DAO: ConnectDatabase
    {
        public DataTable LoadSachMuon(int maPhieuMuon)
        {
            try
            {
                // Ket noi
                string conn = ConnectDatabase.GetConnString();
                
                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string sql = "LoadSachMuon";
                SqlParameter[] pars = { new SqlParameter("@maphieumuon", SqlDbType.Int) { Value = maPhieuMuon } };
                SqlDataReader soLuongOK = SqlHelper.ExecuteReader(conn, sql, CommandType.StoredProcedure, pars);

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

        public static int MaPhieuMuon()
        {
            try
            {
                string conn = ConnectDatabase.GetConnString();
                string sql = "select MAX(MaPhieu) from Phieu";
                SqlParameter[] pars = { };
                var soLuongOK = SqlHelper.ExecuteScalar(conn, sql, CommandType.Text, pars);

                int gt = int.Parse(soLuongOK.ToString());

                if (soLuongOK != null) return gt + 1;
                else return 1;
            }
            catch (Exception e)
            {

            }
            return 1;
        }

        public static bool Insert_Phieu( int maNguoiLap, DateTime ngayLap)
        {
            try
            {
                string conn = ConnectDatabase.GetConnString();
                string sql = "dbo.Insert_Phieu";
                SqlParameter[] pars =
                {
                    new SqlParameter("@maNguoiLap", SqlDbType.Int) { Value = maNguoiLap },
                    new SqlParameter("@ngayLap", SqlDbType.DateTime) { Value = ngayLap },

                };
                int soLuongOK = SqlHelper.ExecuteNonQuery(conn, sql, CommandType.StoredProcedure, pars);

                if (soLuongOK > 0) return true;

                return false;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public static bool Insert_PhieuMuon(int maPhieuMuon, int maDocGia)
        {
            try
            {
                string conn = ConnectDatabase.GetConnString();
                string sql = "dbo.Insert_PhieuMuon";
                SqlParameter[] pars =
                {
                    new SqlParameter("@maPhieuMuon", SqlDbType.Int) { Value = maPhieuMuon },
                    new SqlParameter("@maDocGia", SqlDbType.Int) { Value = maDocGia },

                };
                int soLuongOK = SqlHelper.ExecuteNonQuery(conn, sql, CommandType.StoredProcedure, pars);

                if (soLuongOK > 0) return true;
                else  return false;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }

        public static bool Insert_PhieuMuonChiTiet(int maSach, int maPhieuMuon, int maDauSach, string ngayHenTra)
        {
            try
            {
                string conn = ConnectDatabase.GetConnString();
                string sql = "dbo.Insert_PhieuMuonChiTiet";
                SqlParameter[] pars =
                {
                    new SqlParameter("@maSach", SqlDbType.Int) { Value = maSach },
                    new SqlParameter("@maPhieuMuon", SqlDbType.Int) { Value = maPhieuMuon },
                    new SqlParameter("@maDauSach", SqlDbType.Int) { Value = maDauSach },
                    new SqlParameter("@ngayHenTra", SqlDbType.DateTime) { Value = ngayHenTra },

                };
                int soLuongOK = SqlHelper.ExecuteNonQuery(conn, sql, CommandType.StoredProcedure, pars);

                if (soLuongOK > 0) return true;

                return false;

            }
            catch (Exception ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
