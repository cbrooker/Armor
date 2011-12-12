using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Armor.Web.Models;
using Epilogger.Web;

namespace Armor.Web.Controllers
{
    public class AssessmentController : BaseController
    {
        //
        // GET: /Assessment/

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult Index()
        {
            AssessmentChecklistViewModel model = new AssessmentChecklistViewModel();

            model.user = CurrentUser;

            return View(model);
        }

        //
        // GET: /Assessment/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Assessment/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Assessment/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        
 
        public ActionResult ProgramEvaluatorStage1()
        {
            ProgramEvaluator1ViewModel model = new ProgramEvaluator1ViewModel();
            return View(model);
        }

       

        [HttpPost]
        public ActionResult ProgramEvaluatorStage1(ProgramEvaluator1ViewModel model)
        {
            try
            {
                // TODO: Add update logic here
                
                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

       
    }
}
