using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    
    public class NguoiDung
    {
        public int MaNguoiDung { get; set; }

        public string HoVaTen { get; set; }

        public bool? GioiTinh { get; set; }

        public string Email { get; set; }

        public DateTime? NgayTao { get; set; }

        
        public NguoiDung(int maNguoiDung, string hoVaTen, bool? gioiTinh, string email, DateTime? ngayTao)
        {
            MaNguoiDung = maNguoiDung;
            HoVaTen = hoVaTen;
            GioiTinh = gioiTinh;
            Email = email;
            NgayTao = ngayTao;
        }
    }

    
}
