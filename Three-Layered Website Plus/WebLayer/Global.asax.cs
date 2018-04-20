using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using $ext_safeprojectname$.Common.IOC;

namespace $safeprojectname$
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            IoCSetup.Now();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            $if$ ($ext_HTTPS$ == true)GlobalFilters.Filters.Add(new RequireHttpsAttribute());
            $endif$
        }

        protected void Application_PreSendRequestHeaders()
        {
            Response.Headers.Remove("Server");
            Response.Headers.Remove("X-AspNetMvc-Version");
            $if$ ($ext_HTTPS$ == true)Response.Headers.Add("Strict-Transport-Security", "max-age=31536000");
            $endif$
        }
    }
}