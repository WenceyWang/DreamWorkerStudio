using System;
using System . Collections . Generic;
using System . Linq;
using System . Threading . Tasks;
using System . IO;
using System . Xml . Linq;
using Microsoft . AspNet . Mvc;
using System . Reflection;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DreamWorkerStudioJobs . Controllers
{
    public class ProjectsController : Controller
    {
        //public IActionResult Index ( string arguments )
        //{
        //    var assembly = Assembly . GetExecutingAssembly ( );

        //    var stream = assembly . GetFile ( "" );

        //    var reader = new StreamReader ( stream );

        //    var doc = XDocument . Parse ( reader . ReadToEnd ( ) );

            

        //    return View ( );
        //}

        // GET: /<controller>/
        public IActionResult Index ( )
        {
            return View ( null );
        }
    }
}
