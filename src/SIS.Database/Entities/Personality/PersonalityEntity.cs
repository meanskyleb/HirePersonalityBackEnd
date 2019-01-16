using HirePersonality.Business.DataContract.Personality;
using HirePersonality.Database.DataContract.Personality;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HirePersonality.Database.Entities.Personality
{
    
    public class PersonalityEntity
    {
        [Key]
        public int PersonalityEntityId { get; set; }
        public int PersonalityNumber { get; set; }
        public int UserId { get; set; }
        public int PersonalityType { get; set; }
    }
}
