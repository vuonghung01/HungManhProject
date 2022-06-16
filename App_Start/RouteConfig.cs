﻿using System.Web.Mvc;
using System.Web.Routing;

namespace HungManhProject
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "AboutUs",
                url: "pages/about-us",
                defaults: new { controller = "Pages", action = "AboutUs", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "ReturnPolicy",
                url: "pages/chinh-sach-doi-tra",
                defaults: new { controller = "Pages", action = "ReturnPolicy", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Shop",
                url: "collections/shop",
                defaults: new { controller = "Collections", action = "Shop", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "index",
                url: "index",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "detail",
                url: "products/{id}/{slug}",
                defaults: new { controller = "Products", action = "productDetail", id = UrlParameter.Optional , slug = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
