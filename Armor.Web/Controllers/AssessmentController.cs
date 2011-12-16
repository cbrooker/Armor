﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Armor.Web.Models;
using Epilogger.Web;
using Newtonsoft.Json;

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

                S1.Question12 = fc["Question12.AnswerOptions"];
                S1.Question13 = fc["Question13.AnswerOptions"];

                if (fc["Question14.AnswerOptions"].Contains("Other"))
                    S1.Question14 = "Other: " + fc["Question14Other"];
                else S1.Question14 = fc["Question14.AnswerOptions"];

                if (fc["Question15.AnswerOptions"].Contains("Other"))
                    S1.Question15 = "Other: " + fc["Question15Other"];
                else S1.Question15 = fc["Question15.AnswerOptions"];

                S1.Question16 = fc["Question16.AnswerOptions"];

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


                if (fc["Question18.AnswerOptions"].Contains("Other"))
                    S1.Question18 = "Other: " + fc["Question18Other"];
                else S1.Question18 = fc["Question18.AnswerOptions"];

                S1.Question19 = fc["Question19.AnswerOptions"];

                S1.Question20 = "Low: " + model.Question20Low + " Moderate: " + model.Question20Moderate + " High: " + model.Question20High;

                Stage1.Save(S1);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }


        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult PatientAssessment()
        {
            PatientAssessmentViewModel model = new PatientAssessmentViewModel();
            return View(model);
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult PatientAssessment(PatientAssessmentViewModel model, FormCollection fc)
        {
            try
            {

                PatientAssessmentService PAS = new PatientAssessmentService();
                Data.PatientAssessment S1 = new Data.PatientAssessment();

                S1.UserID = CurrentUserID;
                S1.DateTimeTakenUTC = DateTime.UtcNow;

                S1.Question1 = fc["Question1.AnswerOptions"];
                S1.Question2 = fc["Question2.AnswerOptions"];
                S1.Question3 = fc["Question3.AnswerOptions"];
                S1.Question4 = fc["Question4.AnswerOptions"];
                S1.Question5 = fc["Question5.AnswerOptions"];
                S1.Question6 = model.Question6.ToString();
                S1.Question7 = fc["Question7.AnswerOptions"];

                S1.Question8 = fc["Question8.AnswerOptions"];
                if (S1.Question8 == "H pylori infection")
                {
                    S1.Question8 = "H pylori infection - " + fc["Question8.SubAnswerOptions"];
                }

                //9 add to an object, then serialize to JSON, store the string.
                OEMedicationMatrix OEM = new OEMedicationMatrix();
                OEM.Acetaminophen = fc["Question9_Acetaminophen"];
                OEM.Aspirin = fc["Question9_Aspirin"];
                OEM.Diclofenac = fc["Question9_Diclofenac"];
                OEM.DiclofenacMisoprostol = fc["Question9_DiclofenacMisoprostol"];
                OEM.Ibuprofen = fc["Question9_Ibuprofen"];
                OEM.Indomethacin = fc["Question9_Indomethacin"];
                OEM.Meloxicam = fc["Question9_Meloxicam"];
                OEM.Naproxen = fc["Question9_Naproxen"];
                OEM.NaproxenEsomeprazole = fc["Question9_Naproxen—esomeprazole"];
                OEM.Celecoxib = fc["Question9_Celecoxib"];
                OEM.AcetaminophenTramadol = fc["Question9_Acetaminophen/tramadol"];
                OEM.Codeine = fc["Question9_Codeine"];
                OEM.Tramadol = fc["Question9_Tramadol"];
                OEM.Other = fc["Question9_Other"];

                S1.Question9 = JsonConvert.SerializeObject(OEM);


                int i = 1;
                foreach (AnswerModel item in model.Question10)
                {
                    if (fc.Get("Question10.AnswerCheck" + i) != "false")
                    {
                        S1.Question10 += item.Value + "; ";
                    }
                    i++;
                }

                S1.Question11 = fc["Question11.AnswerOptions"];
                S1.Question12 = model.Question12;

                S1.Question13 = fc["Question13.AnswerOptions"];
                if (S1.Question13 == "Switch to")
                {
                    OEMedicationMatrix OEM2 = new OEMedicationMatrix();
                    OEM2.Acetaminophen = fc["Question13_Acetaminophen"];
                    OEM2.Aspirin = fc["Question13_Aspirin"];
                    OEM2.Diclofenac = fc["Question13_Diclofenac"];
                    OEM2.DiclofenacMisoprostol = fc["Question13_DiclofenacMisoprostol"];
                    OEM2.Ibuprofen = fc["Question13_Ibuprofen"];
                    OEM2.Indomethacin = fc["Question13_Indomethacin"];
                    OEM2.Meloxicam = fc["Question13_Meloxicam"];
                    OEM2.Naproxen = fc["Question13_Naproxen"];
                    OEM2.NaproxenEsomeprazole = fc["Question13_Naproxen—esomeprazole"];
                    OEM2.Celecoxib = fc["Question13_Celecoxib"];
                    OEM2.AcetaminophenTramadol = fc["Question13_Acetaminophen/tramadol"];
                    OEM2.Codeine = fc["Question13_Codeine"];
                    OEM2.Tramadol = fc["Question13_Tramadol"];
                    OEM2.Other = fc["Question13_Other"];

                    S1.Question13 = JsonConvert.SerializeObject(OEM2);
                }

                PAS.Save(S1);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult PreAssessment()
        {
            PreAssessmentViewModel model = new PreAssessmentViewModel();
            return View(model);
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult PreAssessment(PreAssessmentViewModel model, FormCollection fc)
        {
            try
            {

                PreAssessmentService PAS = new PreAssessmentService();
                Data.PreAssessment S1 = new Data.PreAssessment();

                S1.UserID = CurrentUserID;
                S1.DateTimeTakenUTC = DateTime.UtcNow;

                S1.Question1 = model.Question1;
                S1.Question2 = model.Question2;
                S1.Question3 = model.Question3;
                S1.Question4 = model.Question4;
                S1.Question5 = "Active Smoker: " + model.Question5ActiveSmoker + "%, Ex-Smoker: " + model.Question5ExSmoker + "%, Non-Smoker: " + model.Question5NonSmoker + "%";

                S1.Question6 = model.Question6;
                S1.Question7 = model.Question7;
                S1.Question8 = model.Question8;

                S1.Question9 = "Uncomplicated peptic ulcer: " + model.Question9UncomplicatedPepticUlcer + 
                                "%, GERD: " + model.Question9GERD + 
                                "%, Dyspepsia: " + model.Question9Dyspepsia + 
                                "%, Bleeding peptic ulcer: " + model.Question9BleedingPepticUlcer + 
                                "%, H pylori infection: " + model.Question9HpyloriInfection + "%";

                S1.Question10 = "Cervical: " + model.Question10Cervical +
                                "%, Dorsal: " + model.Question10Dorsal +
                                "%, Lumbar: " + model.Question10Lumbar +
                                "%, Hand: " + model.Question10Hand +
                                "%, Hip: " + model.Question10Hip +
                                "%, Knee: " + model.Question10Knee + "%";


                S1.Question11 = "Low Risk: " + model.Question11Low + "%, Moderate Risk: " + model.Question11Moderate + "%, High Risk: " + model.Question11High + "%";

                //12 add to an object, then serialize to JSON, store the string.
                OEMedicationMatrix OEM = new OEMedicationMatrix();
                OEM.Acetaminophen = fc["Question12_Acetaminophen"];
                OEM.Aspirin = fc["Question12_Aspirin"];
                OEM.Diclofenac = fc["Question12_Diclofenac"];
                OEM.DiclofenacMisoprostol = fc["Question12_DiclofenacMisoprostol"];
                OEM.Ibuprofen = fc["Question12_Ibuprofen"];
                OEM.Indomethacin = fc["Question12_Indomethacin"];
                OEM.Meloxicam = fc["Question12_Meloxicam"];
                OEM.Naproxen = fc["Question12_Naproxen"];
                OEM.NaproxenEsomeprazole = fc["Question12_NaproxenEsomeprazole"];
                OEM.Celecoxib = fc["Question12_Celecoxib"];
                OEM.AcetaminophenTramadol = fc["Question12_AcetaminophenTramadol"];
                OEM.Codeine = fc["Question12_Codeine"];
                OEM.Tramadol = fc["Question12_Tramadol"];
                OEM.Other = fc["Question12_Other"];

                S1.Question12 = JsonConvert.SerializeObject(OEM);
                
                PAS.Save(S1);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }

       
    }
}
