using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Library.Tables;
using Library.Areas.AdminCP.Models;
using PagedList;
using PagedList.Mvc;

namespace Library.Areas.AdminCP.Controllers
{
    public class DmTlController : BaseController
    {
        private LibDBContext db = new LibDBContext();

        // GET: AdminCP/DmTl
        public ActionResult Index(int page = 1, int pagesize = 10)
        {
            var ds = new DmChungModel();
            var model = ds.ListAll("lib_dm_dinh_dang", page, pagesize);
            return View(model);
        }

        // GET: AdminCP/DmTl/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            library_dm_chung library_dm_chung = db.library_dm_chung.Find(id);
            if (library_dm_chung == null)
            {
                return HttpNotFound();
            }
            return View(library_dm_chung);
        }

        // GET: AdminCP/DmTl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminCP/DmTl/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma,ten,ky_hieu,ghi_chu,active,ma_parent,username,edit_date,table_name,last_code")] library_dm_chung library_dm_chung)
        {
            if (ModelState.IsValid)
            {
                db.library_dm_chung.Add(library_dm_chung);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(library_dm_chung);
        }

        // GET: AdminCP/DmTl/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            library_dm_chung library_dm_chung = db.library_dm_chung.Find(id);
            if (library_dm_chung == null)
            {
                return HttpNotFound();
            }
            return View(library_dm_chung);
        }

        // POST: AdminCP/DmTl/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma,ten,ky_hieu,ghi_chu,active,ma_parent,username,edit_date,table_name,last_code")] library_dm_chung library_dm_chung)
        {
            if (ModelState.IsValid)
            {
                db.Entry(library_dm_chung).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(library_dm_chung);
        }

        // GET: AdminCP/DmTl/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            library_dm_chung library_dm_chung = db.library_dm_chung.Find(id);
            if (library_dm_chung == null)
            {
                return HttpNotFound();
            }
            return View(library_dm_chung);
        }

        // POST: AdminCP/DmTl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            library_dm_chung library_dm_chung = db.library_dm_chung.Find(id);
            db.library_dm_chung.Remove(library_dm_chung);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
