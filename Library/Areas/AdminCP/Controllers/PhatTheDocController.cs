using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Library.Tables;
using Library.Areas.AdminCP.Models;
using PagedList;
using PagedList.Mvc;

namespace Library.Areas.AdminCP.Controllers
{
    public class PhatTheDocController : BaseController
    {
        // GET: AdminCP/PhatTheDoc
        public ActionResult Index(int page=1, int pagesize=10)
        {
            var md = new PhatTheDocModel();
            var ds=md.ListAll(page,pagesize);
            return View(ds);
        }

        // GET: AdminCP/PhatTheDoc/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminCP/PhatTheDoc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminCP/PhatTheDoc/Create
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

        // GET: AdminCP/PhatTheDoc/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminCP/PhatTheDoc/Edit/5
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

        // GET: AdminCP/PhatTheDoc/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminCP/PhatTheDoc/Delete/5
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
