using FormProcessing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormProcessing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Login l)
        {
            return View(l);
        }
    }
}