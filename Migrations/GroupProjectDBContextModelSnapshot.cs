﻿// <auto-generated />
using System;
using GroupProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GroupProject.Migrations
{
    [DbContext(typeof(GroupProjectDBContext))]
    partial class GroupProjectDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GroupProject.Models.TAnhChiTietSp", b =>
                {
                    b.Property<string>("MaChiTietSp")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .HasColumnName("MaChiTietSP")
                        .IsFixedLength();

                    b.Property<string>("TenFileAnh")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("char(100)")
                        .IsFixedLength();

                    b.Property<short?>("ViTri")
                        .HasColumnType("smallint");

                    b.HasKey("MaChiTietSp", "TenFileAnh");

                    b.ToTable("tAnhChiTietSP", (string)null);
                });

            modelBuilder.Entity("GroupProject.Models.TAnhSp", b =>
                {
                    b.Property<string>("MaSp")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .HasColumnName("MaSP")
                        .IsFixedLength();

                    b.Property<string>("TenFileAnh")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("char(100)")
                        .IsFixedLength();

                    b.Property<short?>("ViTri")
                        .HasColumnType("smallint");

                    b.HasKey("MaSp", "TenFileAnh");

                    b.ToTable("tAnhSP", (string)null);
                });

            modelBuilder.Entity("GroupProject.Models.TChatLieu", b =>
                {
                    b.Property<string>("MaChatLieu")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<string>("ChatLieu")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("MaChatLieu");

                    b.ToTable("tChatLieu", (string)null);
                });

            modelBuilder.Entity("GroupProject.Models.TChiTietHdb", b =>
                {
                    b.Property<string>("MaHoaDon")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<string>("MaChiTietSp")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .HasColumnName("MaChiTietSP")
                        .IsFixedLength();

                    b.Property<decimal?>("DonGiaBan")
                        .HasColumnType("money");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double?>("GiamGia")
                        .HasColumnType("float");

                    b.Property<int?>("SoLuongBan")
                        .HasColumnType("int");

                    b.HasKey("MaHoaDon", "MaChiTietSp");

                    b.HasIndex("MaChiTietSp");

                    b.ToTable("tChiTietHDB", (string)null);
                });

            modelBuilder.Entity("GroupProject.Models.TChiTietSanPham", b =>
                {
                    b.Property<string>("MaChiTietSp")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .HasColumnName("MaChiTietSP")
                        .IsFixedLength();

                    b.Property<string>("AnhDaiDien")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("char(100)")
                        .IsFixedLength();

                    b.Property<double?>("DonGiaBan")
                        .HasColumnType("float");

                    b.Property<double?>("GiamGia")
                        .HasColumnType("float");

                    b.Property<string>("MaKichThuoc")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<string>("MaMauSac")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<string>("MaSp")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .HasColumnName("MaSP")
                        .IsFixedLength();

                    b.Property<int?>("Slton")
                        .HasColumnType("int")
                        .HasColumnName("SLTon");

                    b.Property<string>("Video")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("char(100)")
                        .IsFixedLength();

                    b.HasKey("MaChiTietSp");

                    b.HasIndex("MaKichThuoc");

                    b.HasIndex("MaMauSac");

                    b.HasIndex("MaSp");

                    b.ToTable("tChiTietSanPham", (string)null);
                });

            modelBuilder.Entity("GroupProject.Models.TDanhMucSp", b =>
                {
                    b.Property<string>("MaSp")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .HasColumnName("MaSP")
                        .IsFixedLength();

                    b.Property<string>("AnhDaiDien")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("char(100)")
                        .IsFixedLength();

                    b.Property<double?>("CanNang")
                        .HasColumnType("float");

                    b.Property<double?>("ChietKhau")
                        .HasColumnType("float");

                    b.Property<double?>("DoNoi")
                        .HasColumnType("float");

                    b.Property<decimal?>("GiaLonNhat")
                        .HasColumnType("money");

                    b.Property<decimal?>("GiaNhoNhat")
                        .HasColumnType("money");

                    b.Property<string>("GioiThieuSp")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("GioiThieuSP");

                    b.Property<string>("MaChatLieu")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<string>("MaDacTinh")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<string>("MaDt")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .HasColumnName("MaDT")
                        .IsFixedLength();

                    b.Property<string>("MaHangSx")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .HasColumnName("MaHangSX")
                        .IsFixedLength();

                    b.Property<string>("MaLoai")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<string>("MaNuocSx")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .HasColumnName("MaNuocSX")
                        .IsFixedLength();

                    b.Property<string>("Model")
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("NganLapTop")
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("TenSp")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("TenSP");

                    b.Property<double?>("ThoiGianBaoHanh")
                        .HasColumnType("float");

                    b.Property<string>("Website")
                        .HasMaxLength(155)
                        .IsUnicode(false)
                        .HasColumnType("char(155)")
                        .IsFixedLength();

                    b.HasKey("MaSp");

                    b.HasIndex("MaChatLieu");

                    b.HasIndex("MaDt");

                    b.HasIndex("MaHangSx");

                    b.HasIndex("MaLoai");

                    b.HasIndex("MaNuocSx");

                    b.ToTable("tDanhMucSP", (string)null);
                });

            modelBuilder.Entity("GroupProject.Models.THangSx", b =>
                {
                    b.Property<string>("MaHangSx")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .HasColumnName("MaHangSX")
                        .IsFixedLength();

                    b.Property<string>("HangSx")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("HangSX");

                    b.Property<string>("MaNuocThuongHieu")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.HasKey("MaHangSx");

                    b.ToTable("tHangSX", (string)null);
                });

            modelBuilder.Entity("GroupProject.Models.THoaDonBan", b =>
                {
                    b.Property<string>("MaHoaDon")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<string>("GhiChu")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<double?>("GiamGiaHd")
                        .HasColumnType("float")
                        .HasColumnName("GiamGiaHD");

                    b.Property<string>("MaKhachHang")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<string>("MaNhanVien")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<string>("MaSoThue")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("char(100)")
                        .IsFixedLength();

                    b.Property<DateTime?>("NgayHoaDon")
                        .HasColumnType("datetime");

                    b.Property<byte?>("PhuongThucThanhToan")
                        .HasColumnType("tinyint");

                    b.Property<string>("ThongTinThue")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<decimal?>("TongTienHd")
                        .HasColumnType("money")
                        .HasColumnName("TongTienHD");

                    b.HasKey("MaHoaDon");

                    b.HasIndex("MaKhachHang");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("tHoaDonBan", (string)null);
                });

            modelBuilder.Entity("GroupProject.Models.TKhachHang", b =>
                {
                    b.Property<string>("MaKhanhHang")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<string>("AnhDaiDien")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("char(100)")
                        .IsFixedLength();

                    b.Property<string>("DiaChi")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<byte?>("LoaiKhachHang")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<string>("SoDienThoai")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("char(15)")
                        .IsFixedLength();

                    b.Property<string>("TenKhachHang")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("char(100)")
                        .HasColumnName("username")
                        .IsFixedLength();

                    b.HasKey("MaKhanhHang");

                    b.HasIndex("Username");

                    b.ToTable("tKhachHang", (string)null);
                });

            modelBuilder.Entity("GroupProject.Models.TKichThuoc", b =>
                {
                    b.Property<string>("MaKichThuoc")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<string>("KichThuoc")
                        .HasMaxLength(150)
                        .HasColumnType("nchar(150)")
                        .IsFixedLength();

                    b.HasKey("MaKichThuoc");

                    b.ToTable("tKichThuoc", (string)null);
                });

            modelBuilder.Entity("GroupProject.Models.TLoaiDt", b =>
                {
                    b.Property<string>("MaDt")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .HasColumnName("MaDT")
                        .IsFixedLength();

                    b.Property<string>("TenLoai")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaDt");

                    b.ToTable("tLoaiDT", (string)null);
                });

            modelBuilder.Entity("GroupProject.Models.TLoaiSp", b =>
                {
                    b.Property<string>("MaLoai")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<string>("Loai")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaLoai");

                    b.ToTable("tLoaiSP", (string)null);
                });

            modelBuilder.Entity("GroupProject.Models.TMauSac", b =>
                {
                    b.Property<string>("MaMauSac")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<string>("TenMauSac")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaMauSac");

                    b.ToTable("tMauSac", (string)null);
                });

            modelBuilder.Entity("GroupProject.Models.TNhanVien", b =>
                {
                    b.Property<string>("MaNhanVien")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<string>("AnhDaiDien")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("char(100)")
                        .IsFixedLength();

                    b.Property<string>("ChucVu")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DiaChi")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("GhiChu")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("date");

                    b.Property<string>("SoDienThoai1")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("char(15)")
                        .IsFixedLength();

                    b.Property<string>("SoDienThoai2")
                        .HasMaxLength(15)
                        .IsUnicode(false)
                        .HasColumnType("char(15)")
                        .IsFixedLength();

                    b.Property<string>("TenNhanVien")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("char(100)")
                        .HasColumnName("username")
                        .IsFixedLength();

                    b.HasKey("MaNhanVien");

                    b.HasIndex("Username");

                    b.ToTable("tNhanVien", (string)null);
                });

            modelBuilder.Entity("GroupProject.Models.TQuocGium", b =>
                {
                    b.Property<string>("MaNuoc")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("char(25)")
                        .IsFixedLength();

                    b.Property<string>("TenNuoc")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaNuoc");

                    b.ToTable("tQuocGia", (string)null);
                });

            modelBuilder.Entity("GroupProject.Models.TUser", b =>
                {
                    b.Property<string>("Username")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("char(100)")
                        .HasColumnName("username")
                        .IsFixedLength();

                    b.Property<byte?>("LoaiUser")
                        .HasColumnType("tinyint");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("char(256)")
                        .HasColumnName("password")
                        .IsFixedLength();

                    b.HasKey("Username");

                    b.ToTable("tUser", (string)null);
                });

            modelBuilder.Entity("GroupProject.Models.TAnhChiTietSp", b =>
                {
                    b.HasOne("GroupProject.Models.TChiTietSanPham", "MaChiTietSpNavigation")
                        .WithMany("TAnhChiTietSps")
                        .HasForeignKey("MaChiTietSp")
                        .IsRequired()
                        .HasConstraintName("FK_tAnhChiTietSP_tChiTietSanPham");

                    b.Navigation("MaChiTietSpNavigation");
                });

            modelBuilder.Entity("GroupProject.Models.TAnhSp", b =>
                {
                    b.HasOne("GroupProject.Models.TDanhMucSp", "MaSpNavigation")
                        .WithMany("TAnhSps")
                        .HasForeignKey("MaSp")
                        .IsRequired()
                        .HasConstraintName("FK_tAnhSP_tDanhMucSP");

                    b.Navigation("MaSpNavigation");
                });

            modelBuilder.Entity("GroupProject.Models.TChiTietHdb", b =>
                {
                    b.HasOne("GroupProject.Models.TChiTietSanPham", "MaChiTietSpNavigation")
                        .WithMany("TChiTietHdbs")
                        .HasForeignKey("MaChiTietSp")
                        .IsRequired()
                        .HasConstraintName("FK_tChiTietHDB_tChiTietSanPham");

                    b.HasOne("GroupProject.Models.THoaDonBan", "MaHoaDonNavigation")
                        .WithMany("TChiTietHdbs")
                        .HasForeignKey("MaHoaDon")
                        .IsRequired()
                        .HasConstraintName("FK_tChiTietHDB_tHoaDonBan");

                    b.Navigation("MaChiTietSpNavigation");

                    b.Navigation("MaHoaDonNavigation");
                });

            modelBuilder.Entity("GroupProject.Models.TChiTietSanPham", b =>
                {
                    b.HasOne("GroupProject.Models.TKichThuoc", "MaKichThuocNavigation")
                        .WithMany("TChiTietSanPhams")
                        .HasForeignKey("MaKichThuoc")
                        .HasConstraintName("FK_tChiTietSanPham_tKichThuoc");

                    b.HasOne("GroupProject.Models.TMauSac", "MaMauSacNavigation")
                        .WithMany("TChiTietSanPhams")
                        .HasForeignKey("MaMauSac")
                        .HasConstraintName("FK_tChiTietSanPham_tMauSac");

                    b.HasOne("GroupProject.Models.TDanhMucSp", "MaSpNavigation")
                        .WithMany("TChiTietSanPhams")
                        .HasForeignKey("MaSp")
                        .HasConstraintName("FK_tChiTietSanPham_tDanhMucSP");

                    b.Navigation("MaKichThuocNavigation");

                    b.Navigation("MaMauSacNavigation");

                    b.Navigation("MaSpNavigation");
                });

            modelBuilder.Entity("GroupProject.Models.TDanhMucSp", b =>
                {
                    b.HasOne("GroupProject.Models.TChatLieu", "MaChatLieuNavigation")
                        .WithMany("TDanhMucSps")
                        .HasForeignKey("MaChatLieu")
                        .HasConstraintName("FK_tDanhMucSP_tChatLieu");

                    b.HasOne("GroupProject.Models.TLoaiDt", "MaDtNavigation")
                        .WithMany("TDanhMucSps")
                        .HasForeignKey("MaDt")
                        .HasConstraintName("FK_tDanhMucSP_tLoaiDT");

                    b.HasOne("GroupProject.Models.THangSx", "MaHangSxNavigation")
                        .WithMany("TDanhMucSps")
                        .HasForeignKey("MaHangSx")
                        .HasConstraintName("FK_tDanhMucSP_tHangSX");

                    b.HasOne("GroupProject.Models.TLoaiSp", "MaLoaiNavigation")
                        .WithMany("TDanhMucSps")
                        .HasForeignKey("MaLoai")
                        .HasConstraintName("FK_tDanhMucSP_tLoaiSP");

                    b.HasOne("GroupProject.Models.TQuocGium", "MaNuocSxNavigation")
                        .WithMany("TDanhMucSps")
                        .HasForeignKey("MaNuocSx")
                        .HasConstraintName("FK_tDanhMucSP_tQuocGia");

                    b.Navigation("MaChatLieuNavigation");

                    b.Navigation("MaDtNavigation");

                    b.Navigation("MaHangSxNavigation");

                    b.Navigation("MaLoaiNavigation");

                    b.Navigation("MaNuocSxNavigation");
                });

            modelBuilder.Entity("GroupProject.Models.THoaDonBan", b =>
                {
                    b.HasOne("GroupProject.Models.TKhachHang", "MaKhachHangNavigation")
                        .WithMany("THoaDonBans")
                        .HasForeignKey("MaKhachHang")
                        .HasConstraintName("FK_tHoaDonBan_tKhachHang");

                    b.HasOne("GroupProject.Models.TNhanVien", "MaNhanVienNavigation")
                        .WithMany("THoaDonBans")
                        .HasForeignKey("MaNhanVien")
                        .HasConstraintName("FK_tHoaDonBan_tNhanVien");

                    b.Navigation("MaKhachHangNavigation");

                    b.Navigation("MaNhanVienNavigation");
                });

            modelBuilder.Entity("GroupProject.Models.TKhachHang", b =>
                {
                    b.HasOne("GroupProject.Models.TUser", "UsernameNavigation")
                        .WithMany("TKhachHangs")
                        .HasForeignKey("Username")
                        .HasConstraintName("FK_tKhachHang_tUser");

                    b.Navigation("UsernameNavigation");
                });

            modelBuilder.Entity("GroupProject.Models.TNhanVien", b =>
                {
                    b.HasOne("GroupProject.Models.TUser", "UsernameNavigation")
                        .WithMany("TNhanViens")
                        .HasForeignKey("Username")
                        .HasConstraintName("FK_tNhanVien_tUser");

                    b.Navigation("UsernameNavigation");
                });

            modelBuilder.Entity("GroupProject.Models.TChatLieu", b =>
                {
                    b.Navigation("TDanhMucSps");
                });

            modelBuilder.Entity("GroupProject.Models.TChiTietSanPham", b =>
                {
                    b.Navigation("TAnhChiTietSps");

                    b.Navigation("TChiTietHdbs");
                });

            modelBuilder.Entity("GroupProject.Models.TDanhMucSp", b =>
                {
                    b.Navigation("TAnhSps");

                    b.Navigation("TChiTietSanPhams");
                });

            modelBuilder.Entity("GroupProject.Models.THangSx", b =>
                {
                    b.Navigation("TDanhMucSps");
                });

            modelBuilder.Entity("GroupProject.Models.THoaDonBan", b =>
                {
                    b.Navigation("TChiTietHdbs");
                });

            modelBuilder.Entity("GroupProject.Models.TKhachHang", b =>
                {
                    b.Navigation("THoaDonBans");
                });

            modelBuilder.Entity("GroupProject.Models.TKichThuoc", b =>
                {
                    b.Navigation("TChiTietSanPhams");
                });

            modelBuilder.Entity("GroupProject.Models.TLoaiDt", b =>
                {
                    b.Navigation("TDanhMucSps");
                });

            modelBuilder.Entity("GroupProject.Models.TLoaiSp", b =>
                {
                    b.Navigation("TDanhMucSps");
                });

            modelBuilder.Entity("GroupProject.Models.TMauSac", b =>
                {
                    b.Navigation("TChiTietSanPhams");
                });

            modelBuilder.Entity("GroupProject.Models.TNhanVien", b =>
                {
                    b.Navigation("THoaDonBans");
                });

            modelBuilder.Entity("GroupProject.Models.TQuocGium", b =>
                {
                    b.Navigation("TDanhMucSps");
                });

            modelBuilder.Entity("GroupProject.Models.TUser", b =>
                {
                    b.Navigation("TKhachHangs");

                    b.Navigation("TNhanViens");
                });
#pragma warning restore 612, 618
        }
    }
}
