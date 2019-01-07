using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HirePersonality.Database.Entities.Job
{
    public class JobEntity
    {
        [Key]
        public int JobEntityId { get; set; }
    }
}
