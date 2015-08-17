using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using DreamWorkerStudioJobs.Models;
using DreamWorkerStudioJobs.Properties;

namespace DreamWorkerStudioJobs.Controllers
{
    public class ApplyForJobController:Controller
    {
        public ActionResult Apply(string id)
        {
           
            ApplyForJob temp = new ApplyForJob();

            return View("Apply",temp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Apply([Bind(Include = "Advantage,Class,Email,FamilyName,FirstName,Grade,PhoneNumber,Xing,Ming,Sex,Mark,Project,Job")]ApplyForJob application)
        {
            ViewBag.HasState = true;
            if(ModelState.IsValid)
            {
                ViewBag.Message = "成功，我们已经记录你的信息并将会通知你下一步的行动";
                ViewBag.Kind = "success";
            }
            else
            {
                ViewBag.Message = "发生了错误：";
                foreach(var item in ModelState)
                {
                    foreach(var err in item.Value.Errors)
                    {
                        ViewBag.Message += err.ErrorMessage + "；";
                    }
                }
                ViewBag.Kind = "danger";
            }
            return View();
        }

        // GET: ApplyForJob
        public ActionResult Index()
        {
            return View();
        }


    }
}
