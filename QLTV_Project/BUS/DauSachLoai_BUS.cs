#region
using System.Data;
using DAO;
#endregion

namespace BUS
{
    public class DauSachLoai_BUS
    {
        public DataSet LoadComBoBoxDauSachLoai(string tenbang)
        {
            return DauSach_DAO.LoadComBoDauSach(tenbang);
        }
    }
}