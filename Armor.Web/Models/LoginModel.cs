using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Armor.Web.Models {
    public class LoginModel {
        [Required]
        public string EmailAddress { get; set; }
        
        [Required]
        public string Password { get; set; }

        [DisplayName("Remember me?")]
        public bool RememberMe { get; set; }
    }
}