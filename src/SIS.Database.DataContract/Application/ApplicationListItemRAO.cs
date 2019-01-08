using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.Database.DataContract.Application
{
    public class ApplicationListItemRAO
    {
        public Guid ApplicationEntityId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
