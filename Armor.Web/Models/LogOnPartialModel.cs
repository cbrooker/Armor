
using Armor.Data;
namespace Armor.Web.Models
{
    public class LogOnPartialModel
    {

        public User user { get; set; }
        public bool UserLoggedIn { get; set; }
        public UserRoleType CurrentUserRole { get; set; }
 
    }
}