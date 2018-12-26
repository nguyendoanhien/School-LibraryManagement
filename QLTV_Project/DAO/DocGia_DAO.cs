#region
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DTO;
#endregion

namespace DAO
{
    public class DocGia_DAO : ConnectDatabase
    {
        public bool themNguoiDung(NguoiDung ng)
        {
            try
            {
                // Ket noi
                var conn = GetConnString();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                var sql =
                    "INSERT INTO NguoiDung (HoVaTen,GioiTinh,Email,NgayTao) VALUES  (@HoVaTen, @GioiTinh, @Email, @NgayTao)";
                SqlParameter[] pars =
                {
                    new SqlParameter("@HoVaTen", SqlDbType.NVarChar)
                    {
                        Value = ng.HoVaTen
                    },
                    new SqlParameter("@GioiTinh", SqlDbType.Bit)
                    {
                        Value = ng.GioiTinh
                    },
                    new SqlParameter("@Email", SqlDbType.VarChar)
                    {
                        Value = ng.Email
                    },
                    new SqlParameter("@NgayTao", SqlDbType.DateTime)
                    {
                        Value = ng.NgayTao
                    }
                };

                var soLuongOK = SqlHelper.ExecuteNonQuery(conn, sql, CommandType.Text, pars);

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

        public bool ThemDocGia(DocGia dg)
        {
            try
            {
                var conn = GetConnString();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                var sql = "dbo.InsertDocGia";
                SqlParameter[] pars =
                {
                    new SqlParameter("@maDG", SqlDbType.Int)
                    {
                        Value = dg.Ma
                    },
                    new SqlParameter("@maLoaiDG", SqlDbType.Int)
                    {
                        Value = dg.MaLoai
                    }
                };

                var soLuongOK = SqlHelper.ExecuteNonQuery(conn, sql, CommandType.StoredProcedure, pars);

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
                var conn = GetConnString();
                var sql = "select MaLoaiDocGia from DocGiaLoai where TenLoaiDocGia = @tenloaiDG";
                SqlParameter[] pars =
                {
                    new SqlParameter("@tenloaiDG", SqlDbType.NVarChar)
                    {
                        Value = TenLoaiDocGia
                    }
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
                var conn = GetConnString();
                var sql = "select MAX(MaNguoiDung) from NguoiDung";
                SqlParameter[] pars = { };
                var soLuongOK = SqlHelper.ExecuteScalar(conn, sql, CommandType.Text, pars);

                var gt = int.Parse(soLuongOK.ToString());

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
                var conn = GetConnString();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                var sql =
                    "select a.MaDocGia,c.TenLoaiDocGia,b.HoVaTen,b.GioiTinh,b.Email,b.NgayTao from DocGia a, NguoiDung b, DocGiaLoai c where a.MaDocGia = b.MaNguoiDung and a.MaLoaiDocGia = c.MaLoaiDocGia";
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
            var da = new SqlDataAdapter(
                "select a.MaDocGia, c.TenLoaiDocGia, b.HoVaTen, b.GioiTinh, b.Email, b.NgayTao from DocGia a, NguoiDung b, DocGiaLoai c where a.MaDocGia = b.MaNguoiDung and a.MaLoaiDocGia = c.MaLoaiDocGia",
                _conn);
            var dtNCC = new DataTable();
            da.Fill(dtNCC);
            return dtNCC;
        }

        public static DataSet LoadComBoBoxLoaiDocGia(string tenbang)
        {
            try
            {
                // Ket noi
                var conn = GetConnString();

                // Query string - vì mình để TV_ID là identity (giá trị tự tăng dần) nên ko cần fải insert ID
                var sql = "SELECT * from DocGiaLoai";
                return getdataset(sql, tenbang, _conn);

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
                var conn = GetConnString();
                var sql = "DocGia_Xoa";
                SqlParameter[] pars =
                {
                    new SqlParameter("@maCanXoa", SqlDbType.Int)
                    {
                        Value = maDocGia
                    }
                };

                var soLuongOK = SqlHelper.ExecuteNonQuery(conn, sql, CommandType.StoredProcedure, pars);

                if (soLuongOK > 0) return true;

                return false;
            }
            catch (Exception e)
            {
            }

            return false;
        }

        public static bool KiemTraDuocMuon(int maDocGia)
        {
            var sql = "dbo.KiemTraDuocMuon";
            var pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("@MaDocGia", maDocGia));

            var kq = SqlHelper.ExecuteScalar(GetConnString(), sql, CommandType.StoredProcedure, pars.ToArray()) as int?;
            return kq == null ? true : kq > 0 ? true : false;
        }

        public static bool KiemTraDocGia(int maDocGia)
        {
            var sql = "dbo.KiemTraDocGia";
            var pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("@MaDocGia", maDocGia));

            var kq = SqlHelper.ExecuteScalar(GetConnString(), sql, CommandType.StoredProcedure, pars.ToArray()) as int?;
            return kq != null && kq > 0 ? true : false;
        }

        public static int? LaySachMuonToiDa(int maDocGia)
        {
            var sql = "dbo.KiemTraDuocMuon";
            var pars = new List<SqlParameter>();
            pars.Add(new SqlParameter("@MaDocGia", maDocGia));

            var kq = SqlHelper.ExecuteScalar(GetConnString(), sql, CommandType.StoredProcedure, pars.ToArray()) as int?;
            return kq;
        }

        public static bool KT_SachMuon(int maDocGia, int maDauSach)
        {
            var sql = "KiemTraSachMuon";
            var cmd = new SqlCommand();
            cmd.Connection = _conn;
            _conn.Open();
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maDocGia", maDocGia).Direction = ParameterDirection.Input;

            cmd.Parameters.AddWithValue("@maDauSach", maDauSach).Direction = ParameterDirection.Input;
            cmd.Parameters.Add("@kq", SqlDbType.Int).Direction = ParameterDirection.Output;

            cmd.ExecuteNonQuery();
            var outval = (int) cmd.Parameters["@kq"].Value;
            _conn.Close();
            return outval == 1 ? true : false;
        }
    }
}