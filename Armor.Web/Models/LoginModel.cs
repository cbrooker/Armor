using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Armor.Web.Core.Filters;
using ViewRes.Account;

namespace Armor.Web.Models {
    public class LoginModel {
        [Required]
        //[DisplayName("Email Address")]
        [LocalizedDisplayName("EmailAddress", NameResourceType = typeof(Login))]
        public string EmailAddress { get; set; }
        
        [Required]
        [LocalizedDisplayName("Password", NameResourceType = typeof(Login))]
        public string Password { get; set; }

        //[DisplayName("Remember me?")]
        [LocalizedDisplayName("RememberMe", NameResourceType = typeof(Login))]
        public bool RememberMe { get; set; }
    }
}