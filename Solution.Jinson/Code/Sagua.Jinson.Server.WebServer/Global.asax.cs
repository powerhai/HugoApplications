using System.Web.Mvc;
using System.Web.Routing;
using Sagua.Jinson.Server.WebControllers;

namespace Sagua.Jinson.Server.WebServer
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
