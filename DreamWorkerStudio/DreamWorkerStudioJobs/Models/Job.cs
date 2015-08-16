using System;
using System . Collections . Generic;
using System . Linq;
using System . Threading . Tasks;

namespace DreamWorkerStudioJobs . Models
{
    public class Job
    {
        public string ID { get; set; }

        public string Name { get; set; }

        public List<Tuple<Project , string>> Introduction { get; set; }

        public List<Tuple<Project , string>> Requirement { get; set; }

    }
}
