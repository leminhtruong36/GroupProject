using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupProject.Models
{
    public interface IRepository
    {

        IQueryable<ChatLieu> ChatLieus { get; }
        IQueryable<LoaiSP> LoaiSPs { get; }
        IQueryable<LoaiDT> LoaiDTs { get; }
        IQueryable<AnhSP> AnhSPs { get; }
        IQueryable<HangSX> HangSXs { get; }
        IQueryable<QuocGia> QuocGias { get; }
        IQueryable<DanhMucSP> DanhMucSPs { get; }
        IQueryable<ChiTietSanPham> ChiTietSanPhams { get; }
        IQueryable<MauSac> MauSacs { get; }
        IQueryable<KichThuoc> KichThuocs { get; }
        IQueryable<ChiTietHDB> ChiTietHDBs { get; }
        IQueryable<HoaDonBan> HoaDonBans { get; }
        IQueryable<KhachHang> KhachHangs { get; }
        IQueryable<NhanVien> NhanViens { get; }
        IQueryable<User> Users { get; }
        
        



    }
}
