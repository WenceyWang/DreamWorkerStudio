using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamWorkerStudio.Models
{
    public class Project
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public string Introduction { get; set; }

        public List<Job> Jobs { get; set; }
    }
}
