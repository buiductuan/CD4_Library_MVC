using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Tables;
using System.Data.SqlClient;
using PagedList.Mvc;
using PagedList;
namespace Library.Areas.AdminCP.Models
{
    public class PhatTheDocModel
    {
        private LibDBContext db = null;
        public PhatTheDocModel()
        {
            db = new LibDBContext();
        }
        public IEnumerable<library_phat_the_doc> ListAll(int page, int pagesize)
        {
            var ds = db.library_phat_the_doc.OrderByDescending(s => s.ma_the_doc).ToPagedList(page, pagesize);
            return ds;
        }
        public bool update(library_phat_the_doc dt)
        {
            try
            {
                var lib = db.library_phat_the_doc.Find(dt.ma_hd);
                lib.ma_the_doc = dt.ma_the_doc;
                lib.ngay = dt.ngay;
                lib.ma_ly_do = dt.ma_ly_do;
                lib.ma_hinh_thuc = dt.ma_hinh_thuc;
                lib.ma_hinh_thuc = dt.ma_hinh_thuc;
                lib.phat_so_tien = dt.phat_so_tien;
                lib.phat_ht_khac = lib.phat_ht_khac;
                lib.edit_date = lib.edit_date;
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool insert(library_phat_the_doc dt)
        {
            try
            {
                db.library_phat_the_doc.Add(dt);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool delete(library_phat_the_doc dt)
        {
            try
            {
                db.library_phat_the_doc.Remove(dt);
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}