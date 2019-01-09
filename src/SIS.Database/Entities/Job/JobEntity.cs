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

        [Required]
        public string JobName { get; set; }

        [Required]
        public string JobCompany { get; set; }

        [Required]
        public string JobDesc { get; set; }

        [Required]
        public string JobCompensation { get; set; }

        [Required]
        public string JobHours { get; set; }

        [Required]
        public string JobDesiredPersonality { get; set; }

        [Required]
        public int OwnerId { get; set; }
    }
}
