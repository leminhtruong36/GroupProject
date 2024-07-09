using Microsoft.AspNetCore.Mvc;
using GroupProject.Models.Authentication;
using GroupProject.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using X.PagedList;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;


namespace GroupProject.Areas.Admin.Controllers
{
    [Authentication]
    [CheckRoleAdmin]
    [Area("admin")]
    [Route("admin")]
    [Route("admin/homeadmin")]
    public class HomeAdminController : Controller
    {
        DataContext db = new DataContext();

        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("danhmucsanpham")]
        public IActionResult DanhMucSanPham(int? page)
        {
            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            var lstsanpham = db.DanhMucSPs.AsNoTracking().OrderBy(x => x.TenSP);
            PagedList<DanhMucSP> lst = new PagedList<DanhMucSP>(lstsanpham, pageNumber, pageSize);
            return View(lst);
        }

        [Route("ThemSanPhamMoi")]
        [HttpGet]
        public IActionResult ThemSanPhamMoi()
        {
            //ViewBag.MaChatLieu = new SelectList(db.ChatLieus.ToList(),"MaChatLieu","ChatLieu");
            //ViewBag.MaHangSX = new SelectList(db.ChatLieus.ToList(), "MaHangSX", "HangSx");
            //ViewBag.MaNuocSX = new SelectList(db.ChatLieus.ToList(), "MaNuocSX", "TenNuoc");
            //ViewBag.MaLoai = new SelectList(db.ChatLieus.ToList(), "MaLoai", "Loai");
            //ViewBag.MaDT = new SelectList(db.ChatLieus.ToList(), "MaDT", "TenLoai"); 
            return View();
        }

        [Route("ThemSanPhamMoi")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemSanPhamMoi(DanhMucSP sanPham)
        {
            //if(ModelState.IsValid)
            //{ 
            db.DanhMucSPs.Add(sanPham);
            db.SaveChanges();
            return RedirectToAction("DanhMucSanPham");
            //}
            //return View();
        }

        [Route("SuaSanPham")]
        [HttpGet]
        public IActionResult SuaSanPham(string maSanPham)
        {
            //ViewBag.MaChatLieu = new SelectList(db.ChatLieus.ToList(),"MaChatLieu","ChatLieu");
            //ViewBag.MaHangSX = new SelectList(db.ChatLieus.ToList(), "MaHangSX", "HangSx");
            //ViewBag.MaNuocSX = new SelectList(db.ChatLieus.ToList(), "MaNuocSX", "TenNuoc");
            //ViewBag.MaLoai = new SelectList(db.ChatLieus.ToList(), "MaLoai", "Loai");
            //ViewBag.MaDT = new SelectList(db.ChatLieus.ToList(), "MaDT", "TenLoai"); 
            var sanPham = db.DanhMucSPs.Find(maSanPham);
            return View(sanPham);
        }

        [Route("SuaSanPham")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaSanPham(DanhMucSP sanPham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sanPham).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("DanhMucSanPham", "HomeAdmin");
            }
            return View(sanPham);
        }



        //[Route("XoaSanPham")]
        //[HttpGet]
        //public IActionResult XoaSanPham(string maSanPham)
        //{
        //    TempData["Message"] = "";
        //    var chiTietSanPhams = db.ChiTietSanPhams.Where(x =>x.MaSP == maSanPham).ToList();
        //    if (chiTietSanPhams.Count() > 0)
        //    {

        //        TempData["Message"] = "Không xóa được sản phẩm này";
        //        return RedirectToAction("DanhMucSanPham", "HomeAdmin");
        //    }
        
        //var anhSanPhams = db.AnhSPs.Where(x => x.MaSP == maSanPham);
        //if (anhSanPhams.Any()) db.RemoveRange(anhSanPhams);
        //db.Remove(db.DanhMucSPs.Find(maSanPham));
        //db.SaveChanges();
        //TempData["Message"] = "Sản phẩm đã được xóa";
        //return RedirectToAction("DanhMucSanPham", "HomeAdmin");
        //}    cần thay đổi model + data mới dùng đc
    }
}
