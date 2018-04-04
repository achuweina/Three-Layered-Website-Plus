using System.Web.Mvc;
using System.Web.Routing;

namespace $safeprojectname$
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapRoute("Default", "{controller}/{action}/{id}",
                new {controller = "Home", action = "Index", id = UrlParameter.Optional});
            routes.MapRoute("NotFound", "test.txt");
        }
    }
}