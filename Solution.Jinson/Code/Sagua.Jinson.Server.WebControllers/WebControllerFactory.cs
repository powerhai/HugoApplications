using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.SessionState;

namespace Sagua.Jinson.Server.WebControllers
{
 
 
	public class WebControllerFactory :  IControllerFactory
	{
  
          private static  System.Collections.Generic.Dictionary<string, Type> Controllers;
        private const string ControllerName = "Controller";

        private static string GetControllerName(string name)
        {
            return name.Substring(0, name.Length - ControllerName.Length);
        }
        static  WebControllerFactory()
        {
            Controllers = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);
            var items = Assembly.GetExecutingAssembly().GetTypes().Where(a => a.Name.EndsWith(ControllerName));
            foreach (var item in items)
            {
                Controllers.Add(GetControllerName(item.Name ),item);
            }
            //CreateTestData();
             
        }
 
        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            Type  controller = null;
            if (!Controllers.TryGetValue(controllerName, out controller))
            {
                throw new HttpException(404, "Sorry , Page was not find.");
            }
            return Activator.CreateInstance(controller) as IController;
        }

        public SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return SessionStateBehavior.Default;
        }

        public void ReleaseController(IController controller)
        {
            if (controller is IDisposable)
            {
                (controller as IDisposable).Dispose();

            }
            controller = null; 
        }
	}
}

