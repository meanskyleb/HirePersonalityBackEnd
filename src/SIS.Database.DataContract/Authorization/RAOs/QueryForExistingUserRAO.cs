﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.Database.DataContract.Authorization.RAOs
{
    public class QueryForExistingUserRAO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
