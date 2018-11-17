using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace FlowerShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapRoute(
                      name: "Home",
                      url: "{controller}/{action}/{id}",
                      namespaces: new[] { "FlowerShop.Controllers" },
                      defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                      //defaults: new { controller = "Category", action = "Get", id = UrlParameter.Optional }
                      //defaults: new { controller = "Discount", action = "Get", id = UrlParameter.Optional }
                      //defaults: new { controller = "Image", action = "Get", id = UrlParameter.Optional }
                      //defaults: new { controller = "Order", action = "Get", id = UrlParameter.Optional }
                      //defaults: new { controller = "OrderDetail", action = "Get", id = UrlParameter.Optional }
                      //defaults: new { controller = "Product", action = "Get", id = UrlParameter.Optional }
                      //defaults: new { controller = "Role", action = "Get", id = UrlParameter.Optional }
                      //defaults: new { controller = "User", action = "Get", id = UrlParameter.Optional }

                  );
        }
    }
}
