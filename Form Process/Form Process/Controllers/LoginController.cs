using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Form_Process.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult log(Login login)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(login);
        }
    }
}