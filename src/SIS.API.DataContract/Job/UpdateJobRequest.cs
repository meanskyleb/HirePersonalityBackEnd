using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.API.DataContract.Job
{
    public class UpdateJobRequest
    {
        public int JobEntityId { get; set; }
        public string JobName { get; set; }
        public string JobCompany { get; set; }
        public string JobDesc { get; set; }
        public string JobCompensation { get; set; }
        public string JobHours { get; set; }
        public int JobDesiredPersonality { get; set; }
    }
}
