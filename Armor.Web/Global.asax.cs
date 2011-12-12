using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using Armor.Web.Models;
using Armor.Data;
using Armor.Web.Core.Email;
using System.Configuration;

namespace Armor.Web
{
    public class App : System.Web.HttpApplication
    {
        /// <summary>
        /// The application's base url (eg: http://www.example.com, http://localhost:21215/)
        /// </summary>
        public static string BaseUrl
        {
            get
            {
                string url = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + VirtualPathUtility.ToAbsolute("~/");
                var httpContext = HttpContext.Current;

                var uriBuilder = new UriBuilder
                {
                    Host = httpContext.Request.Url.Host,
                    Path = "/",
                    Port = 80,
                    Scheme = "http",
                };

                if (httpContext.Request.IsLocal)
                {
                    uriBuilder.Port = httpContext.Request.Url.Port;
                }

                return new Uri(uriBuilder.Uri, VirtualPathUtility.ToAbsolute("~/")).AbsoluteUri;
            }
        }

        public static SmtpConfiguration MailConfiguration
        {
            get
            {
                return new SmtpConfiguration()
                {
                    Server = ConfigurationManager.AppSettings["SiteSettings.Mail.Server"] as string ?? "",
                    Port = int.Parse(ConfigurationManager.AppSettings["SiteSettings.Mail.ServerPort"] as string),
                    Username = ConfigurationManager.AppSettings["SiteSettings.Mail.Username"] as string ?? "",
                    Password = ConfigurationManager.AppSettings["SiteSettings.Mail.Password"] as string ?? "",
                    DefaultFromAddress = ConfigurationManager.AppSettings["SiteSettings.Mail.DefaultFromAddress"] as string ?? ""
                };
            }
        }
    }



    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }


        private void RegisterAutomapperMappings()
        {

            Mapper.CreateMap<CreateAccountModel, Armor.Data.User>()
                .ForMember(dest => dest.RoleID, opt => opt.UseValue(2))
               
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => PasswordHelpers.EncryptPassword(src.Password)))
                .ForMember(dest => dest.IsActive, opt => opt.UseValue(false))
                .ForMember(dest => dest.CreatedDate, opt => opt.UseValue(DateTime.UtcNow));


             //.ForMember(dest => dest.FirstName, opt => opt.Ignore())
             //   .ForMember(dest => dest.LastName, opt => opt.Ignore())
             //   .ForMember(dest => dest.ForgotPasswordHash, opt => opt.Ignore())
             //   .ForMember(dest => dest.ID, opt => opt.Ignore())
             //   .ForMember(dest => dest.PhoneNumber, opt => opt.Ignore())
             //   .ForMember(dest => dest.PostalCode, opt => opt.Ignore())
             //   .ForMember(dest => dest.Province, opt => opt.Ignore())
             //   .ForMember(dest => dest.EmailAddress, opt => opt.Ignore())
             //   .ForMember(dest => dest.GSTInformation, opt => opt.Ignore())
             //   .ForMember(dest => dest.Address, opt => opt.Ignore())
             //   .ForMember(dest => dest.City, opt => opt.Ignore())

            Mapper.AssertConfigurationIsValid();
        }


    }
}