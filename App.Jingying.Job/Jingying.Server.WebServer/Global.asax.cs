using System.Web.Mvc;
using System.Web.Routing;
using Sagua.Server.WebControllers;

namespace Sagua.Server.WebServer
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes); 
            ControllerBuilder.Current.SetControllerFactory(typeof(WebControllerFactory));
              
        }
    }
}
