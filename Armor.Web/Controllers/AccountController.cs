﻿using System;
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
        public ActionResult _AccountPanel()
        {
            //LogOnPartialModel model = new LogOnPartialModel { UserLoggedIn = CurrentUserID != Guid.Empty ? true : false };
            //if (CurrentUser != null)
            //{
            //    model.user = CurrentUser;
            //}
            //model.CurrentUserRole = CurrentUserRole;

            return PartialView("_AccountPanel");
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


    }
}
