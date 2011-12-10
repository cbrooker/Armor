using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;

namespace Armor.Web.Models {
    public class CreateAccountModel {

        [Required]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        
        public string Password { get; set; }

        [DisplayName("Confirm Password"), Required(ErrorMessage = "Please enter your password again")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        [DataAnnotationsExtensions.Email()]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }


        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Fax { get; set; }

        [Required]
        [DisplayName("Street Address")]
        public string Address { get; set; }

        [Required]
        public string City { get; set; }


        [DisplayName("Province")]
        public IEnumerable<SelectListItem> Provinces { 
            get {
                Dictionary<string, string> Provinces = new Dictionary<string, string>();
                Provinces.Add("Alberta", "Alberta");
                Provinces.Add("British Columbia", "British Columbia");
                Provinces.Add("Manitoba", "Manitoba");
                Provinces.Add("New Brunswick", "New Brunswick");
                Provinces.Add("Newfoundland and Labrador", "Newfoundland and Labrador");
                Provinces.Add("Northwest Territories", "Northwest Territories");
                Provinces.Add("Nova Scotia", "Nova Scotia");
                Provinces.Add("Nunavut", "Nunavut");
                Provinces.Add("Ontario", "Ontario");
                Provinces.Add("Prince Edward Island", "Prince Edward Island");
                Provinces.Add("Quebec", "Québec");
                Provinces.Add("Saskatchewan", "Saskatchewan");
                Provinces.Add("Yukon", "Yukon");

                return Provinces.Select(t => new SelectListItem() { Text = t.Value, Value = t.Key });
            }
        }
        public string Province { get; set; }


        [Required]
        public string PostalCode { get; set; }


        public string GSTInformation { get; set; }

    }
}