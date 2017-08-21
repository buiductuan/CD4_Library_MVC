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
    public class DmBmController : BaseController
    {
        private LibDBContext db = new LibDBContext();
        private DmChungModel model = new DmChungModel();
        private string TableName = "dm_bo_mon";

        // GET: AdminCP/DmBm
        public ActionResult Index()
        {
            return View();
        }

        //Ajax
        public JsonResult getList()
        {
            var list = model.ListAllNoPaged(TableName);
            return Json(new {
               list
            },JsonRequestBehavior.AllowGet);
        }
        public string getARecord(string id)
        {
            library_dm_chung dm = db.library_dm_chung.Find(id);
            return id+"#"+dm.ten + "#" + dm.ky_hieu + "#" + dm.ghi_chu + "#" + dm.active;
        }
        public string getADetail(string id)
        {
            library_dm_chung dm = db.library_dm_chung.Find(id);
            return dm.ten + "#" + dm.ky_hieu + "#" + dm.ghi_chu + "#" + dm.active + "#" + dm.ma_parent + "#" + dm.username + "#" + dm.edit_date + "#" + dm.table_name + "#" + dm.last_code;
        }

        [HttpPost]
        public bool postCreate(string ma, string ten, string ky_hieu,string ma_parent, string ghi_chu, bool active)
        {
            library_dm_chung dm = new library_dm_chung();
            dm.ma = ma;
            dm.ten = ten;
            dm.ky_hieu = ky_hieu;
            dm.ghi_chu = ghi_chu;
            dm.active = active;
            dm.ma_parent = ma_parent;
            dm.edit_date = DateTime.Now;
            dm.table_name = "dm_bo_mon";
            dm.last_code = 1;
            return model.insert(dm);
        }

        [HttpPost]
        public bool postUpdate(string ma, string ten, string ky_hieu, string ghi_chu, bool active)
        {
            library_dm_chung dm = new library_dm_chung();
            dm.ma = ma;
            dm.ten = ten;
            dm.ky_hieu = ky_hieu;
            dm.ghi_chu = ghi_chu;
            dm.active = active;
            return model.update(dm);
        }

        public bool getDelete(string id)
        {
            var dt = db.library_dm_chung.SingleOrDefault(d=>d.ma == id);
            return model.delete(dt);
        }
    }
}
