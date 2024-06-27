namespace GroupProject.Models
{
    public class EFRepository : IRepository
    {
        private DataContext context;
        public EFRepository(DataContext ctx)
        {
            context = ctx;
        }
        public IQueryable<ChatLieu> ChatLieus => context.ChatLieus;
        public IQueryable<LoaiSP> LoaiSPs => context.LoaiSPs;
        public IQueryable<LoaiDT> LoaiDTs => context.LoaiDTs;
        public IQueryable<AnhSP> AnhSPs => context.AnhSPs;
        public IQueryable<HangSX> HangSXs => context.HangSXs;
        public IQueryable<QuocGia> QuocGias => context.QuocGias;
        public IQueryable<DanhMucSP> DanhMucSPs => context.DanhMucSPs;
        public IQueryable<ChiTietSanPham> ChiTietSanPhams => context.ChiTietSanPhams;
        public IQueryable<MauSac> MauSacs => context.MauSacs;
        public IQueryable<KichThuoc> KichThuocs => context.KichThuocs;
        public IQueryable<ChiTietHDB> ChiTietHDBs => context.ChiTietHDBs;
        public IQueryable<HoaDonBan> HoaDonBans => context.HoaDonBans;
        public IQueryable<KhachHang> KhachHangs => context.KhachHangs;
        public IQueryable<NhanVien> NhanViens => context.NhanViens;
        public IQueryable<User> Users => context.Users;

    }
}
