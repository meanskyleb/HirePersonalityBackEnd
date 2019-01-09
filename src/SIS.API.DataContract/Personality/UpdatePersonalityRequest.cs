using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.API.DataContract.Personality
{
    public class UpdatePersonalityRequest
    {
        public int PersonalityEntityId { get; set; }
        public int PersonalityNumber { get; set; }
        public Guid UserId { get; set; }
        public int PersonalityType { get; set; }
    }
}
