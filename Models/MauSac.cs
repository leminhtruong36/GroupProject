using System.ComponentModel.DataAnnotations;

namespace GroupProject.Models
{
    public class MauSac
    {
        [Key]
        public int MaMauSac { get; set; }
        public string TenMauSac { get; set; }

        public ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
