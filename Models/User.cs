using System.ComponentModel.DataAnnotations;

namespace GroupProject.Models
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public string LoaiUser { get; set; }

        public ICollection<KhachHang> KhachHang { get; set; }
        public ICollection<NhanVien> NhanVien { get; set; }
    }
}
