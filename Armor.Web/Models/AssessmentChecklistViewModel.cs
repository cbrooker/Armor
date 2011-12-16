using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Armor.Data;

namespace Armor.Web.Models
{
    public enum AssessmentState
    {
        Enabled,
        Disabled,
        Complete
    }

    public class AssessmentChecklistViewModel
    {
        public User user { get; set; }

        public AssessmentState PreAssessmentState { get; set; }
        public AssessmentState ProgramStage1State { get; set; }
        public AssessmentState ProgramStage2State { get; set; }
        public AssessmentState PatientAssessmentState { get; set; }
        public int PatientAssessmentCount { get; set; }
        public AssessmentState ProgramStage3State { get; set; }

    }
}