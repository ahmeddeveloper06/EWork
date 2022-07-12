using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EWork.Areas.Admin.Controllers
{
    public class TrainerController : BaseController
    {
        // GET: Admin/Trainer
        public ActionResult Index()
        {
            return View();
        }
    }
}