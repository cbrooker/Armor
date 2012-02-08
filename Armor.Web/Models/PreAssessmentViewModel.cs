using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Armor.Web.Core.Filters;
using ViewRes;

namespace Armor.Web.Models
{
    public class PreAssessmentViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        //[DisplayName("1. What percentage of patients in your practice have OA?")]
        //[LocalizedDisplayName("Question1", NameResourceType = typeof(PreAssessment))]
        public String Question1 { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        [DisplayName("2. What percentage of your patients with OA are taking an NSAID?")]
        public String Question2 { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        [DisplayName("3. What percentage of these patients are older than 60 years of age?")]
        public String Question3 { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        [DisplayName("4. What percentage of these patients are overweight?")]
        public String Question4 { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        [DisplayName("5. What percentage of these patients are:")]
        public String Question5ActiveSmoker { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        public String Question5ExSmoker { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        public String Question5NonSmoker { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        [DisplayName("6. What percentage of these patients are taking low-dose ASA (<300 mg/day) for CV protection?")]
        public String Question6 { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        [DisplayName("7. What percentage of these patients are taking a corticosteroid?")]
        public String Question7 { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        [DisplayName("8. What percentage of these patients are taking an anticoagulant medication?")]
        public String Question8 { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        [DisplayName("9. What percentage of these patients have a history of:")]
        public String Question9UncomplicatedPepticUlcer { get; set; }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        public String Question9GERD { get; set; }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        public String Question9Dyspepsia { get; set; }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        public String Question9BleedingPepticUlcer { get; set; }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        public String Question9HpyloriInfection { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        [DisplayName("10. What percentage of these patients have OA in the following sites (% does not need to add up to 100% as patients may have OA in more than one site):")]
        public String Question10Cervical { get; set; }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        public String Question10Dorsal { get; set; }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        public String Question10Lumbar { get; set; }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        public String Question10Hand { get; set; }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        public String Question10Hip { get; set; }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        public String Question10Knee { get; set; }

        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        [DisplayName("11. What percentage of this patients would you categorize as being at low, moderate, and high risk of GI complications with NSAID use? (Percentages should add up to 100%):")]
        public String Question11Low { get; set; }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        public String Question11Moderate { get; set; }
        [Required(ErrorMessageResourceType = typeof(ViewRes.SharedString), ErrorMessageResourceName = "Required")]
        [Range(0, 100)]
        public String Question11High { get; set; }

        //Big Question - Has to be done in HTML
        [DisplayName("12. Which medications do you typically prescribe for these patients in the following GI risk categories (select all that apply):")]
        public String Question12 { get; set; }
        
    }
}
