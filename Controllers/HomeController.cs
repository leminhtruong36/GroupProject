using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GroupProject.Models;

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
    
     int pagesize = 8;
     int pageNumber= page ==null || page<0?1:page.Value;
     var lstsanpham = db.DanhMucSps.AsNoTracking().OrderBy(x=>x.TenSp);
     PagedList<DanhMucSp> lst = new PagedList<DanhMucSp>(lstsanpham, pageNumber, pagesize);
     return View(lstsanpham);
 }

 public IActionResult SanPhamTheoLoai(string naloai, int ? page)
 {
     int pagesize = 8;
     int pageNumber = page == null || page < 0 ? 1 : page.Value;
     var lstsanpham = db.DanhMucSp.AsNoTracking().OrderBy(x => x.TenSp);
     PagedList<DanhMucSp> lst = new PagedList<DanhMucSp>(lstsanpham, pageNumber, pagesize);
     ViewBag.maloai = maloai;
     return View(lst);
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
