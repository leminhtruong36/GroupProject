namespace GroupProject.Models
{
    public class EFRepository : IRepository
    {
        private GroupProjectDBContext context;
        public EFRepository(GroupProjectDBContext ctx)
        {
            context = ctx;
        }
        public IQueryable<TChatLieu> ChatLieus => context.TChatLieus;
        public IQueryable<TLoaiSp> LoaiSPs => context.TLoaiSps;
        public IQueryable<TLoaiDt> LoaiDTs => context.TLoaiDts;
        public IQueryable<TAnhSp> AnhSPs => context.TAnhSps;
        public IQueryable<THangSx> HangSXs => context.THangSxes;
        public IQueryable<TQuocGium> QuocGias => context.TQuocGia;
        public IQueryable<TDanhMucSp> DanhMucSPs => context.TDanhMucSps;
        public IQueryable<TChiTietSanPham> ChiTietSanPhams => context.TChiTietSanPhams;
        public IQueryable<TMauSac> MauSacs => context.TMauSacs;
        public IQueryable<TKichThuoc> KichThuocs => context.TKichThuocs;
        public IQueryable<TChiTietHdb> ChiTietHDBs => context.TChiTietHdbs;
        public IQueryable<THoaDonBan> HoaDonBans => context.THoaDonBans;
        public IQueryable<TKhachHang> KhachHangs => context.TKhachHangs;
        public IQueryable<TNhanVien> NhanViens => context.TNhanViens;
        public IQueryable<TUser> Users => context.TUsers;

    }
}
