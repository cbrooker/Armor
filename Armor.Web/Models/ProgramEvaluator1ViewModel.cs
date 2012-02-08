using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Armor.Web.Models

{
    public class ProgramEvaluator1ViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("1. The LOGICA study (Lanas et al 2010)")]
        public int Question1 { get; set; }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("2. Screening for GI risk factors in patients with OA")]
        public int Question2 { get; set; }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("3. Treatment options for patients with OA who are at increased risk of GI adverse events associated with NSAID use")]
        public int Question3 { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("4. Age 60 years or older")]
        public int Question4 { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("5. History of dyspepsia")]
        public int Question5 { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("6. High NSAID dose")]
        public int Question6 { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("7. Concomitant use of ASA")]
        public int Question7 { get; set; }


        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("8. History of uncomplicated peptic ulcer")]
        public int Question8 { get; set; }


        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("9. Concomitant use of corticosteroids")]
        public int Question9 { get; set; }


        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("10. Concomitant use of oral anticoagulants")]
        public int Question10 { get; set; }


        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("11. History of bleeding peptic ulcer")]
        public int Question11 { get; set; }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("12. In the LOGICA study, what percentage of 3,293 patients were at increased risk of experiencing a GI adverse event with NSAID use?")]
        public List<AnswerModel> Question12 {
            get 
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = "22%", Value = "22" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "44%", Value = "44" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "87%", Value = "87" };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question12DontKnow, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question12DontKnow };
                TheList.Add(model);
                return TheList;
            }
        }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("13. What was the most common GI risk factor in the LOGICA study?")]
        public List<AnswerModel> Question13
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question131, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question131 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question132, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question132 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question133, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question133 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question134, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question134 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question135, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question135 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question136, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question136 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question137, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question137 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question138, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question138 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question139, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question139 };
                TheList.Add(model);
                return TheList;
            }
        }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("14. What is your preferred treatment strategy for patients with OA who do not respond to acetaminophen and are at <span class='underline'>moderate</span> risk of GI adverse events with NSAIDs?")]
        public List<AnswerModel> Question14
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question141, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question141 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question142, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question142 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question143, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question143 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question144, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question144 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question145, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question145 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question146, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question147 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question147, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question147 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question148, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question148 };
                TheList.Add(model);
                return TheList;
            }
        }
        public String Question14Other { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")] 
        [DisplayName("15. What is your preferred treatment strategy for patients with OA who do not respond to acetaminophen and are at <span class'underline'>high</span> risk of GI adverse events with NSAIDs?")]
        public List<AnswerModel> Question15
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question151, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question151 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question152, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question152 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question153, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question153 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question154, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question154 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question155, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question155 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question156, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question156 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question157, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question157 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question158, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question158 };
                TheList.Add(model);
                return TheList;
            }
        }
        public String Question15Other { get; set; }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("16. Gary is a 65-year-old man with osteoarthritis that was diagnosed 6 months ago. He has a history of uncomplicated peptic ulcer. Based on this information, how would you classify Gary’s risk of experiencing a GI adverse event with NSAIDs?")]
        public List<AnswerModel> Question16
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question161, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question161 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question162, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question162 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question163, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question163 };
                TheList.Add(model);
                return TheList;
            }
        }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("17. Mary is a 40-year-old woman with recently diagnosed OA and a history of dyspepsia. She has been taking acetaminophen 1,000 mg tid but her pain is still interfering with her daily activities. The only other medication that she takes regularly is fluticasone for asthma. How would you manage Mary’s ongoing OA pain? (Select all that apply)")]
        public List<AnswerModel> Question17
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question171, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question171 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question172, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question173 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question173, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question173 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question174, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question174 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question175, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question175 };
                TheList.Add(model);
                return TheList;
            }
        }
        public String Question17Other { get; set; }


        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("18. Karen is a 40-year-old woman with OA that has been well managed with diclofenac 150 mg/day for the past three years. She recently experienced a DVT secondary to oral contraceptives and is taking daily warfarin. What change would you make to Karen’s pain medication?")]
        public List<AnswerModel> Question18
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question181, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question181 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question182, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question182 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question183, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question184 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question184, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question184 };
                TheList.Add(model);
                model = new AnswerModel() { Text = ViewRes.Assessment.ProgramEvaluatorStage1.Question185, Value = ViewRes.Assessment.ProgramEvaluatorStage1.Question185 };
                TheList.Add(model);
                return TheList;
            }
        }
        public String Question18Other { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("19. For what % of your patients for whom you are prescribing NSAIDS do you take GI risk factors into considerations?")]
		public String Question19 { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [DisplayName("20. What percentage of your patients with the following criteria would you categorize as being at low, moderate, and high risk of GI complications with NSAID use? (Percentages should add up to 100%)")]
        public String Question20Low { get; set; }
        public String Question20Moderate { get; set; }
        public String Question20High { get; set; }
        
        
    }
}