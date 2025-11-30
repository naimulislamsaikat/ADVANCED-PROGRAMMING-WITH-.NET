using FormProcessing.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormProcessing.Controllers
{
    public class LoginController : Controller
    {
        // This is an example of using Model Binding to bind form data to a model object.

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Login() { });
        }

        [HttpPost]
        public ActionResult Index(Login login)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home", login);
            }
            return View(login);
        }


        [HttpGet]
        public ActionResult Register()
        {
            return View(new Student());
        }

        [HttpPost]
        public ActionResult Register(Student s)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            return View(s);
        }
    }
}