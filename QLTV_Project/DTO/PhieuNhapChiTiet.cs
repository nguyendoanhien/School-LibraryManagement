#region
using System;
#endregion

namespace DTO
{
    internal class PhieuNhapChiTiet
    {
        public int MaDauSach { get; set; }
        public int MaPhieuNhap { get; set; }
        public int? MaNCC { get; set; }
        public int? MaNhanVienNhap { get; set; }
        public int? SoLuong { get; set; }
        public int? DonGia { get; set; }
        public DateTime? NgayDuKienGiao { get; set; }
    }
}