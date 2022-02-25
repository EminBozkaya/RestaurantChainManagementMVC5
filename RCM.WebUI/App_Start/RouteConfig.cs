using System.Web.Mvc;
using System.Web.Routing;

namespace RCM.WebUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional },
                namespaces: new string[] { "RCM.MvcWebUI.Controllers" }
            );

            //routes.MapRoute(
            //    name: "UserProfile",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "DashBoard", action = "GetActiveUserInfo", id = UrlParameter.Optional },
            //    namespaces: new string[] { "RCM.MvcWebUI.Controllers" }
            //);
        }
    }
}
