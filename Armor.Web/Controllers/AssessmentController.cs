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


        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult ProgramEvaluatorStage1()
        {
            ProgramEvaluator1ViewModel model = new ProgramEvaluator1ViewModel();
            return View(model);
        }


        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult ProgramEvaluatorStage1(ProgramEvaluator1ViewModel model, FormCollection fc)
        {
            try
            {

                Stage1Service Stage1 = new Stage1Service();
                Data.ProgramEvaluatorStage1 S1 = new Data.ProgramEvaluatorStage1();

                S1.UserID = CurrentUserID;
                S1.DateTimeTakenUTC = DateTime.UtcNow;

                S1.Question1 = model.Question1;
                S1.Question2 = model.Question2;
                S1.Question3 = model.Question3;
                S1.Question4 = model.Question4;
                S1.Question5 = model.Question5;
                S1.Question6 = model.Question6;
                S1.Question7 = model.Question7;
                S1.Question8 = model.Question8;
                S1.Question9 = model.Question9;
                S1.Question10 = model.Question10;
                S1.Question11 = model.Question11;

                S1.Question12 = fc["Question12"];
                S1.Question13 = fc["Question13"];

                if (fc["Question14"].Contains("Other"))
                    S1.Question14 = "Other: " + fc["Question14Other"];
                else S1.Question14 = fc["Question14"];

                if (fc["Question15"].Contains("Other"))
                    S1.Question15 = "Other: " + fc["Question15Other"];
                else S1.Question15 = fc["Question15"];

                S1.Question16 = fc["Question16"];

                int i =1;
                foreach (AnswerModel item in model.Question17)
                {
                    if (fc.Get("Question17.AnswerCheck" + i) != "false")
                    {
                        S1.Question17 += item.Value + "; ";
                    }
                    i++;
                }
                if (fc["Question17Other"] != null)
                {
                    S1.Question17 += fc["Question17Other"];
                }
                

                if (fc["Question18"].Contains("Other"))
                    S1.Question18 = "Other: " + fc["Question18Other"];
                else S1.Question18 = fc["Question18"];

                S1.Question19 = fc["Question19"];

                S1.Question20 = "Low: " + model.Question20Low + " Moderate: " + model.Question20Moderate + " High: " + model.Question20High;

                Stage1.Save(S1);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

       
    }
}
