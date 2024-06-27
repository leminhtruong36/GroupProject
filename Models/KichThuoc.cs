using System.ComponentModel.DataAnnotations;

namespace GroupProject.Models
{
    public class KichThuoc
    {
        [Key]
        public int MaKichThuoc { get; set; }
        public string KichThuocSP { get; set; }

        public ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
