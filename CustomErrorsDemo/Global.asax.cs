using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace CustomErrorsDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //handle exceptions, send them via email, whatever
            var exception = Server.GetLastError();
        }
    }
}
