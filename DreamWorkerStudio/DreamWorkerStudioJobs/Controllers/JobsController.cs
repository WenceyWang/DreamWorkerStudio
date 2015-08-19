using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DreamWorkerStudioJobs.Controllers
{
    public class JobsController:Controller
    {
        public ActionResult List(string id)
        {
            foreach(var item in MvcApplication.JobList)
            {
                if(item.ID.ToLower() == id?.ToLower())
                {
                    return View("JobView",item);
                }
            }
            return Index(null);
        }


        // GET: Jobs
        public ActionResult Index(string id)
        {
            return View("JobOverView",MvcApplication.JobList);
        }
    }
}