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
    public class TheDocModel
    {
        private LibDBContext db=null;
        public TheDocModel()
        {
            db = new LibDBContext();
        }
        public IEnumerable<library_the_doc> ListAll(int page, int pagesize)
        {
            var ds = db.library_the_doc.OrderByDescending(s => s.ma).ToPagedList(page, pagesize);
            return ds;
        }
        public IEnumerable<library_the_doc> ListAllFilter(string filter,int page, int pagesize)
        {
            if (filter == "gv")
            {
                var ds = db.library_the_doc.Where(s=>s.ma_loai_the=="1").OrderByDescending(s => s.ma).ToPagedList(page, pagesize);
                return ds;
            }
            else
            {
                var ds = db.library_the_doc.Where(s => s.ma_loai_the == "0").OrderByDescending(s => s.ma).ToPagedList(page, pagesize);
                return ds;
            }
            
        }
    }
}