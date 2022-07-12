using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EWork.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        public int CurrentAdminID { get; set; }
        public string CurrentUserID { get; set; }
        public string CurrentAdminName { get; set; }

        protected Models.EWorkEntities db = new Models.EWorkEntities();

        public BaseController()
        {
            this.CurrentAdminID = 1;
            this.CurrentAdminName = "محمد";
            ViewBag.db = db;
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