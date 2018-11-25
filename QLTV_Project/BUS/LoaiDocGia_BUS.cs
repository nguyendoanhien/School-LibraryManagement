using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using DTO;
using DAO;
namespace BUS
{
    public class LoaiDocGia_BUS
    {
        LoaiDocGia_DAO LoaiDocGia_dao = new LoaiDocGia_DAO();
        public DataTable getLoaiDocGia()
        {
            return LoaiDocGia_dao.getLoaiDocGia();
        }

        public DataTable LoadCboLoaiDG()
        {
            return LoaiDocGia_dao.LoadCbo();
        }
    }
}
