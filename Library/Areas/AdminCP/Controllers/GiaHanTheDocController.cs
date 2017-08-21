using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Areas.AdminCP.Controllers
{
    public class GiaHanTheDocController : BaseController
    {
        // GET: AdminCP/GiaHanTheDoc
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminCP/GiaHanTheDoc/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminCP/GiaHanTheDoc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminCP/GiaHanTheDoc/Create
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

        // GET: AdminCP/GiaHanTheDoc/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminCP/GiaHanTheDoc/Edit/5
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

        // GET: AdminCP/GiaHanTheDoc/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminCP/GiaHanTheDoc/Delete/5
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
