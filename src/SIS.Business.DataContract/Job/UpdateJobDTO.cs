using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.Business.DataContract.Job
{
    public class UpdateJobDTO
    {
        public int JobEntityId { get; set; }
        public string JobName { get; set; }
        public string JobCompany { get; set; }
        public string JobDesc { get; set; }
        public string JobCompensation { get; set; }
        public string JobHours { get; set; }
        public int JobDesiredPersonality { get; set; }
        public int OwnerId { get; set; }
    }
}
