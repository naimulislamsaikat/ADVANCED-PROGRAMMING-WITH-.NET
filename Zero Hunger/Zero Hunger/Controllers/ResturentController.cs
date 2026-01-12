using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zero_Hunger.Models;
using Zero_Hunger.EF;

namespace Zero_Hunger.Controllers
{
    public class ResturentController : Controller
    {
        ZeroHungerEntities db = new ZeroHungerEntities();

        [HttpGet]
        public ActionResult DashBoard()
        {
            var requests = db.ResturentInfoes.ToList();

            return View(requests);
        }

        [HttpPost]
        public ActionResult DashBoard(ResturentRequests resturent)
        {
            // Map ResturentRequests to Request
            var request = new ResturentInfo
            {
                ResturentName = resturent.ResturentName,
                ResturentLocation = resturent.ResturentLocation,
                PreserveDate = resturent.PreserveDate,
                Assigned = resturent.Assigned,
                Status = resturent.Status
            };

            db.ResturentInfoes.Add(request);
            db.SaveChanges();

            var requests = db.ResturentInfoes.ToList();

            return View(requests);
        }
    }
}