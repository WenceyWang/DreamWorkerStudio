using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Reflection;
using System.IO;
using System.Xml.Linq;
using DreamWorkerStudioJobs.Models;
using DreamWorkerStudioJobs.Properties;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DreamWorkerStudioJobs.Controllers
{
    public class ProjectsController:Controller
    {
        public ActionResult List(string id)
        {
            foreach(var item in MvcApplication.ProjectList)
            {
                if(item.ID.ToLower() == id?.ToLower())
                {
                    return View("ProjectView",item);
                }
            }
            return Index(null);
        }

        public ActionResult Index(string arguments)
        {
            return View("ProjectOverView",MvcApplication.ProjectList);
        }

        // GET: /<controller>/


        public ProjectsController() : base()
        {


        }
    }
}
