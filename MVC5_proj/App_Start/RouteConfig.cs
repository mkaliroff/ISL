using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC5_proj
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.config");

            routes.MapRoute(
                name: "Request",
                url: "User/Request",
                defaults: new { controller = "User", action = "Request", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Register",
                url: "Home/Register",
                defaults: new { controller = "Home", action = "Register", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "AddUser",
                url: "User/AddUser",
                defaults: new { controller = "User", action = "AddUser", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Profile",
                url: "Home/MyProfile",
                defaults: new { controller = "Home", action = "MyProfile", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "SignIn",
                url: "User/SignIn",
                defaults: new { controller = "User", action = "SignIn", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Login",
                url: "Home/Login",
                defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Logout",
                url: "User/Logout",
                defaults: new { controller = "User", action = "Logout", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "SendIT",
                url: "User/SendIT",
                defaults: new { controller = "User", action = "SendIT", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "FAQ",
                url: "Home/FAQ",
                defaults: new { controller = "Home", action = "FAQ", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "IT",
                url: "Home/ShowMyIT",
                defaults: new { controller = "Home", action = "ShowMyIT", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ShowData",
                url: "User/ShowMyTestDB",
                defaults: new { controller = "Home", action = "ShowMyTestDB", id = UrlParameter.Optional }
                        );

            routes.MapRoute(
                name: "Share",
                url: "User/Share",
                defaults: new { controller = "User", action = "Share", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ShowMyCollection",
                url: "Home/ShowMyCollection",
                defaults: new { controller = "Home", action = "ShowMyCollection", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ShowAbout",
                url: "Home/ShowAbout",
                defaults: new { controller = "Home", action = "ShowAbout", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ShowContact",
                url: "Home/ShowContact",
                defaults: new { controller = "Home", action = "ShowContact", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Send",
                url: "User/Send",
                defaults: new { controller = "User", action = "Send", id = UrlParameter.Optional }
            );


            routes.MapRoute(
                name: "Home",
                url: "Home/ShowHomePage",
                defaults: new { controller = "Home", action = "ShowHomePage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "",
                defaults: new { controller = "Home", action = "ShowHomePage", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "MyProfilePrimary",
                url: "User/MyProfilePrimary",
                defaults: new { controller = "User", action = "MyProfilePrimary", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "MyProfileSecondary",
                url: "User/MyProfileSecondary",
                defaults: new { controller = "User", action = "MyProfileSecondary", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "MyProfileSuccess",
                url: "User/MyProfileSuccess",
                defaults: new { controller = "User", action = "MyProfileSuccess", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "MyProfileDanger",
                url: "User/MyProfileDanger",
                defaults: new { controller = "User", action = "MyProfileDanger", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "MyProfileWarning",
                url: "User/MyProfileWarning",
                defaults: new { controller = "User", action = "MyProfileWarning", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "MyProfileInfo",
                url: "User/MyProfileInfo",
                defaults: new { controller = "User", action = "MyProfileInfo", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "MyProfileDark",
                url: "User/MyProfileDark",
                defaults: new { controller = "User", action = "MyProfileDark", id = UrlParameter.Optional }
            );
        }
    }
}
