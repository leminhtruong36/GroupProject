using Microsoft.AspNetCore.Mvc;
using GroupProject.Models;

namespace GroupProject.Controllers
{
    public class AccessController : Controller
    {
        GroupProjectDBContext db = new GroupProjectDBContext();
        //Login
        [HttpGet]
        public IActionResult Login()
        {
            TempData["Message"] = "";
            if (HttpContext.Session.GetString("Username") == null)
            {
                return View();
            }
            else
            {
                TempData["Message"] = "Sai thong tin dang nhap";
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult Login(TUser Users)
        {
            TempData["Message"] = "";
            if (HttpContext.Session.GetString("Username") == null)
            {
                var u = db.TUsers.Where(x => x.Username.Equals(Users.Username) && x.Password.Equals(Users.Password) && x.LoaiUser == (byte)0).FirstOrDefault();
                if (u != null)
                {
                    TempData["Message"] = "admin";
                    HttpContext.Session.SetString("Username", u.Username.ToString().Trim());
                    HttpContext.Session.SetString("Role", u.LoaiUser.ToString().Trim());
                    return RedirectToAction("index", "homeadmin", new { area = "admin" });
                }

                var a = db.TUsers.Where(x => x.Username.Equals(Users.Username) && x.Password.Equals(Users.Password) && x.LoaiUser == (byte)1).FirstOrDefault();
                if (a != null)
                {
                    TempData["Message"] = "user";
                    HttpContext.Session.SetString("Username", a.Username.ToString().Trim());
                    HttpContext.Session.SetString("Role", a.LoaiUser.ToString().Trim());
                    return RedirectToAction("index", "home");
                }
            }
            return View();
        }

        //Logout
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("Username");
            return RedirectToAction("Login", "Access");
        }
    }

}
