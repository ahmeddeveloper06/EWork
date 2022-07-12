using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EWork.Areas.Trainee.Controllers
{
    public class HomeController : Controller
    {
        // GET: Trainee/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}