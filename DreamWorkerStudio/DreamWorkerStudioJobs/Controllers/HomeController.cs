using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DreamWorkerStudioJobs.Controllers
{
    public class HomeController:Controller
    {
        public ActionResult Index()
        {
            return View(MvcApplication.ProjectList);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

    }
}