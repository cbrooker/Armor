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
                return TheList;
            }
        }

        [DisplayName("13. What was the most common GI risk factor in the LOGICA study?")]
        public List<AnswerModel> Question13
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = "Age 60 years or older", Value = "Age 60 years or older" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "History of dyspepsia", Value = "History of dyspepsia" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "High NSAID dose", Value = "High NSAID dose" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Concomitant use of ASA", Value = "Concomitant use of ASA" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "History of uncomplicated peptic ulcer", Value = "History of uncomplicated peptic ulcer" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Concomitant use of corticosteroids", Value = "Concomitant use of corticosteroids" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Concomitant use of oral anticoagulants", Value = "Concomitant use of oral anticoagulants" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "History of bleeding peptic ulcer", Value = "History of bleeding peptic ulcer" };
                TheList.Add(model);
                return TheList;
            }
        }

        [DisplayName("14. What is your preferred treatment strategy for patients with OA who do not respond to acetaminophen and are at <span class='underline'>moderate</span> risk of GI adverse events with NSAIDs?")]
        public List<AnswerModel> Question14
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = "Traditional NSAID + misoprostol", Value = "Traditional NSAID + misoprostol" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Traditional NSAID + ranitidine", Value = "Traditional NSAID + ranitidine" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Traditional NSAID + omeprazole", Value = "Traditional NSAID + omeprazole" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Coxib + misoprostol", Value = "Coxib + misoprostol" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Coxib + ranitidine", Value = "Coxib + ranitidine" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Coxib + omeprazole", Value = "Coxib + omeprazole" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Other (please specify)", Value = "Other (please specify)" };
                TheList.Add(model);
                return TheList;
            }
        }
        public String Question14Other { get; set; }

                
        [DisplayName("15. What is your preferred treatment strategy for patients with OA who do not respond to acetaminophen and are at <span class'underline'>high</span> risk of GI adverse events with NSAIDs?")]
        public List<AnswerModel> Question15
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = "Traditional NSAID + misoprostol", Value = "Traditional NSAID + misoprostol" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Traditional NSAID + ranitidine", Value = "Traditional NSAID + ranitidine" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Traditional NSAID + omeprazole", Value = "Traditional NSAID + omeprazole" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Coxib + misoprostol", Value = "Coxib + misoprostol" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Coxib + ranitidine", Value = "Coxib + ranitidine" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Coxib + omeprazole", Value = "Coxib + omeprazole" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Other (please specify)", Value = "Other (please specify)" };
                TheList.Add(model);
                return TheList;
            }
        }
        public String Question15Other { get; set; }

        [DisplayName("16. Gary is a 65-year-old man with osteoarthritis that was diagnosed 6 months ago. He has a history of uncomplicated peptic ulcer. Based on this information, how would you classify Gary’s risk of experiencing a GI adverse event with NSAIDs?")]
        public List<AnswerModel> Question16
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = "Low", Value = "Low" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Medium", Value = "Medium" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "High", Value = "High" };
                TheList.Add(model);
                return TheList;
            }
        }

        [DisplayName("17. Mary is a 40-year-old woman with recently diagnosed OA and a history of dyspepsia. She has been taking acetaminophen 1,000 mg tid but her pain is still interfering with her daily activities. The only other medication that she takes regularly is fluticasone for asthma. How would you manage Mary’s ongoing OA pain? (Select all that apply)")]
        public List<AnswerModel> Question17
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = "Increase her dosage of acetaminophen", Value = "Increase her dosage of acetaminophen" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Prescribe a traditional NSAID", Value = "Prescribe a traditional NSAID" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Prescribe a coxib", Value = "Prescribe a coxib" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Prescribe a gastroprotective agent", Value = "Prescribe a gastroprotective agent" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Other (please specify)", Value = "Other (please specify" };
                TheList.Add(model);
                return TheList;
            }
        }
        public String Question17Other { get; set; }



        [DisplayName("18. Karen is a 40-year-old woman with OA that has been well managed with diclofenac 150 mg/day for the past three years. She recently experienced a DVT secondary to oral contraceptives and is taking daily warfarin. What change would you make to Karen’s pain medication?")]
        public List<AnswerModel> Question18
        {
            get
            {
                List<AnswerModel> TheList = new List<AnswerModel>();
                AnswerModel model = new AnswerModel() { Text = "No change", Value = "No change" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Take her off diclofenac and prescribe a coxib", Value = "Take her off diclofenac and prescribe a coxib" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Reduce her dose of diclofenac", Value = "Reduce her dose of diclofenac" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Maintain her current dose of diclofenac and prescribe a gastroprotective agent", Value = "Maintain her current dose of diclofenac and prescribe a gastroprotective agent" };
                TheList.Add(model);
                model = new AnswerModel() { Text = "Other (please specify)", Value = "Other (please specify" };
                TheList.Add(model);
                return TheList;
            }
        }
        public String Question18Other { get; set; }


        [DisplayName("19. Do you take GI risk factors into consideration when prescribing NSAIDs for your patients with OA?")]
        public List<AnswerModel> Question19
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


        [DisplayName("20. What percentage of your patients with the following criteria would you categorize as being at low, moderate, and high risk of GI complications with NSAID use? (Percentages should add up to 100%)")]
        public String Question20Low { get; set; }
        public String Question20Moderate { get; set; }
        public String Question20High { get; set; }
        
        
    }
}