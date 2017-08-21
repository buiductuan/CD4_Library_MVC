using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using System.Data;
using Library.Models;
namespace Library.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModels model)
        {
            if (ModelState.IsValid)
            {
                var isLogin = model.isLogin(model.username, model.password);
                if (isLogin)
                {
                    Session.Add("USER_NAME", model.username);
                    return Redirect("/AdminCP/Home");
                }
                else
                {
                    ModelState.AddModelError("", "Tài khoản hoặc mật khẩu không chính xác");
                }
            }
            return View("Login");
        }
    }
}
