using Microsoft.AspNetCore.Mvc;
using GroupProject.Models;

namespace GroupProject.Controllers
{
    public class AccessController : Controller
    {
        DataContext db = new DataContext();
        //Login
        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            if (HttpContext.Session.GetString("Username") == null)
            {
                var checkRoles = db.Users.Where(x => x.Username.Equals(user.Username) && x.Password.Equals(user.Password) && x.LoaiUser.Equals("0")).FirstOrDefault();
                if (checkRoles != null)
                {
                    HttpContext.Session.SetString("Username", checkRoles.Username.ToString().Trim());
                    HttpContext.Session.SetString("Role", checkRoles.LoaiUser.ToString().Trim());
                    return RedirectToAction("index", "homeadmin", new { area = "admin" });
                }

                var checkRoleGV = db.Users.Where(x => x.Username.Equals(user.Username) && x.Password.Equals(user.Password) && x.LoaiUser.Equals("1")).FirstOrDefault();
                if (checkRoleGV != null)
                {
                    HttpContext.Session.SetString("Username", checkRoleGV.Username.ToString().Trim());
                    HttpContext.Session.SetString("Role", checkRoleGV.LoaiUser.ToString().Trim());
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
