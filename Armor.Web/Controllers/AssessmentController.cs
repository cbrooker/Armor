using System;
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
            UserService US = new UserService();

            model.user = CurrentUser;
            model.PreAssessmentState = AssessmentState.Disabled;
            model.ProgramStage1State = AssessmentState.Disabled;
            model.ProgramStage2State = AssessmentState.Disabled;
            model.PatientAssessmentState = AssessmentState.Disabled;
            model.ProgramStage3State = AssessmentState.Disabled;

            if (US.PreAssessmentComplete(CurrentUserID)) model.PreAssessmentState = AssessmentState.Complete; else model.PreAssessmentState = AssessmentState.Enabled;

            if (model.PreAssessmentState == AssessmentState.Complete)
            {
                if (US.ProgramStage1Complete(CurrentUserID)) model.ProgramStage1State = AssessmentState.Complete; else model.ProgramStage1State = AssessmentState.Enabled;
            }

            if (model.ProgramStage1State == AssessmentState.Complete)
            {
                if (US.ProgramStage2Complete(CurrentUserID)) model.ProgramStage2State = AssessmentState.Complete; else model.ProgramStage2State = AssessmentState.Enabled;
            }

            if (model.ProgramStage2State == AssessmentState.Complete)
            {
                //Only complete after 25 assessments
                if (US.PatientAssessmentComplete(CurrentUserID)) model.PatientAssessmentState = AssessmentState.Complete; else model.PatientAssessmentState = AssessmentState.Enabled;
                model.PatientAssessmentCount = US.PatientAssessmentCount(CurrentUserID);
            }


            if (model.PatientAssessmentState == AssessmentState.Complete)
            {
                //if (US.PatientAssessmentComplete(CurrentUserID)) model.PatientAssessmentState = AssessmentState.Complete; else model.PatientAssessmentState = AssessmentState.Enabled;
                if (US.ProgramStage3Complete(CurrentUserID)) model.ProgramStage3State = AssessmentState.Complete; else model.ProgramStage3State = AssessmentState.Enabled;
            }




            //if (model.ProgramStage2State == AssessmentState.Complete)
            //{
            //    if (US.ProgramStage3Complete(CurrentUserID)) model.ProgramStage3State = AssessmentState.Complete; else model.ProgramStage3State = AssessmentState.Enabled;
            //}

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
        public ActionResult ProgramEvaluatorStage12(ProgramEvaluator1ViewModel model)
        {
            return View(model);
        }
        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult ProgramEvaluatorStage13(ProgramEvaluator1ViewModel model)
        {
            return View(model);
        }
        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult ProgramEvaluatorStage14(ProgramEvaluator1ViewModel model)
        {
            return View(model);
        }
        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult ProgramEvaluatorStage15(ProgramEvaluator1ViewModel model)
        {
            return View(model);
        }


        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult ProgramEvaluatorStage2()
        {
            ProgramEvaluator1ViewModel model = new ProgramEvaluator1ViewModel();
            return View(model);
        }
        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult ProgramEvaluatorStage22(ProgramEvaluator1ViewModel model)
        {
            return View(model);
        }
        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult ProgramEvaluatorStage23(ProgramEvaluator1ViewModel model)
        {
            return View(model);
        }
        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult ProgramEvaluatorStage24(ProgramEvaluator1ViewModel model)
        {
            return View(model);
        }
        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult ProgramEvaluatorStage25(ProgramEvaluator1ViewModel model)
        {
            return View(model);
        }


        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult ProgramEvaluatorStage3()
        {
            ProgramEvaluator1ViewModel model = new ProgramEvaluator1ViewModel();
            return View(model);
        }
        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult ProgramEvaluatorStage32(ProgramEvaluator1ViewModel model)
        {
            return View(model);
        }
        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult ProgramEvaluatorStage33(ProgramEvaluator1ViewModel model)
        {
            return View(model);
        }
        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult ProgramEvaluatorStage34(ProgramEvaluator1ViewModel model)
        {
            return View(model);
        }
        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult ProgramEvaluatorStage35(ProgramEvaluator1ViewModel model)
        {
            return View(model);
        }


        //[RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        //public ActionResult ProgramEvaluatorStage2()
        //{
        //    ProgramEvaluator1ViewModel model = new ProgramEvaluator1ViewModel();
        //    return View(model);
        //}

        //[RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        //public ActionResult ProgramEvaluatorStage3()
        //{
        //    ProgramEvaluator1ViewModel model = new ProgramEvaluator1ViewModel();
        //    return View(model);
        //}






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

                Stage1.Save(S1);

                return RedirectToAction("ProgramEvaluatorStage12", S1);
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult ProgramEvaluatorStage12(ProgramEvaluator1ViewModel model, FormCollection fc)
        {
            try
            {
                Stage1Service Stage1 = new Stage1Service();
                Data.ProgramEvaluatorStage1 S1 = Stage1.GetByID(model.ID);

                S1.Question4 = model.Question4;
                S1.Question5 = model.Question5;
                S1.Question6 = model.Question6;
                S1.Question7 = model.Question7;
                S1.Question8 = model.Question8;
                S1.Question9 = model.Question9;
                S1.Question10 = model.Question10;
                S1.Question11 = model.Question11;

                Stage1.Save(S1);

                return RedirectToAction("ProgramEvaluatorStage13", S1);
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult ProgramEvaluatorStage13(ProgramEvaluator1ViewModel model, FormCollection fc)
        {
            try
            {
                Stage1Service Stage1 = new Stage1Service();
                Data.ProgramEvaluatorStage1 S1 = Stage1.GetByID(model.ID);

                S1.Question12 = fc["Question12"];
                S1.Question13 = fc["Question13"];

                if (fc["Question14"].Contains("Other"))
                    S1.Question14 = "Other: " + fc["Question14Other"];
                else S1.Question14 = fc["Question14"];

                if (fc["Question15"].Contains("Other"))
                    S1.Question15 = "Other: " + fc["Question15Other"];
                else S1.Question15 = fc["Question15"];

                Stage1.Save(S1);

                return RedirectToAction("ProgramEvaluatorStage14", S1);
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult ProgramEvaluatorStage14(ProgramEvaluator1ViewModel model, FormCollection fc)
        {
            try
            {

                Stage1Service Stage1 = new Stage1Service();
                Data.ProgramEvaluatorStage1 S1 = Stage1.GetByID(model.ID);

                S1.Question16 = fc["Question16"];

                int i = 1;
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

                Stage1.Save(S1);

                return RedirectToAction("ProgramEvaluatorStage15", S1);
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult ProgramEvaluatorStage15(ProgramEvaluator1ViewModel model, FormCollection fc)
        {
            try
            {

                Stage1Service Stage1 = new Stage1Service();
                Data.ProgramEvaluatorStage1 S1 = Stage1.GetByID(model.ID);

                S1.Question19 = "%" + model.Question19 + "%";
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
        [HttpPost]
        public ActionResult ProgramEvaluatorStage2(ProgramEvaluator1ViewModel model, FormCollection fc)
        {
            try
            {

                Stage2Service Stage2 = new Stage2Service();
                Data.ProgramEvaluatorStage2 S2 = new Data.ProgramEvaluatorStage2();

                S2.UserID = CurrentUserID;
                S2.DateTimeTakenUTC = DateTime.UtcNow;

                S2.Question1 = model.Question1;
                S2.Question2 = model.Question2;
                S2.Question3 = model.Question3;

                Stage2.Save(S2);

                return RedirectToAction("ProgramEvaluatorStage22", S2);
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult ProgramEvaluatorStage22(ProgramEvaluator1ViewModel model, FormCollection fc)
        {
            try
            {
                Stage2Service Stage2 = new Stage2Service();
                Data.ProgramEvaluatorStage2 S2 = Stage2.GetByID(model.ID);

                S2.Question4 = model.Question4;
                S2.Question5 = model.Question5;
                S2.Question6 = model.Question6;
                S2.Question7 = model.Question7;
                S2.Question8 = model.Question8;
                S2.Question9 = model.Question9;
                S2.Question10 = model.Question10;
                S2.Question11 = model.Question11;

                Stage2.Save(S2);

                return RedirectToAction("ProgramEvaluatorStage23", S2);
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult ProgramEvaluatorStage23(ProgramEvaluator1ViewModel model, FormCollection fc)
        {
            try
            {
                Stage2Service Stage2 = new Stage2Service();
                Data.ProgramEvaluatorStage2 S2 = Stage2.GetByID(model.ID);

                S2.Question12 = fc["Question12"];
                S2.Question13 = fc["Question13"];

                if (fc["Question14"].Contains("Other"))
                    S2.Question14 = "Other: " + fc["Question14Other"];
                else S2.Question14 = fc["Question14"];

                if (fc["Question15"].Contains("Other"))
                    S2.Question15 = "Other: " + fc["Question15Other"];
                else S2.Question15 = fc["Question15"];

                Stage2.Save(S2);

                return RedirectToAction("ProgramEvaluatorStage24", S2);
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult ProgramEvaluatorStage24(ProgramEvaluator1ViewModel model, FormCollection fc)
        {
            try
            {

                Stage2Service Stage2 = new Stage2Service();
                Data.ProgramEvaluatorStage2 S2 = Stage2.GetByID(model.ID);

                S2.Question16 = fc["Question16"];

                int i = 1;
                foreach (AnswerModel item in model.Question17)
                {
                    if (fc.Get("Question17.AnswerCheck" + i) != "false")
                    {
                        S2.Question17 += item.Value + "; ";
                    }
                    i++;
                }
                if (fc["Question17Other"] != null)
                {
                    S2.Question17 += fc["Question17Other"];
                }


                if (fc["Question18"].Contains("Other"))
                    S2.Question18 = "Other: " + fc["Question18Other"];
                else S2.Question18 = fc["Question18"];

                Stage2.Save(S2);

                return RedirectToAction("ProgramEvaluatorStage25", S2);
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult ProgramEvaluatorStage25(ProgramEvaluator1ViewModel model, FormCollection fc)
        {
            try
            {

                Stage2Service Stage2 = new Stage2Service();
                Data.ProgramEvaluatorStage2 S2 = Stage2.GetByID(model.ID);

                S2.Question19 = "%" + model.Question19 + "%";
                S2.Question20 = "Low: " + model.Question20Low + " Moderate: " + model.Question20Moderate + " High: " + model.Question20High;

                Stage2.Save(S2);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(model);
            }
        }




        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult ProgramEvaluatorStage3(ProgramEvaluator1ViewModel model, FormCollection fc)
        {
            try
            {

                Stage3Service Stage3 = new Stage3Service();
                Data.ProgramEvaluatorStage3 S3 = new Data.ProgramEvaluatorStage3();

                S3.UserID = CurrentUserID;
                S3.DateTimeTakenUTC = DateTime.UtcNow;

                S3.Question1 = model.Question1;
                S3.Question2 = model.Question2;
                S3.Question3 = model.Question3;

                Stage3.Save(S3);

                return RedirectToAction("ProgramEvaluatorStage32", S3);
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult ProgramEvaluatorStage32(ProgramEvaluator1ViewModel model, FormCollection fc)
        {
            try
            {
                Stage3Service Stage3 = new Stage3Service();
                Data.ProgramEvaluatorStage3 S3 = Stage3.GetByID(model.ID);

                S3.Question4 = model.Question4;
                S3.Question5 = model.Question5;
                S3.Question6 = model.Question6;
                S3.Question7 = model.Question7;
                S3.Question8 = model.Question8;
                S3.Question9 = model.Question9;
                S3.Question10 = model.Question10;
                S3.Question11 = model.Question11;

                Stage3.Save(S3);

                return RedirectToAction("ProgramEvaluatorStage33", S3);
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult ProgramEvaluatorStage33(ProgramEvaluator1ViewModel model, FormCollection fc)
        {
            try
            {
                Stage3Service Stage3 = new Stage3Service();
                Data.ProgramEvaluatorStage3 S3 = Stage3.GetByID(model.ID);

                S3.Question12 = fc["Question12"];
                S3.Question13 = fc["Question13"];

                if (fc["Question14"].Contains("Other"))
                    S3.Question14 = "Other: " + fc["Question14Other"];
                else S3.Question14 = fc["Question14"];

                if (fc["Question15"].Contains("Other"))
                    S3.Question15 = "Other: " + fc["Question15Other"];
                else S3.Question15 = fc["Question15"];

                Stage3.Save(S3);

                return RedirectToAction("ProgramEvaluatorStage34", S3);
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult ProgramEvaluatorStage34(ProgramEvaluator1ViewModel model, FormCollection fc)
        {
            try
            {

                Stage3Service Stage3 = new Stage3Service();
                Data.ProgramEvaluatorStage3 S3 = Stage3.GetByID(model.ID);

                S3.Question16 = fc["Question16"];

                int i = 1;
                foreach (AnswerModel item in model.Question17)
                {
                    if (fc.Get("Question17.AnswerCheck" + i) != "false")
                    {
                        S3.Question17 += item.Value + "; ";
                    }
                    i++;
                }
                if (fc["Question17Other"] != null)
                {
                    S3.Question17 += fc["Question17Other"];
                }


                if (fc["Question18"].Contains("Other"))
                    S3.Question18 = "Other: " + fc["Question18Other"];
                else S3.Question18 = fc["Question18"];

                Stage3.Save(S3);

                return RedirectToAction("ProgramEvaluatorStage35", S3);
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult ProgramEvaluatorStage35(ProgramEvaluator1ViewModel model, FormCollection fc)
        {
            try
            {

                Stage3Service Stage3 = new Stage3Service();
                Data.ProgramEvaluatorStage3 S3 = Stage3.GetByID(model.ID);

                S3.Question19 = "%" + model.Question19 + "%";
                S3.Question20 = "Low: " + model.Question20Low + " Moderate: " + model.Question20Moderate + " High: " + model.Question20High;

                Stage3.Save(S3);

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
        public ActionResult PatientAssessment2()
        {
            PatientAssessmentViewModel model = new PatientAssessmentViewModel();
            return View(model);
        }
        public ActionResult PatientAssessment3()
        {
            PatientAssessmentViewModel model = new PatientAssessmentViewModel();
            return View(model);
        }
        public ActionResult PatientAssessment4()
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

                S1.Question1 = fc["Question1"];
                S1.Question2 = fc["Question2"];
                int i=1;
                foreach (AnswerModel item in model.Question3)
                {
                    if (fc.Get("Question3.AnswerCheck" + i) != "false")
                    {
                        S1.Question3 += item.Value + "; ";
                    }
                    i++;
                }

                S1.Question4 = fc["Question4"];
                S1.Question5 = fc["Question5"];

                PAS.Save(S1);

                return RedirectToAction("PatientAssessment2", S1);
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult PatientAssessment2(PatientAssessmentViewModel model, FormCollection fc)
        {
            try
            {
                PatientAssessmentService PAS = new PatientAssessmentService();
                Data.PatientAssessment S1 = PAS.GetByID(model.ID);

                S1.Question6 = model.Question6.ToString();
                S1.Question7 = fc["Question7"];

                S1.Question8 = fc["Question8"];
                if (S1.Question8 == "H pylori infection")
                {
                    S1.Question8 = "H pylori infection - " + fc["Question8_2"];
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

                PAS.Save(S1);

                return RedirectToAction("PatientAssessment3", S1);
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult PatientAssessment3(PatientAssessmentViewModel model, FormCollection fc)
        {
            try
            {
                PatientAssessmentService PAS = new PatientAssessmentService();
                Data.PatientAssessment S1 = PAS.GetByID(model.ID);

                int i = 1;
                foreach (AnswerModel item in model.Question10)
                {
                    if (fc.Get("Question10.AnswerCheck" + i) != "false")
                    {
                        S1.Question10 += item.Value + "; ";
                    }
                    i++;
                }

                S1.Question11 = fc["Question11"];

                PAS.Save(S1);

                return RedirectToAction("PatientAssessment4", S1);
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult PatientAssessment4(PatientAssessmentViewModel model, FormCollection fc)
        {
            try
            {
                PatientAssessmentService PAS = new PatientAssessmentService();
                Data.PatientAssessment S1 = PAS.GetByID(model.ID);

                S1.Question12 = model.Question12;

                S1.Question13 = fc["Ques13Radio"];
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

                return RedirectToAction("index");
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
        public ActionResult PreAssessment2(PreAssessmentViewModel model)
        {
            return View(model);
        }
        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        public ActionResult PreAssessment3(PreAssessmentViewModel model)
        {
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

                PAS.Save(S1);

                return RedirectToAction("PreAssessment2", S1);
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult PreAssessment2(PreAssessmentViewModel model, FormCollection fc)
        {
            try
            {
                PreAssessmentService PAS = new PreAssessmentService();
                Data.PreAssessment S1 = PAS.GetByID(model.ID);
                
                S1.Question5 = "Active Smoker: " + model.Question5ActiveSmoker + "%, Ex-Smoker: " + model.Question5ExSmoker + "%, Non-Smoker: " + model.Question5NonSmoker + "%";
                S1.Question6 = model.Question6;
                S1.Question7 = model.Question7;
                S1.Question8 = model.Question8;

                PAS.Save(S1);

                return RedirectToAction("PreAssessment3", S1);
            }
            catch
            {
                return View(model);
            }
        }

        [RequiresAuthentication(ValidUserRole = UserRoleType.RegularUser, AccessDeniedMessage = "You must be logged in to complete assessments")]
        [HttpPost]
        public ActionResult PreAssessment3(PreAssessmentViewModel model, FormCollection fc)
        {
            try
            {
                PreAssessmentService PAS = new PreAssessmentService();
                Data.PreAssessment S1 = PAS.GetByID(model.ID);
                
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

                return RedirectToAction("index");
            }
            catch
            {
                return View(model);
            }
        }

       
    }
}
