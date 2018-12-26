#region
using System;
#endregion

namespace DTO
{
    internal class PhieuMuonChiTiet
    {
        public int MaSach { get; set; }
        public int MaPhieuMuon { get; set; }
        public int MaDauSach { get; set; }
        public DateTime? NgayHenTra { get; set; }
    }
}