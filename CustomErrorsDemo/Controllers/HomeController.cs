using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomErrorsDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/BuyStuff
        public ActionResult BuyStuff()
        {
            //do somethingthing... oops, an error
            throw new NotImplementedException("Buy Stuff isn't working");

            //yes i know, this will never execute
            return View();
        }
    }
}