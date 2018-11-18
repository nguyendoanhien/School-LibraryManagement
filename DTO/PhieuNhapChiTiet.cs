using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class PhieuNhapChiTiet
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
