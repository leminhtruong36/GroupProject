using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GroupProject.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options)
        : base(options) { }
        public DbSet<ChatLieu> ChatLieus { get; set; }
        public DbSet<LoaiSP> LoaiSPs { get; set; }
        public DbSet<LoaiDT> LoaiDTs { get; set; }
        public DbSet<AnhSP> AnhSPs { get; set; }
        public DbSet<HangSX> HangSXs { get; set; }
        public DbSet<QuocGia> QuocGias { get; set; }
        public DbSet<DanhMucSP> DanhMucSPs { get; set; }
        public DbSet<ChiTietSanPham> ChiTietSanPhams { get; set; }
        public DbSet<MauSac> MauSacs { get; set; }
        public DbSet<KichThuoc> KichThuocs { get; set; }
        public DbSet<ChiTietHDB> ChiTietHDBs { get; set; }
        public DbSet<HoaDonBan> HoaDonBans { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=GroupProjectDB;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }
    }
}