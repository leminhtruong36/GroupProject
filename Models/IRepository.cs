using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupProject.Models
{
    public interface IRepository
    {

        IQueryable<TChatLieu> ChatLieus { get; }
        IQueryable<TLoaiSp> LoaiSPs { get; }
        IQueryable<TLoaiDt> LoaiDTs { get; }
        IQueryable<TAnhSp> AnhSPs { get; }
        IQueryable<THangSx> HangSXs { get; }
        IQueryable<TQuocGium> QuocGias { get; }
        IQueryable<TDanhMucSp> DanhMucSPs { get; }
        IQueryable<TChiTietSanPham> ChiTietSanPhams { get; }
        IQueryable<TMauSac> MauSacs { get; }
        IQueryable<TKichThuoc> KichThuocs { get; }
        IQueryable<TChiTietHdb> ChiTietHDBs { get; }
        IQueryable<THoaDonBan> HoaDonBans { get; }
        IQueryable<TKhachHang> KhachHangs { get; }
        IQueryable<TNhanVien> NhanViens { get; }
        IQueryable<TUser> Users { get; }
        
        



    }
}
