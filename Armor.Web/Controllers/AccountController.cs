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
using RichmondDay.Helpers;
using Armor.Web.Core.Email;
using Epilogger.Web.Views.Emails;

namespace Armor.Web.Controllers
{
    public class AccountController : BaseController
    {
        UserService service;

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            if (service == null) service = new UserService();
            base.Initialize(requestContext);
        }


        [ChildActionOnly]
        public ActionResult _LogOnPartial()
        {
            LogOnPartialModel model = new LogOnPartialModel { UserLoggedIn = CurrentUserID != Guid.Empty ? true : false };
            if (CurrentUser != null)
            {
                model.user = CurrentUser;
            }
            model.CurrentUserRole = CurrentUserRole;

            return PartialView("_LogOnPartial", model);
        }


        [ChildActionOnly]
        public ActionResult _SlidingPanel()
        {
            SlidingPanelViewModel model = new SlidingPanelViewModel();
            if (CurrentUser != null)
            {
                model.EditUserModel = Mapper.Map<User, EditAccountViewModel>(CurrentUser);
                return PartialView(model);
            }

            return PartialView(model);
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

                User user = service.GetUserByEmail(model.EmailAddress);
                
                if (user == null)
                {
                    ModelState.AddModelError("", "Login failed");
                    return View(model);
                }

                if (!BCryptHelper.CheckPassword(model.Password, user.Password))
                {
                    ModelState.AddModelError("", "The password you entered does not match the password for your account");
                    return View(model);
                }

                if (user.IsActive == false)
                {
                    ModelState.AddModelError("", "Your account has not been activated yet, please click the link in the verification email that was sent to you.");
                    return RedirectToAction("login");
                }

                 
                // write the login cookie, redirect. 
                if (model.RememberMe)
                {
                    CookieHelpers.WriteCookie("Amorlc", "uid", user.ID.ToString(), DateTime.Now.AddDays(30));
                }
                else
                {
                    CookieHelpers.WriteCookie("Amorlc", "uid", user.ID.ToString());
                }

                if (TempData["returnUrl"] != null)
                    return Redirect(TempData["returnUrl"].ToString());


                return RedirectToAction("index", "home");
            }

            return View(model);
        }


        //
        // GET: /Account/LogOff

        public ActionResult LogOff()
        {
            RichmondDay.Helpers.CookieHelpers.DestroyCookie("Amorlc");
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
                    //Armor.Data.User user = Mapper.Map<CreateAccountModel, Armor.Data.User>(model);

                    User Newuser = new User();

                    Newuser.Address = model.Address;
                    Newuser.City = model.City;
                    Newuser.CreatedDate = DateTime.UtcNow;
                    Newuser.EmailAddress = model.EmailAddress;
                    Newuser.FaxNumber = model.Fax;
                    Newuser.FirstName = model.FirstName;
                    Newuser.ForgotPasswordHash = new Guid();
                    Newuser.GSTInformation = model.GSTInformation;
                    Newuser.IsActive = true;
                    Newuser.LastName = model.LastName;
                    Newuser.Password = PasswordHelpers.EncryptPassword(model.Password);
                    Newuser.PhoneNumber = model.Phone;
                    Newuser.PostalCode = model.PostalCode;
                    Newuser.Province = model.Province;
                    Newuser.RoleID = 2;
                    
                    service.Save(Newuser);


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
                    ModelState.AddModelError("", "There was a problem creating your account");
                    return View(model);
                }
            }
            else
                return View(model);
        }


        [HttpPost]
        public ActionResult Edit(EditAccountViewModel model)
        {
            
                try
                {
                    User Theuser = service.GetUserByID(CurrentUserID);

                    Theuser.FirstName = model.FirstName;
                    Theuser.LastName = model.LastName;
                    Theuser.Address = model.Address;
                    Theuser.City = model.City;
                    Theuser.EmailAddress = model.EmailAddress;
                    Theuser.FaxNumber = model.FaxNumber;
                    Theuser.GSTInformation = model.GSTInformation;
                    Theuser.PhoneNumber = model.PhoneNumber;
                    Theuser.PostalCode = model.PostalCode;
                    Theuser.Province = model.Province;

                    service.Save(Theuser);
                    model = Mapper.Map<User, EditAccountViewModel>(Theuser);
                    return RedirectToAction("Index", "Assessment");
                }
                catch (Exception)
                {
                    ModelState.AddModelError("", "There was a problem creating your account");
                    return PartialView(model);
                }
           

        }


        [HttpGet]
        public ActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult ForgotPassword(ForgotPasswordViewModel model)
        {
            try
            {
                Guid passwordResetHash = Guid.NewGuid();
                User user = service.GetUserByEmail(model.EmailAddress.Trim());
                if (user == null)
                {
                    ModelState.AddModelError("", "There is no account that uses that email address");
                    return View();
                }

                user.ForgotPasswordHash = passwordResetHash;
                service.Save(user);

                string resetPasswordUrl = string.Format("{0}account/resetpassword?hash={1}", App.BaseUrl, passwordResetHash);

                //TODO: When I get content
                TemplateParser parser = new TemplateParser();
                Dictionary<string, string> replacements = new Dictionary<string, string>();
                replacements.Add("[BASE_URL]", App.BaseUrl);
                replacements.Add("[EMAILADDRESS]", user.EmailAddress);
                replacements.Add("[USER_EMAIL]", user.EmailAddress);
                replacements.Add("[RESET_PASSWORD_URL]", resetPasswordUrl);

                string message = parser.Replace(AccountEmails.ForgotPassword, replacements);

                EmailSender sender = new EmailSender();
                sender.Send(App.MailConfiguration, model.EmailAddress, "", "Reset your password on epilogger.com", message);

                //this.StoreSuccess("We\\'ve emailed you instructions on how to reset your password.");
            }
            catch (Exception ex)
            {
                //this.StoreError("There was a problem sending you instructions to reset your password");
            }

            return View();
        }


        [HttpGet]
        public ActionResult ResetPassword()
        {
            Guid passwordResetHash = Guid.Parse(Request.QueryString["hash"].ToString());
            User user = service.GetUserByResetHash(passwordResetHash);
            if (user == null)
            {
                //this.StoreWarning("Something isn't right, the user didn't request this action?");
                return View();
            }

            ResetPasswordViewModel model = new ResetPasswordViewModel();
            model.UserID = user.ID.ToString();

            return View(model);
        }

        [HttpPost, ValidateInput(false)]
        public ActionResult ResetPassword(ResetPasswordViewModel model)
        {
            try
            {
                User user = service.GetUserByID(Guid.Parse(model.UserID));
                user.Password = PasswordHelpers.EncryptPassword(model.NewPassword);
                user.ForgotPasswordHash = null;

                service.Save(user);

                //this.StoreSuccess("Your password has been updated, you can now login!");

                return RedirectToAction("login");
            }
            catch (Exception ex)
            {
                //this.StoreError("There was a problem updating your password");
                return View();
            }
        }

    }
}
