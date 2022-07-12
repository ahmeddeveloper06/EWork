using EWork.Models;
using EWork.MyClasses;
using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EWork.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        PluginDBEntities PluginDB = new PluginDBEntities();

        [HttpPost]
        public JsonResult AjaxDT(DataTableParameters dataTableParameters, string q,
            bool? Active)
        {
            //if (!string.IsNullOrEmpty(q))
            //    q = "%" + q.Replace(" ", "%") + "%";
            ////string[] orderByColumns = new string[] { "name", "Code", "Description", "Created_At" };
            //var query = db.Categories.Where(x => x.IsDelete == false &&
            //    (string.IsNullOrEmpty(q) || SqlFunctions.PatIndex(q, x.Name) > 0) &&
            //    (Active == null || x.Active == Active)
            //  );

            //int totalCount = query.Count();
            //var items = query.Select(x => new
            //{
            //    x.ID,
            //    x.Name,
            //    x.Active,
            //    x.Created_At
            //});
            //items = items/*.OrderBy(orderByColumns[dataTableParameters.Order.FirstOrDefault().Column] + " "
            //    + dataTableParameters.Order.FirstOrDefault().Dir)*/
            //    .OrderBy(x => x.Name)
            //    .Skip(dataTableParameters.Start).Take(dataTableParameters.Length);

            //var result =
            //   new
            //   {
            //       draw = dataTableParameters.Draw,
            //       recordsTotal = totalCount,
            //       recordsFiltered = totalCount,
            //       data = items.ToList()
            //   };
            //return Json(result);

            var Memberlist = (from key in PluginDB.Members
                              select new
                              {
                                  key.ID,
                                  key.Active,
                                  key.FirstName,
                                  key.LastName,
                                  key.Country,
                                  key.AddedAt

                              }).ToList();

            var result =
               new
               {
                   draw = dataTableParameters.Draw,
                   recordsTotal = Memberlist.Count,
                   recordsFiltered = Memberlist.Count,
                   data = Memberlist
               };
            return Json(result);
        }
        public ActionResult Active(int id)
        {
            var item = db.Categories.Find(id);
            //var item = db.Categories.Where(x => x.ID == id).FirstOrDefault();
            //var item = db.Categories.Where(x => x.ID == id).First();
            if (item != null)
            {
                item.Active = !item.Active;
                item.Updated_At = DateTime.Now;
                item.Updated_By = CurrentAdminID;
                db.Entry(item).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return Json(new { status=1,msg="s:تم التعديل بنجاح" }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { status = 0, msg = "w:الرجاء التاكد من الرقم المرسل" }, JsonRequestBehavior.AllowGet);

        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Category item)
        {
            if (ModelState.IsValid)
            {
                var IsExists = db.Categories.Count(x => x.Name == item.Name && x.IsDelete == false) > 0;
                if (IsExists)
                {
                    TempData["msg"] = "w: لا يمكن الاضافة بسبب وجود العنصر";
                    return View();
                }
                item.Created_By = CurrentAdminID;
                item.IsDelete = false;
                item.Created_At = DateTime.Now;
                db.Categories.Add(item);
                db.SaveChanges();

                TempData["msg"] = "s: تمت عملية الاضافة بنجاح";
                return RedirectToAction("Create");
            }
            return View();
        }
    }
}