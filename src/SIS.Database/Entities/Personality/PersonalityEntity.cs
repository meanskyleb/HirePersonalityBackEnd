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
    }
}
