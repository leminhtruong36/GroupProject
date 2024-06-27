using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupProject.Models
{
    public class DanhMucSP
    {
        [Key]
        public int MaSP { get; set; }
        public string TenSP { get; set; }
        public int MaChatLieu { get; set; }
        public string NganLapTop { get; set; }
        public string Model { get; set; }
        public double CanNang { get; set; }
        public bool DoNoi { get; set; }
        public int MaHangSX { get; set; }
        public int MaNuocSX { get; set; }
        public string MaDacTinh { get; set; }
        public string Website { get; set; }
        public int ThoiGianBaoHanh { get; set; }
        public string GioiThieuSP { get; set; }
        public double ChietKhau { get; set; }
        public int MaLoai { get; set; }
        public int MaDT { get; set; }
        public string AnhDaiDien { get; set; }
        public double GiaNhoNhat { get; set; }
        public double GiaLonNhat { get; set; }

        [ForeignKey("MaChatLieu")]
        public ChatLieu ChatLieu { get; set; }
        [ForeignKey("MaLoai")]
        public LoaiSP LoaiSP { get; set; }
        [ForeignKey("MaDT")]
        public LoaiDT LoaiDT { get; set; }
        [ForeignKey("MaHangSX")]
        public HangSX HangSX { get; set; }
        [ForeignKey("MaNuocSX")]
        public QuocGia QuocGia { get; set; }
        public ICollection<AnhSP> AnhSPs { get; set; }
        public ICollection<ChiTietSanPham> ChiTietSanPhams { get; set; }
    }
}
