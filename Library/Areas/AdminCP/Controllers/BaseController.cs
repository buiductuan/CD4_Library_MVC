using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using Library.Models;
using System.Web.Routing;
using System.Globalization;
namespace Library.Areas.AdminCP.Controllers
{
    public class BaseController : Controller
    {

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = Session["USER_NAME"];
            if (session == null)
            {
                //filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Default", action = "Login" }));
                filterContext.Result = Redirect("/Default/Login");
            }
            base.OnActionExecuting(filterContext);
        }

        public void GetViewBag_Session()
        {
            var session = Session["USER_NAME"];
            if (session != null)
            {
                ViewBag.UserName = Session["USER_NAME"].ToString();
            }
        }
    }
}
