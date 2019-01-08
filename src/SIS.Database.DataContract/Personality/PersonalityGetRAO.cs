using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.Database.DataContract.Personality
{
    public class PersonalityGetRAO
    {
        public int PersonalityNumber { get; set; }
        public Guid UserId { get; set; }
    }
}
