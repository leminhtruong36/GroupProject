using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using GroupProject.Models;
using X.PagedList;
using Microsoft.EntityFrameworkCore;
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

    public IActionResult SanPhamTheoLoai(int maloai, int? page)
  {
//Doi String maloai thanh int maloai
     int pageSize = 8;
     int pageNumber = page == null || page < 0 ? 1 : page.Value;
     var lstsanpham = db.DanhMucSPs.AsNoTracking().Where(x=>x.MaLoai=maloai)
         .OrderBy(x => x.TenSP);
     PagedList<DanhMucSP> lst = new PagedList<DanhMucSP>(lstsanpham, pageNumber, pageSize);
     ViewBag.maloai = maloai;
     return View(lstsanpham);
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
