#region
using System;
using System.Data;
using System.Data.SqlClient;
#endregion

namespace DAO
{
    public class PhieuTra_DAO : ConnectDatabase
    {
        public int MaPhieuTra()
        {
            try
            {
                var conn = GetConnString();
                var sql = "select MAX(MaPhieu) from Phieu";
                SqlParameter[] pars = { };
                var soLuongOK = SqlHelper.ExecuteScalar(conn, sql, CommandType.Text, pars);

                var gt = int.Parse(soLuongOK.ToString());

                if (soLuongOK != null) return gt + 1;
                return 0;
            }
            catch (Exception e)
            {
            }

            return 0;
        }

        public bool LuuPhieuTra()
        {
            var s = true;
            return s;
        }

        public int KiemTraRong(string a)
        {
            var gt = 0;

            var conn = GetConnString();

            _conn.Open();
            var sql =
                "SELECT count(PM.MaPhieuMuon) From PhieuMuon as PM, DauSach as DS, PhieuMuonChiTiet as PC WHERE KiemTra=0 and PM.MaDocGia = '" +
                a + "' AND PM.MaPhieuMuon = PC.MaPhieuMuon AND PC.MaDauSach = DS.MaDauSach";
            SqlParameter[] pars = { };
            var gia = SqlHelper.ExecuteScalar(conn, sql, CommandType.Text, pars);

            _conn.Close();

            gt = Convert.ToInt32(gia);

            return gt;
        }

        public DataTable LoadDanhsachMuon(string a, string MaPhieuMuon)
        {
            SqlCommand cmd;
            _conn.Open();
            cmd = _conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = @"

            SELECT PM.MaPhieuMuon,ds.MaDauSach,s.STT,ds.TenDauSach,pc.NgayHenTra
            FROM PhieuMuonChiTiet PC,
                 PhieuMuon PM,
                 DauSach DS,
                 Sach S
            WHERE pc.MaPhieuMuon=pm.MaPhieuMuon
              AND PM.MaDocGia='" + a + @"'
              AND PM.MaPhieuMuon='" + MaPhieuMuon + @"'
              AND DS.MaDauSach=S.MaDauSach
              AND S.STT=PC.MaSach
              AND s.MaDauSach=pc.MaDauSach


";
            cmd.ExecuteNonQuery();
            var dt = new DataTable();
            var da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            _conn.Close();
            return dt;
        }

        public double TienPhat(string MaDauSach, int ngay)
        {
            try
            {
                var conn = GetConnString();
                var sql = "select GiaTien from DauSach where MaDauSach = '" + MaDauSach + "'";
                SqlParameter[] pars = { };
                var gia = SqlHelper.ExecuteScalar(conn, sql, CommandType.Text, pars);

                var gt = Convert.ToDouble(gia);

                return gt * 0.01 * ngay;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //COMBO 3 BƯỚC BẤM NÚT LƯU
        //B0: Them Phieu
        public void ThemPhieu(string b, string c)
        {
            var conn = GetConnString();
            _conn.Open();
            var sql = "INSERT INTO Phieu VALUES ('" + b + "','" + c + "')";
            var sc = new SqlCommand(sql, _conn);

            sc.ExecuteNonQuery();
            _conn.Close();
        }

        //B1: Thêm Thông Tin Phiếu Trả
        public void ThemPhieuTra(string a, string MaPhieuMuon, string b)
        {
            var conn = GetConnString();
            _conn.Open();
            var sql = "INSERT INTO PhieuTra VALUES ('" + a + "','" + MaPhieuMuon + "','" + b + "')";
            var sc = new SqlCommand(sql, _conn);

            sc.ExecuteNonQuery();
            _conn.Close();
        }

        //B2: Thêm Thông Tin Phiếu Trả Chi Tiết
        public void ThemPhieuTraChiTiet(int a, string maSach, int b, int c, string d, int e)
        {
            var conn = GetConnString();
            _conn.Open();
            var sql = "INSERT INTO PhieuTraChiTiet VALUES (" + maSach + "," + a + "," + b + "," + c + ",'" + d + "'," +
                      e + ")";
            var sc = new SqlCommand(sql, _conn);
            //
            sc.ExecuteNonQuery();
            _conn.Close();
        }
        //B3: Hàm UPDATE Đã Mượn Thành Đã Trả trên Database

        public void UPDATE_PhieuMuonChiTiet(int a, string maSach, int b)
        {
            var conn = GetConnString();
            _conn.Open();

            var sql = "UPDATE PhieuMuonChiTiet SET KiemTra =1 WHERE MaDauSach = " + a + " and MaPhieuMuon = " + b +
                      " and MaSach = " + maSach + "";

            var sc = new SqlCommand(sql, _conn);

            sc.ExecuteNonQuery();
            _conn.Close();
        }
    }
}