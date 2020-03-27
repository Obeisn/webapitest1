using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace webapitest1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //routes.RouteExistingFiles = false;
            //routes.MapRoute(
            // name: "Default2",
            // url: "{id}/{*pathInfo}",
            // defaults: new { controller = "Home", action = "GoHtml", id = UrlParameter.Optional }
            //);


            routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api2/{controller}/{action}"      
            );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            
        }
    }
}
