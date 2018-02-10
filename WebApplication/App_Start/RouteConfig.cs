using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    "Customers",
            //    "{controller}/{action}",
            //    new { controller = "Customers", action = "Random"}
            //);
            
            //routes.MapRoute(
            //    "Movies",
            //    "{controller}/{action}/{id}",
            //    new { controller = "Movies", action = "Random", id = UrlParameter.Optional },
            //    new { id = @"1|2" }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
