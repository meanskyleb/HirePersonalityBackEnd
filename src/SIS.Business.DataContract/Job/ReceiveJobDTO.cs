using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.Business.DataContract.Job
{
    public class ReceiveJobDTO
    {
        public string JobName { get; set; }
        public string JobCompany { get; set; }
        public int OwnerId { get; set; }
    }
}
