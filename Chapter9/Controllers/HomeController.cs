using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Chapter9.Models;

namespace Chapter9.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Map()
        {
            StateDataContext DC = new StateDataContext();
            var states = from s in DC.States select s;

            return View(states);
        }
    }
}
