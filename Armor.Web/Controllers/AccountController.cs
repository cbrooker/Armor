using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using Armor.Web.Models;
using Armor.Data;
using DevOne.Security.Cryptography.BCrypt;
using AutoMapper;

namespace Armor.Web.Controllers
{
    public class AccountController : Controller
    {
        UserService service;

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            if (service == null) service = new UserService();
            base.Initialize(requestContext);
        }


        public ActionResult Login()
        {
            // store this here so that we can redirect the user back later.
            if (Request.QueryString["returnUrl"] != null)
                TempData["returnUrl"] = Request.QueryString["returnUrl"];

            return View(new LoginModel());
        }


        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {

                User user = service.GetUserByUsername(model.Username);

                // the user is a valid user but they need to update there password.
                if (user != null && user.Password == string.Empty)
                {
                    //CookieHelpers.WriteCookie("lc", "uid", user.ID.ToString());
                    return RedirectToAction("UpdatePassword");
                }

                user = service.GetUserByUsername(model.Username);
                if (!BCryptHelper.CheckPassword(model.Password, user.Password))
                {
                    //this.StoreError("The password you entered does not match the password for your account");
                    return View(model);
                }

                if (user.IsActive == false)
                {
                    //this.StoreError("Your account has not been activated yet, please click the link in the verification email that was sent to you.");
                    return RedirectToAction("login");
                }

                if (user == null)
                {
                    //this.StoreError("Login failed");
                    return View(model);
                }

                // write the login cookie, redirect. 
                if (model.RememberMe)
                {
                    //CookieHelpers.WriteCookie("lc", "uid", user.ID.ToString(), DateTime.Now.AddDays(30));
                    //CookieHelpers.WriteCookie("lc", "tz", user.TimeZoneOffSet.ToString(), DateTime.Now.AddDays(30));
                }
                else
                {
                    //CookieHelpers.WriteCookie("lc", "uid", user.ID.ToString());
                    //CookieHelpers.WriteCookie("lc", "tz", user.TimeZoneOffSet.ToString());
                }

                //if (TempData["returnUrl"] != null)
                //    return Redirect(TempData["returnUrl"].ToString());

                return RedirectToAction("index", "home");
            }

            return View(model);
        }


        //
        // GET: /Account/LogOff

        public ActionResult LogOff()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View(new CreateAccountModel());
        }

        [HttpPost]
        public ActionResult Create(CreateAccountModel model)
        {
            if (ModelState.IsValid)
            {
                
                try
                {
                    User user = Mapper.Map<CreateAccountModel, User>(model);
                    user.IsActive = false; // ensure this is set.
                    service.Save(user);

                    // build a message to send to the user.
                    //string validateUrl = string.Format("{0}account/validate/{1}", App.BaseUrl, Helpers.base64Encode(user.EmailAddress));

                    //TemplateParser parser = new TemplateParser();
                    //Dictionary<string, string> replacements = new Dictionary<string, string>();
                    //replacements.Add("[BASE_URL]", App.BaseUrl);
                    //replacements.Add("[FIRST_NAME]", user.EmailAddress);
                    //replacements.Add("[VALIDATE_ACCOUNT_URL]", validateUrl);

                    //string message = parser.Replace(AccountEmails.ValidateAccount, replacements);

                    //EmailSender sender = new EmailSender();
                    //sender.Send(App.MailConfiguration, model.EmailAddress, "", "Thank you for registering on epilogger.com", message);

                    //this.StoreSuccess("Your account was created successfully<br /><br/>Please check your inbox for our validation message, your account will be inaccessable until you validate it.");

                    return RedirectToAction("login", "account");
                }
                catch (Exception ex)
                {
                    //this.StoreError("There was a problem creating your account");
                    return View(model);
                }
            }
            else
                return View(model);
        }


    }
}
