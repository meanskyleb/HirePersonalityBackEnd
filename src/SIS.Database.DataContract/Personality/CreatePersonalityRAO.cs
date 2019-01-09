using HirePersonality.Business.DataContract.Personality;
using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.Database.DataContract.Personality
{
    
    public class CreatePersonalityRAO
    {
        public int PersonalityNumber { get; set; }
        public Guid UserId { get; set; }
        public int PersonalityType { get; set; }
    }
    
}
