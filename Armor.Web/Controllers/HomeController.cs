using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RichmondDay.Helpers;
using System.Globalization;

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
            //return View();

            return RedirectToAction("Login", "Account");
        }

        public ActionResult About()
        {
            return View();
        }


        public ActionResult ChangeCulture(string lang, string returnUrl)
        {
            Session["Culture"] = new CultureInfo(lang);
            return Redirect(returnUrl);
        }



        //public ActionResult English()
        //{
        //    CookieHelpers.WriteCookie("Amorlc", "lang", "en");

        //    if (TempData["returnUrl"] != null)
        //        return Redirect(TempData["returnUrl"].ToString());

        //    return RedirectToAction("index", "Assessment");
        //}

        //public ActionResult French()
        //{
        //    CookieHelpers.WriteCookie("Amorlc", "lang", "fr");

        //    if (TempData["returnUrl"] != null)
        //        return Redirect(TempData["returnUrl"].ToString());

        //    return RedirectToAction("index", "Assessment");
        //}
    }
}
