using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupProject.Models
{
    public class ChiTietSanPham
    {
        [Key]
        public int MaChiTietSP { get; set; }
        public int MaSP { get; set; }
        public int MaKichThuoc { get; set; }
        public int MaMauSac { get; set; }
        public string AnhDaiDien { get; set; }
        public string Video { get; set; }
        public double DonGiaBan { get; set; }
        public double GiamGia { get; set; }
        public int SLTon { get; set; }

        [ForeignKey("MaSP")]
        public DanhMucSP DanhMucSP { get; set; }
        [ForeignKey("MaKichThuoc")]
        public KichThuoc KichThuoc { get; set; }
        [ForeignKey("MaMauSac")]
        public MauSac MauSac { get; set; }
        public ICollection<ChiTietHDB> ChiTietHDBs { get; set; }
    }
}
