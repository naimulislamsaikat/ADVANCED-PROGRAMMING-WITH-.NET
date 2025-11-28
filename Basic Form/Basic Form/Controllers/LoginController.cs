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
        public ActionResult log()
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Intro", "Home");
            }
            return View();
        }
        public ActionResult reg() { 

            if (ModelState.IsValid)
            {
                return RedirectToAction("log", "Login");
            }
            return View();
        }
    }
}