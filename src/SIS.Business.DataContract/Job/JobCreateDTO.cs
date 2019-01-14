using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.Business.DataContract.Job
{
    public class JobCreateDTO
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Desc { get; set; }
        public string Compensation { get; set; }
        public string Hours { get; set; }
        public string DesiredPersonality { get; set; }
        public int OwnerId { get; set; }
    }
}
