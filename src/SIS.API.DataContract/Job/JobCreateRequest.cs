﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.API.DataContract.Job
{
    public class JobCreateRequest
    {
        public string Name { get; set; }
        public string Company { get; set; }
        public string Desc { get; set; }
        public string Compensation { get; set; }
        public string Hours { get; set; }
        public int DesiredPersonality { get; set; }
    }
}
