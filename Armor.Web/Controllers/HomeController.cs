using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Armor.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            if (CurrentUser != null)
            {
                return RedirectToAction("Index", "Assessment");
            }
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
