using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.Business.DataContract.Personality
{
    public enum PersonalityType { Thinker = 1, Leader, Doer, Perfectionist }
    public class PersonalityCreateDTO
    {
        public int PersonalityNumber { get; set; }
        public Guid UserId { get; set; }
        public PersonalityType PersonalityType { get; set; }
    }
}
