using System.ComponentModel;

namespace Armor.Web.Models
{
    public class ForgotPasswordViewModel
    {
        [DisplayName("Email address")]
        public string EmailAddress { get; set; }
    }
}