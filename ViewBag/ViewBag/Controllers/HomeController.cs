using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ViewBag.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(Login l)
        {
            ViewBag.Username = l.UserName;
            ViewBag.Password = l.Password;

            return View(ViewBag);

        }

        public ActionResult Contact()
        {
            return View();
        }
    }
}