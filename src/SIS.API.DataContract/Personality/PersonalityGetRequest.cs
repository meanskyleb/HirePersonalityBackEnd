using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.API.DataContract.Personality
{
    public class PersonalityGetRequest
    {
        public int PersonalityNumber { get; set; }
        public Guid UserId { get; set; }
    }
}
