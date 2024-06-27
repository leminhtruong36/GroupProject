using System.ComponentModel.DataAnnotations;

namespace GroupProject.Models
{
    public class NhanVien
    {
        [Key]
        public int MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string ViTri { get; set; }
        public string AnhDaiDien { get; set; }
        public string GhiChu { get; set; }

        public ICollection<HoaDonBan> HoaDonBans { get; set; }
    }
}
