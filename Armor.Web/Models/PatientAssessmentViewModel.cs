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
                AnswerModel model = new AnswerModel() { Text = "Female", Value = "Female" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Male", Value = "Male" };
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
                AnswerModel model = new AnswerModel() { Text = "Cervical", Value = "Cervical" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Dorsal", Value = "Dorsal" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Lumbar", Value = "Lumbar" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Hand", Value = "Hand" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Hip", Value = "Hip" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Knee", Value = "Knee" };
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
                AnswerModel model = new AnswerModel() { Text = "Yes", Value = "Yes" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "No", Value = "No" };
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
                AnswerModel model = new AnswerModel() { Text = "Active smoker", Value = "Active smoker" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Ex-smoker (within the past 10 years)", Value = "Ex-smoker (within the past 10 years)" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Non-smoker", Value = "Non-smoker" };
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
                AnswerModel model = new AnswerModel() { Text = "Yes", Value = "Yes" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "No", Value = "No" };
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
                AnswerModel model = new AnswerModel() { Text = "Uncomplicated peptic ulcer", Value = "Uncomplicated peptic ulcer" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Dyspepsia", Value = "Dyspepsia" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "GERD", Value = "GERD" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Bleeding peptic ulcer", Value = "Bleeding peptic ulcer" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "H pylori infection treated", Value = "H pylori infection treated" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "H pylori infection untreated", Value = "H pylori infection untreated" };
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
                AnswerModel model = new AnswerModel() { Text = "Misoprostol", Value = "Misoprostol" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Proton pump inhibitor (eg, omeprazole, pantoprazole)", Value = "Proton pump inhibitor (eg, omeprazole, pantoprazole)" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "H2 receptor antagonist (eg, cimetadine, ranitidine)", Value = "H2 receptor antagonist (eg, cimetadine, ranitidine)" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Low-dose ASA (<300 mg/day)", Value = "Low-dose ASA (<300 mg/day)" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Selective serotonin reuptake inhibitor (eg, citalopram, paroxetine)", Value = "Selective serotonin reuptake inhibitor (eg, citalopram, paroxetine)" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Anticoagulant (eg, warfarin)", Value = "Anticoagulant (eg, warfarin)" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Corticosteroid (eg, prednisone)", Value = "Corticosteroid (eg, prednisone)" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Antiplatelet medication", Value = "Antiplatelet medication" };
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
                AnswerModel model = new AnswerModel() { Text = "Low", Value = "Low" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Moderate", Value = "Moderate" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "High", Value = "High" };
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




