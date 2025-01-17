﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CarRentalService
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // Dodanie wlasnego routa:
            // Sprawdzic Web.config -> znaczniki : system.webServer - > runAllManagedModulesForAllRequests="true"
            routes.MapRoute(
                name: "Auta",
                url: "auta/{categoryName}.html",
                defaults: new { controller = "Cars", action = "List" }
                );
            routes.MapRoute(
                name: "Details",
                url: "details_{id}.html",
                defaults: new { controller = "Cars", action = "Details" }
                );
            routes.MapRoute(
                name: "StronyStatyczne",
                url: "stopka/{nazwa}",
                defaults: new { controller = "Home", action = "StronyStatyczne" });
            //nazwa kontrolera (w tym wypadku HomeController),  nazwa metody akcji, tutaj:StronyStatyczne
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
