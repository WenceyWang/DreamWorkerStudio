using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Xml.Linq;
using DreamWorkerStudioJobs.Models;
using DreamWorkerStudioJobs.Properties;


namespace DreamWorkerStudioJobs
{
    public class MvcApplication:System.Web.HttpApplication
    {
        public static List<Job> JobList { get; set; }

        public static List<Project> ProjectList { get; set; }


        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        public MvcApplication()
        {
            var doc = XDocument.Parse(Resources.Projects);

            Dictionary<string,Job> tempJob = new Dictionary<string,Job>();

            List<Project> tempProject = new List<Project>();

            foreach(var project in doc.Root.Elements())
            {
                Project currentProject = new Project
                {
                    ID = (string)project.Attribute("ID"),
                    Name = (string)project.Attribute("Name"),
                    Introduction = (string)project.Attribute("Introduction"),
                };
                foreach(var job in project.Elements())
                {
                    string id = (string)job.Attribute("ID");

                    Job currentJob;

                    if(!tempJob.ContainsKey(id))
                    {
                        currentJob = new Job
                        {
                            ID = (string)job.Attribute("ID"),
                            Name = (string)job.Attribute("Name"),
                        };
                        tempJob.Add(currentJob.ID,currentJob);
                    }
                    else
                    {
                        currentJob = tempJob[id];
                    }
                    currentJob.Introduction.Add(currentProject,(string)job.Attribute("Introduction"));
                    currentJob.Requirement.Add(currentProject,(string)job.Attribute("Requirement"));
                    currentProject.Jobs.Add(currentJob);
                }
                tempProject.Add(currentProject);
            }
            ProjectList = tempProject;
            JobList = new List<Job>(tempJob.Values);

        }
    }
}
