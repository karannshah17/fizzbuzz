// <copyright file="RouteConfig.cs" company="Fizz Buzz">
// Copyright (c) Fizz Buzz. All rights reserved.
// </copyright>

namespace FizzBuzz.Web
{
    using System.Web.Mvc;
    using System.Web.Routing;

    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "FizzBuzz", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
