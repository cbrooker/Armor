using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web.Mvc;
using DataAnnotationsExtensions;
using System.ComponentModel.DataAnnotations;

namespace Armor.Web.Models
{
    public class AccountModel
    {
        [Required]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last name")]
        public string LastName { get; set; }

        [Required]
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
        public int Province { get; set; }
        public IEnumerable<SelectListItem> Provinces { get; set; }

        [Required]
        public string PostalCode { get; set; }


        public string GSTInformation { get; set; }

    }
}