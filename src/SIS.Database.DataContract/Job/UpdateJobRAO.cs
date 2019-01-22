using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.Database.DataContract.Job
{
    public class UpdateJobRAO
    {
        public int JobEntityId { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Desc { get; set; }
        public string Compensation { get; set; }
        public string Hours { get; set; }
        public int? DesiredPersonality { get; set; }
    }
}
