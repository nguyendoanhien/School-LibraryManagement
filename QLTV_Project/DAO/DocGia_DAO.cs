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
    public class DocGia_DAO : ConnectDatabase
    {
        public bool themNguoiDung(DTO.NguoiDung ng)
        {
            try
            {
                // Ket noi
                string conn = ConnectDatabase.GetConnString();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string sql = "INSERT INTO NguoiDung (HoVaTen,GioiTinh,Email,NgayTao) VALUES  (@HoVaTen, @GioiTinh, @Email, @NgayTao)";
                SqlParameter[] pars =
                {
                    new SqlParameter("@HoVaTen", SqlDbType.NVarChar) { Value = ng.HoVaTen },
                    new SqlParameter("@GioiTinh", SqlDbType.Bit) { Value = ng.GioiTinh },
                    new SqlParameter("@Email", SqlDbType.VarChar) { Value = ng.Email },
                    new SqlParameter("@NgayTao", SqlDbType.DateTime) { Value = ng.NgayTao }
                };

                int soLuongOK = SqlHelper.ExecuteNonQuery(conn, sql, CommandType.Text, pars);

                if (soLuongOK > 0) return true;

                return false;

                // Query và kiểm tra


            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }

            return false;
        }

        public bool ThemDocGia(DTO.DocGia dg)
        {
            try
            {
                string conn = ConnectDatabase.GetConnString();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string sql = "dbo.InsertDocGia";
                SqlParameter[] pars =
                {
                    new SqlParameter("@maDG", SqlDbType.Int) { Value = dg.Ma },
                    new SqlParameter("@maLoaiDG", SqlDbType.Int) { Value = dg.MaLoai },

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
                // Dong ket noi
                _conn.Close();
            }
            return false;
        }

        public string TraVeGiaTriMaLoaiDG(string TenLoaiDocGia)
        {
            try
            {
                string conn = ConnectDatabase.GetConnString();
                string sql = "select MaLoaiDocGia from DocGiaLoai where TenLoaiDocGia = @tenloaiDG";
                SqlParameter[] pars =
                {
                    new SqlParameter("@tenloaiDG", SqlDbType.NVarChar) { Value = TenLoaiDocGia },

                };
                var soLuongOK = SqlHelper.ExecuteScalar(conn, sql, CommandType.Text, pars);

                if (soLuongOK != null) return soLuongOK.ToString();
                else return "lỗi";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
        }

        public int MaMax()
        {
            try
            {
                string conn = ConnectDatabase.GetConnString();
                string sql = "select MAX(MaNguoiDung) from NguoiDung";
                SqlParameter[] pars ={};
                var soLuongOK = SqlHelper.ExecuteScalar(conn, sql, CommandType.Text, pars);

                int gt = int.Parse(soLuongOK.ToString());

                if (soLuongOK != null) return gt;
                else return 0;
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return 0;
        }

        public SqlDataReader getNCC()
        {
            try
            {
                // Ket noi
                string conn = ConnectDatabase.GetConnString();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string sql = "select a.MaDocGia,c.TenLoaiDocGia,b.HoVaTen,b.GioiTinh,b.Email,b.NgayTao from DocGia a, NguoiDung b, DocGiaLoai c where a.MaDocGia = b.MaNguoiDung and a.MaLoaiDocGia = c.MaLoaiDocGia";
                SqlParameter[] pars = { };


                var soLuongOK = SqlHelper.ExecuteReader(conn, sql, CommandType.Text, pars);

                if (soLuongOK != null) return soLuongOK;

                return null;

                // Query và kiểm tra


            }
            catch (Exception e)
            {

            }
            finally
            {
                // Dong ket noi
                _conn.Close();
            }
            return null;
        }

        public static DataTable LoadBangDocGia()
        {
            SqlDataAdapter da = new SqlDataAdapter("select a.MaDocGia, c.TenLoaiDocGia, b.HoVaTen, b.GioiTinh, b.Email, b.NgayTao from DocGia a, NguoiDung b, DocGiaLoai c where a.MaDocGia = b.MaNguoiDung and a.MaLoaiDocGia = c.MaLoaiDocGia", _conn);
            DataTable dtNCC = new DataTable();
            da.Fill(dtNCC);
            return dtNCC;
        }

        public static DataSet LoadComBoBoxLoaiDocGia(string tenbang)
        {
            try
            {
                // Ket noi
                string conn = ConnectDatabase.GetConnString();
                 
                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                string sql = "SELECT * from DocGiaLoai";
                return getdataset(sql, tenbang, _conn );

                // Query và kiểm tra


            }
            catch (Exception e)
            {

            }
            return null;
        }

        public bool XoaDocGia(int maDocGia)
        {
            try
            {
                string conn = ConnectDatabase.GetConnString();string sql = "DocGia_Xoa";
                SqlParameter[] pars =
                {
                    new SqlParameter("@maCanXoa", SqlDbType.Int) { Value = maDocGia },
                    
                };

                int soLuongOK = SqlHelper.ExecuteNonQuery(conn, sql, CommandType.StoredProcedure, pars);

                if (soLuongOK > 0) return true;

                return false;
            }
            catch (Exception e)
            {

            }
            return false;
        }


        public static int TimDocGia(int maDocGia)
        {
            string sql = "KT_DocGia";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            _conn.Open();
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maDocGia", maDocGia).Direction = System.Data.ParameterDirection.Input;
            cmd.Parameters.Add("@kq", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            int outval = (int)cmd.Parameters["@kq"].Value;
            _conn.Close();
            return outval;
        }

        public static int KT_SachMuon(int maDocGia, int maDauSach)
        {
            string sql = "KT_SachMuon";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = _conn;
            _conn.Open();
            cmd.CommandText = sql;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maDocGia", maDocGia).Direction = System.Data.ParameterDirection.Input;
            cmd.Parameters.AddWithValue("@maDauSach", maDocGia).Direction = System.Data.ParameterDirection.Input;
            cmd.Parameters.Add("@kq", System.Data.SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            int outval = (int)cmd.Parameters["@kq"].Value;
            _conn.Close();
            return outval;
        }
    }
}
