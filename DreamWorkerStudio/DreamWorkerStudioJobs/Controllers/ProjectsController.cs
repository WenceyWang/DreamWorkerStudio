using System;
using System . Collections . Generic;
using System . Linq;
using System . Web;
using System . Web . Mvc;
using System . Reflection;
using System . IO;
using System . Xml . Linq;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DreamWorkerStudioJobs . Controllers
{
    public class ProjectsController : Controller
    {
        public ActionResult Index ( string arguments )
        {
            var assembly = Assembly . GetExecutingAssembly ( );

            var stream = assembly . GetFile ( "" );

            var reader = new StreamReader ( stream );

            var doc = XDocument . Parse ( reader . ReadToEnd ( ) );



            return View ( );
        }

        // GET: /<controller>/
        public ActionResult Index ( )
        {
            return View ( );
        }
    }
}
