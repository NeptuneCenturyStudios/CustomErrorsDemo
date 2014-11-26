using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomErrorsDemo.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error/NotFound
        public ActionResult NotFound()
        {
            //return a status code for proper seo
            Response.StatusCode = 404;

            return View();
        }

        // GET: Error/Error
        public ActionResult Error()
        {   
            //in the global.asax.cs code we handle the error. maybe we can send it to an email.

            //return a status code for proper seo
            Response.StatusCode = 500;

            return View();
        }
    }
}