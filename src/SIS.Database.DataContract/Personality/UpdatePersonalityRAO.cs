using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.Database.DataContract.Personality
{
    public class UpdatePersonalityRAO
    {
        public int PersonalityEntityId { get; set; }
        public int PersonalityNumber { get; set; }
        public int OwnerId { get; set; }
        public int PersonalityType { get; set; }
    }
}
