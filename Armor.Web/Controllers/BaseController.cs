using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Armor.Data;
using RichmondDay.Helpers;

namespace Armor.Web.Controllers
{
    public class BaseController : Controller
    {
        protected Guid CurrentUserID
        {
            get
            {
                Guid userId = new Guid();
                if (CookieHelpers.GetCookieValue("Amorlc", "uid") != null)
                {
                    Guid.TryParse(CookieHelpers.GetCookieValue("Amorlc", "uid").ToString(), out userId);
                }
                return userId;
            }
        }

        public User CurrentUser
        {
            get
            {
                UserService service = new UserService();
                return service.GetUserByID(CurrentUserID);
            }
        }

        protected UserAuthenticationProfile CurrentUserTwitterAuthorization
        {
            get
            {
                return CurrentUser.UserAuthenticationProfiles.Where(ua => ua.Service == AuthenticationServices.TWITTER.ToString()).FirstOrDefault();
            }
        }

        protected UserAuthenticationProfile CurrentUserFacebookAuthorization
        {
            get
            {
                return CurrentUser.UserAuthenticationProfiles.Where(ua => ua.Service == AuthenticationServices.FACEBOOK.ToString()).FirstOrDefault();
            }
        }

        protected UserRoleType CurrentUserRole
        {
            get
            {
                if (CurrentUser == null)
                    return UserRoleType.Unknown;

                return (UserRoleType)Enum.Parse(typeof(UserRoleType), CurrentUser.RoleID.ToString());
            }
        }

    }
}
