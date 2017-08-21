using System;
using System.Collections.Generic;
using System.Web;
using Library.Tables;
using System.Data.SqlClient;
using PagedList.Mvc;
using PagedList;
using System.Linq;
using System.Data.Linq;
namespace Library.Areas.AdminCP.Models
{
    public class DmChungModel
    {
        private LibDBContext db=null;
        public DmChungModel()
        {
            db = new LibDBContext();
        }
        public IEnumerable<library_dm_chung> ListAllNoPaged(string Table_name)
        {
            return db.library_dm_chung.Where(s => s.table_name == Table_name).OrderByDescending(x => x.ma).ToList();
        }
        public IEnumerable<library_dm_chung> ListAll(string Table_name,int page, int pagesize)
        {
            return db.library_dm_chung.Where(s=>s.table_name==Table_name).OrderByDescending(x =>x.ma).ToPagedList(page,pagesize);
        }
        public bool update(library_dm_chung dt)
        {
            try
            {
                var lib = db.library_dm_chung.Find(dt.ma);
                lib.ky_hieu = dt.ky_hieu;
                lib.ten = dt.ten;
                lib.active = dt.active;
                lib.edit_date = DateTime.Now;
                lib.ghi_chu = dt.ghi_chu;
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool insert(library_dm_chung dt)
        {
            try
            {
                db.library_dm_chung.Add(dt);
                db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool delete(library_dm_chung dt)
        {
            try
            {
                db.library_dm_chung.Attach(dt);
                db.library_dm_chung.Remove(dt);
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