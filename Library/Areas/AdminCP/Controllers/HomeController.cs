using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Areas.AdminCP.Controllers
{
    public class HomeController : BaseController
    {
        // GET: AdminCP/Home
        public ActionResult Index()
        {
            GetViewBag_Session();
            return View();
        }

        [HttpGet]
        public ActionResult Logout()
        {
            Session.Remove("USER_NAME");
            return Redirect("/Default/Login");
        }
    }
}