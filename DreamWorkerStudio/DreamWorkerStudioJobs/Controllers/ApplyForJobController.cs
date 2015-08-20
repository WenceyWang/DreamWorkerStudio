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
            if(id != null)
            {

                var list = id?.ToLower()?.Split(new string[] { "in" },StringSplitOptions.None);


                foreach(var project in MvcApplication.ProjectList)
                {
                    if(list[1] == project.ID.ToLower())
                    {
                        temp.Project = project.ID;
                        foreach(var job in project.Jobs)
                        {
                            if(list[0] == job.ID.ToLower())
                            {
                                temp.Job = job.ID;
                            }
                        }
                    }
                }
            }
            return View("Apply",temp);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Apply([Bind(Include = "Advantage,Class,Email,FamilyName,FirstName,Grade,PhoneNumber,Xing,Ming,Sex,Mark,Project,Job")]ApplyForJob application)
        {
            ViewBag.HasState = true;
            if(ModelState.IsValid)
            {
                var job = (from item in MvcApplication.JobList
                           where item.ID == ModelState["Job"].Value.AttemptedValue
                           select item).FirstOrDefault();
                var project = (from item in MvcApplication.ProjectList
                               where item.ID == ModelState["Project"].Value.AttemptedValue
                               select item).FirstOrDefault();
                if(job.Introduction.ContainsKey(project))
                {
                    ViewBag.Message = "成功，我们已经记录你的信息并将会通知你下一步的行动";
                    ViewBag.Kind = "success";
                    var result = new ApplyForJobResult { ID = (ModelState["Ming"].Value.AttemptedValue + ModelState["Xing"].Value.AttemptedValue).GetHashCode() };
                    return View("Result",result);
                }
                else
                {
                    ModelState["Job"].Errors.Add("所选的项目不希望所选的职位");
                }
            }
            ViewBag.Message = "发生了错误：";
            var val = new Dictionary<string,string>();
            foreach(var item in ModelState)
            {
                if(item.Value.Errors.Count == 0)
                {
                    val.Add(item.Key,"has-success");
                }
                else
                {
                    val.Add(item.Key,"has-error");
                }
                foreach(var err in item.Value.Errors)
                {
                    ViewBag.Message += err.ErrorMessage + "；";
                }
            }
            ViewBag.Val = val;
            ViewBag.Kind = "danger";
            return View();
        }

        // GET: ApplyForJob
        public ActionResult Index()
        {
            return View();
        }


    }
}
