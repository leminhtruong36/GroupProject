using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GroupProject.Models;
using Microsoft.EntityFrameworkCore;
using X.PagedList;
using GroupProject.ViewModels;
namespace GroupProject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    DataContext db = new DataContext();
    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index(int? page)
    {

        int pageSize = 8;
        int pageNumber = page == null || page < 0 ? 1 : page.Value;
        var lstsanpham = db.DanhMucSPs.AsNoTracking().OrderBy(x => x.TenSP);
        PagedList<DanhMucSP> lst = new PagedList<DanhMucSP>(lstsanpham, pageNumber, pageSize);
        return View(lstsanpham);
    }

    public IActionResult SanPhamTheoLoai(string maloai, int? page)
    {
        int pageSize = 8;
        int pageNumber = page == null || page < 0 ? 1 : page.Value;
        var lstsanpham = db.DanhMucSPs.AsNoTracking()
            .OrderBy(x => x.TenSP);
        PagedList<DanhMucSP> lst = new PagedList<DanhMucSP>(lstsanpham, pageNumber, pageSize);
        ViewBag.maloai = maloai;
        return View(lst);
    }
    public IActionResult ChiTietSanPham(int maSp)
    {
        var sanPham = db.DanhMucSPs.SingleOrDefault(x => x.MaSP == maSp);
        var anhSanPham= db.AnhSPs.Where(x=>x.MaSP == maSp).ToList();
        ViewBag.anhSanPham = anhSanPham;
        return View(sanPham);
    }
    public IActionResult ProductDetal(int maSp)
    {
        var sanPham = db.DanhMucSPs.SingleOrDefault(x => x.MaSP == maSp);
        var anhSanPham = db.AnhSPs.Where(x => x.MaSP == maSp).ToList();
        var homeProductDetailViewModel = new HomeProductDetailViewModels{
            danhMucSP = sanPham,
            anhSps=anhSanPham };
        return View(homeProductDetailViewModel);
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    
    
}
