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
    public class AnPhamModel
    {
        private LibDBContext db = null;
        public AnPhamModel()
        {
            db = new LibDBContext();
        }
        public IEnumerable<library_nhap_an_pham> ListAll(int page, int pagesize)
        {
            return db.library_nhap_an_pham.OrderByDescending(s => s.ma_id).ToPagedList(page, pagesize);
        }
    }
}