using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Library.Tables;
using PagedList;
using PagedList.Mvc;
using Library.Areas.AdminCP.Models;
namespace Library.Areas.AdminCP.Controllers
{
    public class TheDocController : BaseController
    {
        private LibDBContext db = new LibDBContext();

        // GET: AdminCP/TheDoc
        public ActionResult Index(int page=1, int pagesize=10)
        {
            string chon = null;
            var md = new TheDocModel();
            try
            {
                chon = Request.Form["sl"].ToString();
            }
            catch (Exception)
            {
                chon="";
            }
            if (chon == "")
                {
                    
                    var ds = md.ListAll(page, pagesize);
                    return View(ds);
                }
                else
                {
                    if (chon == "gv")
                    {
                        var ds = md.ListAllFilter("gv",page, pagesize);
                        return View(ds);
                    }
                    else
                    {
                        var ds = md.ListAllFilter("sv",page, pagesize);
                        return View(ds);
                    }
                }
            

           
            //return View(db.library_the_doc.ToList());
        }

        // GET: AdminCP/TheDoc/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            library_the_doc library_the_doc = db.library_the_doc.Find(id);
            if (library_the_doc == null)
            {
                return HttpNotFound();
            }
            return View(library_the_doc);
        }

        // GET: AdminCP/TheDoc/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminCP/TheDoc/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ma,serial,barcode,ho_dem,ten,gioi_tinh,ngay_sinh,ghi_chu,ghi_chu0,ghi_chu1,ghi_chu2,ghi_chu3,ma_loai_the,ma_trang_thai,hansd_tu,hansd_toi,username,edit_date")] library_the_doc library_the_doc)
        {
            if (ModelState.IsValid)
            {
                db.library_the_doc.Add(library_the_doc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(library_the_doc);
        }

        // GET: AdminCP/TheDoc/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            library_the_doc library_the_doc = db.library_the_doc.Find(id);
            if (library_the_doc == null)
            {
                return HttpNotFound();
            }
            return View(library_the_doc);
        }

        // POST: AdminCP/TheDoc/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ma,serial,barcode,ho_dem,ten,gioi_tinh,ngay_sinh,ghi_chu,ghi_chu0,ghi_chu1,ghi_chu2,ghi_chu3,ma_loai_the,ma_trang_thai,hansd_tu,hansd_toi,username,edit_date")] library_the_doc library_the_doc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(library_the_doc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(library_the_doc);
        }

        // GET: AdminCP/TheDoc/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            library_the_doc library_the_doc = db.library_the_doc.Find(id);
            if (library_the_doc == null)
            {
                return HttpNotFound();
            }
            return View(library_the_doc);
        }

        // POST: AdminCP/TheDoc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            library_the_doc library_the_doc = db.library_the_doc.Find(id);
            db.library_the_doc.Remove(library_the_doc);
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
