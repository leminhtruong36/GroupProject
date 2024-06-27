using System.ComponentModel.DataAnnotations;

namespace GroupProject.Models
{
    public class KhachHang
    {
        [Key]
        public int MaKhachHang { get; set; }
        public string Cusname { get; set; }
        public string TenKhachHang { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string LoaiKhachHang { get; set; }
        public string AnhDaiDien { get; set; }
        public string GhiChu { get; set; }

        public ICollection<HoaDonBan> HoaDonBans { get; set; }
    }
}
