using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Web.Mvc;

namespace Armor.Web.Models
{
    public class ProgramEvaluator1ViewModel
    {

        [DisplayName("1. The LOGICA study (Lanas et al 2010)")]
        public int Question1 { get; set; }
        [DisplayName("2. Screening for GI risk factors in patients with OA")]
        public int Question2 { get; set; }
        [DisplayName("3. Treatment options for patients with OA who are at increased risk of GI adverse events associated with NSAID use")]
        public int Question3 { get; set; }


        [DisplayName("4. Age 60 years or older")]
        public int Question4 { get; set; }
        [DisplayName("5. History of dyspepsia")]
        public int Question5 { get; set; }
        [DisplayName("6. High NSAID dose")]
        public int Question6 { get; set; }
        [DisplayName("7. Concomitant use of ASA")]
        public int Question7 { get; set; }
        [DisplayName("8. History of uncomplicated peptic ulcer")]
        public int Question8 { get; set; }
        [DisplayName("9. Concomitant use of corticosteroids")]
        public int Question9 { get; set; }
        [DisplayName("10. Concomitant use of oral anticoagulants")]
        public int Question10 { get; set; }
        [DisplayName("11. History of bleeding peptic ulcer")]
        public int Question11 { get; set; }

        
        public String Question12 { get; set; }      
        public String Question13 { get; set; }
        public String Question14 { get; set; }
        public String Question14Other { get; set; }
        public String Question15 { get; set; }
        public String Question15Other { get; set; }
        public String Question16 { get; set; }
        public String Question17 { get; set; }
        public String Question17Other { get; set; }
        public String Question18 { get; set; }
        public String Question18Other { get; set; }
        public String Question19 { get; set; }
        public String Question20 { get; set; }
        public String Question20Percent { get; set; }


        
        //public List<QuestionAnswerChoices> Question12
        //{
        //    get
        //    {
        //        QuestionAnswerChoices Question = new QuestionAnswerChoices { Text = "22%", Value = "22" };
        //        Question12.Add(Question);
        //        Question = new QuestionAnswerChoices { Text = "44%", Value = "44" };
        //        Question12.Add(Question);
        //        Question = new QuestionAnswerChoices { Text = "87%", Value = "87" };
        //        Question12.Add(Question);

        //        return Question12;
        //    }
        //}


        //[DisplayName("12. In the LOGICA study, what percentage of 3,293 patients were at increased risk of experiencing a GI adverse event with NSAID use?")]
        //public Dictionary<string, string> Question12
        //{
        //    get
        //    {
        //        Dictionary<string, string> Question12 = new Dictionary<string, string>();
        //        Question12.Add("22", "22%");
        //        Question12.Add("44", "44%");
        //        Question12.Add("87", "87%");

        //        return Question12;
        //    }
        //}
        //public string Question12a { get; set; }


        
    }
}