using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zero_Hunger.EF;

namespace Zero_Hunger.Controllers
{
    public class DashboardController : Controller
    {
        ZeroHungerEntities db = new ZeroHungerEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AssignStatus(int id)
        {
            var assign = db.ResturentInfoes.Find(id);
            assign.Status = "Assigned";

            return View();
        }

        public ActionResult CompleteStatus(int id)
        {
            var assign = db.ResturentInfoes.Find(id);
            assign.Status = "Completed";

            return View();
        }
    }
}