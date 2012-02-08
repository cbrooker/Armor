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
                Provinces.Add(ViewRes.Account.Registration.Alberta, ViewRes.Account.Registration.Alberta);
                Provinces.Add(ViewRes.Account.Registration.BritishColumbia, ViewRes.Account.Registration.BritishColumbia);
                Provinces.Add(ViewRes.Account.Registration.Manitoba, ViewRes.Account.Registration.Manitoba);
                Provinces.Add(ViewRes.Account.Registration.NewBrunswick, ViewRes.Account.Registration.NewBrunswick);
                Provinces.Add(ViewRes.Account.Registration.NewfoundlandLabrador, ViewRes.Account.Registration.NewfoundlandLabrador);
                Provinces.Add(ViewRes.Account.Registration.NorthwestTerritories, ViewRes.Account.Registration.NorthwestTerritories);
                Provinces.Add(ViewRes.Account.Registration.NovaScotia, ViewRes.Account.Registration.NovaScotia);
                Provinces.Add(ViewRes.Account.Registration.Nunavut, ViewRes.Account.Registration.Nunavut);
                Provinces.Add(ViewRes.Account.Registration.Ontario, ViewRes.Account.Registration.Ontario);
                Provinces.Add(ViewRes.Account.Registration.PrinceEdwardIsland, ViewRes.Account.Registration.PrinceEdwardIsland);
                Provinces.Add(ViewRes.Account.Registration.Quebec, ViewRes.Account.Registration.Quebec);
                Provinces.Add(ViewRes.Account.Registration.Saskatchewan, ViewRes.Account.Registration.Saskatchewan);
                Provinces.Add(ViewRes.Account.Registration.Yukon, ViewRes.Account.Registration.Yukon);

                return Provinces.Select(t => new SelectListItem() { Text = t.Value, Value = t.Key });
            }
        }
        public string Province { get; set; }


        [Required]
        public string PostalCode { get; set; }


        public string GSTInformation { get; set; }

    }
}