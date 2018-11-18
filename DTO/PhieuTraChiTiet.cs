using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class PhieuTraChiTiet
    {
        public int MaSach { get; set; }

        public int MaDauSach { get; set; }

        public int MaPhieuTra { get; set; }

        public DateTime? NgayTra { get; set; }

        public int? MaQuyDinh { get; set; }

        public int? TienPhat { get; set; }
    }
}
