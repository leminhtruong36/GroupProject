using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupProject.Models
{
    public class HoaDonBan
    {
        [Key]
        public int MaHoaDon { get; set; }
        public DateTime NgayHoaDon { get; set; }
        public int MaKhachHang { get; set; }
        public int MaNhanVien { get; set; }
        public double TongTienHD { get; set; }
        public double GiamGiaHD { get; set; }
        public string PhuongThucThanhToan { get; set; }
        public int MaSoThue { get; set; }
        public string ThongTinThue { get; set; }
        public string GhiChu { get; set; }

        [ForeignKey("MaKhachHang")]
        public KhachHang KhachHang { get; set; }
        [ForeignKey("MaNhanVien")]
        public NhanVien NhanVien { get; set; }
        public ICollection<ChiTietHDB> ChiTietHDBs { get; set; }
    }
}
