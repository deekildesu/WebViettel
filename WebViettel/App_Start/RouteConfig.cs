using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebViettel
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
               name: "LienHe",
               url: "lien-he",
               defaults: new { controller = "LienHe", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "SanPham1",
               url: "san-pham1",
               defaults: new { controller = "SanPham1", action = "Index", id = UrlParameter.Optional }
           );
             routes.MapRoute(
               name: "SanPham2",
               url: "san-pham2",
               defaults: new { controller = "SanPham2", action = "Index", id = UrlParameter.Optional }
           );
            routes.MapRoute(
               name: "ShoppingCart",
               url: "shopping-cart",
               defaults: new { controller = "ShoppingCart", action = "Buy", id = UrlParameter.Optional }
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Site", action = "Index", id = UrlParameter.Optional }
            );
            
        }
    }
}
