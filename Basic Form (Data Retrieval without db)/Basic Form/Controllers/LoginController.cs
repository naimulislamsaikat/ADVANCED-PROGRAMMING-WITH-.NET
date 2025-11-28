using Basic_Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Basic_Form.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult log()
        {
            return View();
        }

        [HttpPost]
        public ActionResult log(LogIn l)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Intro", "Home");
            }
            return View(l);
        }

        [HttpGet]
        public ActionResult reg()
        {
            return View();
        }

        [HttpPost]
        public ActionResult reg(Reg r) { 

            if (ModelState.IsValid)
            {
                return RedirectToAction("log", "Login");
            }
            return View(r);
        }
    }
}