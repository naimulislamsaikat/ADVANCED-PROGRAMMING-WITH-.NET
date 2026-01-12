using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using ViewBag.Models;

namespace ViewBag.Controllers
{
    public class LoginController : Controller
    {
        // This is an example of using ViewBag to capture form data.
        [HttpGet]
        //public ActionResult Index(string Username, string Password)
        //{
        //    ViewBag.Username = Username;
        //    ViewBag.Password = Password;

        //    return View(ViewBag);
        //}
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection l)
        {
            String Username = l["Username"];
            String Password = l["Password"];

            ViewBag.Uname = Username;
            ViewBag.Pass = Password;

            //ViewBag only allows to show data in the input page
            //if (ModelState.IsValid)
            //{
            //    return RedirectToAction("Index", "Home", l);
            //}
            return View(l);
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View(new Register());
        }

        [HttpPost]
        public ActionResult Register(Register r)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(r);
        }
    }
}