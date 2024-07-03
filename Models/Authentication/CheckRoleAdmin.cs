using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;


namespace GroupProject.Models.Authentication
{
    public class CheckRoleAdmin : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.Session.GetString("Role") != "1")
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "Area", "Admin" }, { "Controller", "HomeAdmin" }, { "Action", "Index" } });
            }
            else
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary { { "Controller", "Home" }, { "Action", "Index" } });
            }
        }
    }
}
