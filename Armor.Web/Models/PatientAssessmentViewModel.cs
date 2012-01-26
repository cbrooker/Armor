using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Armor.Web.Models
{
    public class PatientAssessmentViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("1. Age")]
        public List<AnswerModel> Question1
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = "18 - 40", Value = "18 - 40" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "41 - 50", Value = "41 - 50" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "51 - 60", Value = "51 - 60" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "61 - 65", Value = "61 - 65" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "66 - 70", Value = "66 - 70" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "71 - 75", Value = "71 - 75" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "76 - 80", Value = "76 - 80" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "81 - 85", Value = "81 - 85" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "86 - 90", Value = "86 - 90" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "> 90", Value = "> 90" };
                TheList.Add(model);
                return TheList;
            }
        }

        [Required(ErrorMessage = "Required")]
        [DisplayName("2. Sex")]
        public List<AnswerModel> Question2
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question21, Value = ViewRes.Assessment.PatientAssessment.Question21 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question22, Value = ViewRes.Assessment.PatientAssessment.Question22 };
                TheList.Add(model);
                return TheList;
            }
        }

        [Required(ErrorMessage = "Required")]
        [DisplayName("3. Type of OA (select all that apply)")]
        public List<AnswerModel> Question3
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question31, Value = ViewRes.Assessment.PatientAssessment.Question31 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question32, Value = ViewRes.Assessment.PatientAssessment.Question32 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question33, Value = ViewRes.Assessment.PatientAssessment.Question33 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question34, Value = ViewRes.Assessment.PatientAssessment.Question34 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question35, Value = ViewRes.Assessment.PatientAssessment.Question35};
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question36, Value = ViewRes.Assessment.PatientAssessment.Question36 };
                TheList.Add(model);
                return TheList;
            }
        }



        [Required(ErrorMessage = "Required")]
        [DisplayName("4. Is this patient overweight (ie, BMI >25)")]
        public List<AnswerModel> Question4
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question41, Value = ViewRes.Assessment.PatientAssessment.Question41 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question42, Value = ViewRes.Assessment.PatientAssessment.Question42 };
                TheList.Add(model);
                return TheList;
            }
        }


        [Required(ErrorMessage = "Required")]
        [DisplayName("5. Smoking status")]
        public List<AnswerModel> Question5
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question51, Value = ViewRes.Assessment.PatientAssessment.Question51 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question52, Value = ViewRes.Assessment.PatientAssessment.Question52 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question53, Value = ViewRes.Assessment.PatientAssessment.Question53 };
                TheList.Add(model);
                return TheList;
            }
        }

        [Required(ErrorMessage = "Required")]
        [DisplayName("6. Average number of alcoholic drinks per week")]
        public int Question6 { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("7. Does this patient use illicit/recreational drugs?")]
        public List<AnswerModel> Question7
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question71, Value = ViewRes.Assessment.PatientAssessment.Question71 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question72, Value = ViewRes.Assessment.PatientAssessment.Question72 };
                TheList.Add(model);
                return TheList;
            }
        }

        [Required(ErrorMessage = "Required")]
        [DisplayName("8. History of")]
        public List<AnswerModel> Question8
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question81, Value = ViewRes.Assessment.PatientAssessment.Question81 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question82, Value = ViewRes.Assessment.PatientAssessment.Question82 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question83, Value = ViewRes.Assessment.PatientAssessment.Question83 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question84, Value = ViewRes.Assessment.PatientAssessment.Question84 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question85, Value = ViewRes.Assessment.PatientAssessment.Question85 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question86, Value = ViewRes.Assessment.PatientAssessment.Question86 };
                TheList.Add(model);
                //List<object> TheList = new List<object>();
                //AnswerModel model = new AnswerModel() { Text = "Uncomplicated peptic ulcer", Value = "Uncomplicated peptic ulcer" };
                //TheList.Add(model);
                //model = new AnswerModel() { Text = "Dyspepsia", Value = "Dyspepsia" };
                //TheList.Add(model);
                //model = new AnswerModel() { Text = "GERD", Value = "GERD" };
                //TheList.Add(model);
                //model = new AnswerModel() { Text = "Bleeding peptic ulcer", Value = "Bleeding peptic ulcer" };
                //TheList.Add(model);
                //model = new AnswerModel() { Text = "H pylori infection", Value = "H pylori infection" };
                //TheList.Add(model);
                //Some how add treated or UnTreated
                //List<AnswerModel> treatedlist = new List<AnswerModel>();
                //AnswerModel tr = new AnswerModel() { Text = "Treated", Value = "Treated" };
                //treatedlist.Add(tr);
                //tr = new AnswerModel() { Text = "Untreated", Value = "Untreated" };
                //treatedlist.Add(tr);
                //TheList.Add(treatedlist);

                return TheList;
            }
        }

        //Big Question - Has to be done in HTML
        [Required(ErrorMessage = "Required")]
        [DisplayName("9. Which of the following medication(s) is this patient currently taking to manage their OA symptoms? (Select all that apply)")]
        public int Question9 { get; set; }


        [Required(ErrorMessage = "Required")]
        [DisplayName("10. Which of the following other medication(s) is this patient currently taking? (Select all that apply)")]
        public List<AnswerModel> Question10
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question101, Value = ViewRes.Assessment.PatientAssessment.Question101 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question102, Value = ViewRes.Assessment.PatientAssessment.Question102 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question103, Value = ViewRes.Assessment.PatientAssessment.Question103 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question104, Value = ViewRes.Assessment.PatientAssessment.Question104 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question105, Value = ViewRes.Assessment.PatientAssessment.Question105 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question106, Value = ViewRes.Assessment.PatientAssessment.Question106 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question107, Value = ViewRes.Assessment.PatientAssessment.Question107 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question108, Value = ViewRes.Assessment.PatientAssessment.Question108 };
                TheList.Add(model);
                return TheList;
            }
        }


        [Required(ErrorMessage = "Required")]
        [DisplayName("11. How would you categorize this patient’s GI risk?")]
        public List<AnswerModel> Question11
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question111, Value = ViewRes.Assessment.PatientAssessment.Question111 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question112, Value = ViewRes.Assessment.PatientAssessment.Question112 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.PatientAssessment.Question113, Value = ViewRes.Assessment.PatientAssessment.Question113 };
                TheList.Add(model);
                return TheList;
            }
        }

        //Done Programmatically
        [Required(ErrorMessage = "Required")]
        [DisplayName("12. Your patient’s GI risk")]
        public string Question12 { get; set; }



        //Big Question
        [Required(ErrorMessage = "Required")]
        [DisplayName("13. Knowing this patient’s level of GI risk, what changes will you make to their OA medication(s)? (Check all that apply)")]
        public List<AnswerModel> Question13
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = "No changes", Value = "No changes" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Switch to", Value = "Switch to" };
                TheList.Add(model);
				model = new AnswerModel() { Text = "Add a Gastroprotective Agent", Value = "Add a Gastroprotective Agent" };
				TheList.Add(model);
                return TheList;

            }
        }
        
    }
}




