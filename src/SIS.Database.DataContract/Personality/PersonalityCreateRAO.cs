using HirePersonality.Business.DataContract.Personality;
using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.Database.DataContract.Personality
{
    
    public class PersonalityCreateRAO
    {
        public int PersonalityNumber { get; set; }
        public Guid UserId { get; set; }
        public PersonalityType PersonalityType { get; set; }
    }
    
}
