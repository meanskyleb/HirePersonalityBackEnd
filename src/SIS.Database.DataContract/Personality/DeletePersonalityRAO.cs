using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.Database.DataContract.Personality
{
    public class DeletePersonalityRAO
    {
        public int PersonalityEntityId { get; set; }
        public int PersonalityNumber { get; set; }
        public Guid UserId { get; set; }
        public int PersonalityType { get; set; }
    }
}
