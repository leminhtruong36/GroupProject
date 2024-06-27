using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupProject.Models
{
    public class ChiTietHDB
    {
        [Key]
        public int MaChiTietHDB { get; set; }
        public int MaHoaDon { get; set; }
        public int MaChiTietSP { get; set; }
        public int SoLuongBan { get; set; }
        public double DonGiaBan { get; set; }
        public double GiamGia { get; set; }
        public string GhiChu { get; set; }

        [ForeignKey("MaHoaDon")]
        public HoaDonBan HoaDonBan { get; set; }
        [ForeignKey("MaChiTietSP")]
        public ChiTietSanPham ChiTietSanPham { get; set; }
    }
}
