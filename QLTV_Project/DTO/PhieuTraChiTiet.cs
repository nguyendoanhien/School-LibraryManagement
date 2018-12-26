#region
using System;
#endregion

namespace DTO
{
    internal class PhieuTraChiTiet
    {
        public int MaSach { get; set; }
        public int MaDauSach { get; set; }
        public int MaPhieuTra { get; set; }
        public DateTime? NgayTra { get; set; }
        public int? MaQuyDinh { get; set; }
        public int? TienPhat { get; set; }
    }
}