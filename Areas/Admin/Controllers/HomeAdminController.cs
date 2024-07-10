using Microsoft.AspNetCore.Mvc;
using GroupProject.Models.Authentication;


namespace GroupProject.Areas.Admin.Controllers
{
    //[Authentication]
    //[CheckRoleAdmin]
    [Area("admin")]
    [Route("admin")]
    [Route("admin/homeadmin")]
    public class HomeAdminController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
