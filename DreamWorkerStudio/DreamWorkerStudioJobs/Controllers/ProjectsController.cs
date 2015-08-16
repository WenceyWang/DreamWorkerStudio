using System;
using System . Collections . Generic;
using System . Linq;
using System . Web;
using System . Web . Mvc;
using System . Reflection;
using System . IO;
using System . Xml . Linq;
using DreamWorkerStudioJobs . Models;
using DreamWorkerStudioJobs . Properties;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DreamWorkerStudioJobs . Controllers
{
    public class ProjectsController : Controller
    {
        public List<Job> JobList { get; set; }

        public List<Project> ProjectList { get; set; }

        public ActionResult Index ( string arguments )
        {
            return View ( ProjectList );
        }

        // GET: /<controller>/


        public ProjectsController ( ) : base ( )
        {

            var doc = XDocument . Parse ( Resources . Projects );

            Dictionary<string , Job> tempJob = new Dictionary<string , Job> ( );

            List<Project> tempProject = new List<Project> ( );

            foreach ( var project in doc . Root . Elements ( ) )
            {
                Project currentProject = new Project
                {
                    ID = ( string ) project . Attribute ( "ID" ) ,
                    Name = ( string ) project . Attribute ( "Name" ) ,
                    Introduction = ( string ) project . Attribute ( "Introduction" ) ,
                };
                foreach ( var job in project . Elements ( ) )
                {
                    string id = ( string ) job . Attribute ( "ID" );

                    Job currentJob;

                    if ( !tempJob . ContainsKey ( id ) )
                    {
                        currentJob = new Job
                        {
                            ID = ( string ) job . Attribute ( "ID" ) ,
                            Name = ( string ) job . Attribute ( "Name" ) ,
                        };
                        tempJob . Add ( currentJob . ID , currentJob );
                    }
                    else
                    {
                        currentJob = tempJob [ id ];
                    }
                    currentJob . Introduction . Add ( currentProject , ( string ) job . Attribute ( "Introduction" ) );
                    currentJob . Requirement . Add ( currentProject , ( string ) job . Attribute ( "Requirement" ) );
                    currentProject . Jobs . Add ( currentJob );
                }
                tempProject . Add ( currentProject );
            }
            ProjectList = tempProject;
            JobList = new List<Job> ( tempJob . Values );

        }
    }
}
