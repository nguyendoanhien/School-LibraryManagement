namespace DTO
{
    public class DocGia
    {
        public DocGia(int ma, int maLoai)
        {
            Ma = ma;
            MaLoai = maLoai;
        }

        public int Ma { get; set; }
        public int MaLoai { get; set; }
    }
}