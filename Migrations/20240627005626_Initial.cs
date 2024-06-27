using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GroupProject.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChatLieus",
                columns: table => new
                {
                    MaChatLieu = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChatLieuSP = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatLieus", x => x.MaChatLieu);
                });

            migrationBuilder.CreateTable(
                name: "HangSXs",
                columns: table => new
                {
                    MaHangSX = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HangSXSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaNuocThuongHieu = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangSXs", x => x.MaHangSX);
                });

            migrationBuilder.CreateTable(
                name: "KichThuocs",
                columns: table => new
                {
                    MaKichThuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KichThuocSP = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KichThuocs", x => x.MaKichThuoc);
                });

            migrationBuilder.CreateTable(
                name: "LoaiDTs",
                columns: table => new
                {
                    MaDT = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiDTs", x => x.MaDT);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSPs",
                columns: table => new
                {
                    MaLoai = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Loai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSPs", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "MauSacs",
                columns: table => new
                {
                    MaMauSac = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMauSac = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSacs", x => x.MaMauSac);
                });

            migrationBuilder.CreateTable(
                name: "QuocGias",
                columns: table => new
                {
                    MaNuoc = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNuoc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuocGias", x => x.MaNuoc);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Username);
                });

            migrationBuilder.CreateTable(
                name: "DanhMucSPs",
                columns: table => new
                {
                    MaSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaChatLieu = table.Column<int>(type: "int", nullable: false),
                    NganLapTop = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CanNang = table.Column<double>(type: "float", nullable: false),
                    DoNoi = table.Column<bool>(type: "bit", nullable: false),
                    MaHangSX = table.Column<int>(type: "int", nullable: false),
                    MaNuocSX = table.Column<int>(type: "int", nullable: false),
                    MaDacTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGianBaoHanh = table.Column<int>(type: "int", nullable: false),
                    GioiThieuSP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChietKhau = table.Column<double>(type: "float", nullable: false),
                    MaLoai = table.Column<int>(type: "int", nullable: false),
                    MaDT = table.Column<int>(type: "int", nullable: false),
                    AnhDaiDien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GiaNhoNhat = table.Column<double>(type: "float", nullable: false),
                    GiaLonNhat = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DanhMucSPs", x => x.MaSP);
                    table.ForeignKey(
                        name: "FK_DanhMucSPs_ChatLieus_MaChatLieu",
                        column: x => x.MaChatLieu,
                        principalTable: "ChatLieus",
                        principalColumn: "MaChatLieu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhMucSPs_HangSXs_MaHangSX",
                        column: x => x.MaHangSX,
                        principalTable: "HangSXs",
                        principalColumn: "MaHangSX",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhMucSPs_LoaiDTs_MaDT",
                        column: x => x.MaDT,
                        principalTable: "LoaiDTs",
                        principalColumn: "MaDT",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhMucSPs_LoaiSPs_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "LoaiSPs",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DanhMucSPs_QuocGias_MaNuocSX",
                        column: x => x.MaNuocSX,
                        principalTable: "QuocGias",
                        principalColumn: "MaNuoc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    MaKhachHang = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cusname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LoaiKhachHang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnhDaiDien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.MaKhachHang);
                    table.ForeignKey(
                        name: "FK_KhachHangs_Users_Username",
                        column: x => x.Username,
                        principalTable: "Users",
                        principalColumn: "Username");
                });

            migrationBuilder.CreateTable(
                name: "NhanViens",
                columns: table => new
                {
                    MaNhanVien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViTri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnhDaiDien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanViens", x => x.MaNhanVien);
                    table.ForeignKey(
                        name: "FK_NhanViens_Users_Username",
                        column: x => x.Username,
                        principalTable: "Users",
                        principalColumn: "Username");
                });

            migrationBuilder.CreateTable(
                name: "AnhSPs",
                columns: table => new
                {
                    MaAnhSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSP = table.Column<int>(type: "int", nullable: false),
                    TenFileAnh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViTri = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnhSPs", x => x.MaAnhSP);
                    table.ForeignKey(
                        name: "FK_AnhSPs_DanhMucSPs_MaSP",
                        column: x => x.MaSP,
                        principalTable: "DanhMucSPs",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSanPhams",
                columns: table => new
                {
                    MaChiTietSP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaSP = table.Column<int>(type: "int", nullable: false),
                    MaKichThuoc = table.Column<int>(type: "int", nullable: false),
                    MaMauSac = table.Column<int>(type: "int", nullable: false),
                    AnhDaiDien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonGiaBan = table.Column<double>(type: "float", nullable: false),
                    GiamGia = table.Column<double>(type: "float", nullable: false),
                    SLTon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSanPhams", x => x.MaChiTietSP);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPhams_DanhMucSPs_MaSP",
                        column: x => x.MaSP,
                        principalTable: "DanhMucSPs",
                        principalColumn: "MaSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPhams_KichThuocs_MaKichThuoc",
                        column: x => x.MaKichThuoc,
                        principalTable: "KichThuocs",
                        principalColumn: "MaKichThuoc",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSanPhams_MauSacs_MaMauSac",
                        column: x => x.MaMauSac,
                        principalTable: "MauSacs",
                        principalColumn: "MaMauSac",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonBans",
                columns: table => new
                {
                    MaHoaDon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NgayHoaDon = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaKhachHang = table.Column<int>(type: "int", nullable: false),
                    MaNhanVien = table.Column<int>(type: "int", nullable: false),
                    TongTienHD = table.Column<double>(type: "float", nullable: false),
                    GiamGiaHD = table.Column<double>(type: "float", nullable: false),
                    PhuongThucThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaSoThue = table.Column<int>(type: "int", nullable: false),
                    ThongTinThue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonBans", x => x.MaHoaDon);
                    table.ForeignKey(
                        name: "FK_HoaDonBans_KhachHangs_MaKhachHang",
                        column: x => x.MaKhachHang,
                        principalTable: "KhachHangs",
                        principalColumn: "MaKhachHang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonBans_NhanViens_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanViens",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHDBs",
                columns: table => new
                {
                    MaChiTietHDB = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaHoaDon = table.Column<int>(type: "int", nullable: false),
                    MaChiTietSP = table.Column<int>(type: "int", nullable: false),
                    SoLuongBan = table.Column<int>(type: "int", nullable: false),
                    DonGiaBan = table.Column<double>(type: "float", nullable: false),
                    GiamGia = table.Column<double>(type: "float", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHDBs", x => x.MaChiTietHDB);
                    table.ForeignKey(
                        name: "FK_ChiTietHDBs_ChiTietSanPhams_MaChiTietSP",
                        column: x => x.MaChiTietSP,
                        principalTable: "ChiTietSanPhams",
                        principalColumn: "MaChiTietSP",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHDBs_HoaDonBans_MaHoaDon",
                        column: x => x.MaHoaDon,
                        principalTable: "HoaDonBans",
                        principalColumn: "MaHoaDon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnhSPs_MaSP",
                table: "AnhSPs",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHDBs_MaChiTietSP",
                table: "ChiTietHDBs",
                column: "MaChiTietSP");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHDBs_MaHoaDon",
                table: "ChiTietHDBs",
                column: "MaHoaDon");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPhams_MaKichThuoc",
                table: "ChiTietSanPhams",
                column: "MaKichThuoc");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPhams_MaMauSac",
                table: "ChiTietSanPhams",
                column: "MaMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSanPhams_MaSP",
                table: "ChiTietSanPhams",
                column: "MaSP");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMucSPs_MaChatLieu",
                table: "DanhMucSPs",
                column: "MaChatLieu");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMucSPs_MaDT",
                table: "DanhMucSPs",
                column: "MaDT");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMucSPs_MaHangSX",
                table: "DanhMucSPs",
                column: "MaHangSX");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMucSPs_MaLoai",
                table: "DanhMucSPs",
                column: "MaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_DanhMucSPs_MaNuocSX",
                table: "DanhMucSPs",
                column: "MaNuocSX");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonBans_MaKhachHang",
                table: "HoaDonBans",
                column: "MaKhachHang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonBans_MaNhanVien",
                table: "HoaDonBans",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHangs_Username",
                table: "KhachHangs",
                column: "Username");

            migrationBuilder.CreateIndex(
                name: "IX_NhanViens_Username",
                table: "NhanViens",
                column: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnhSPs");

            migrationBuilder.DropTable(
                name: "ChiTietHDBs");

            migrationBuilder.DropTable(
                name: "ChiTietSanPhams");

            migrationBuilder.DropTable(
                name: "HoaDonBans");

            migrationBuilder.DropTable(
                name: "DanhMucSPs");

            migrationBuilder.DropTable(
                name: "KichThuocs");

            migrationBuilder.DropTable(
                name: "MauSacs");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "NhanViens");

            migrationBuilder.DropTable(
                name: "ChatLieus");

            migrationBuilder.DropTable(
                name: "HangSXs");

            migrationBuilder.DropTable(
                name: "LoaiDTs");

            migrationBuilder.DropTable(
                name: "LoaiSPs");

            migrationBuilder.DropTable(
                name: "QuocGias");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
