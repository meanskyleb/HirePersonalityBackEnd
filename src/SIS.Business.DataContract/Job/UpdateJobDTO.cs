using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.Business.DataContract.Job
{
    public class UpdateJobDTO
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
