using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EWork.Areas.Admin.Controllers
{
    public class CountryController : BaseController
    {
        // GET: Admin/Country
        public ActionResult Index()
        {
            return View();
        }
    }
}