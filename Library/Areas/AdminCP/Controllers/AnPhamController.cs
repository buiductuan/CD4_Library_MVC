using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using System.Data;
using Library.Areas.AdminCP.Models;
namespace Library.Areas.AdminCP.Controllers
{
    public class AnPhamController : BaseController
    {
        // GET: AdminCP/AnPham
        public ActionResult Index(int page=1,int pagesize=10)
        {
            var model = new AnPhamModel();
            var ds = model.ListAll(page, pagesize);
            return View(ds);
        }

        // GET: AdminCP/AnPham/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminCP/AnPham/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminCP/AnPham/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminCP/AnPham/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminCP/AnPham/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminCP/AnPham/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminCP/AnPham/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
