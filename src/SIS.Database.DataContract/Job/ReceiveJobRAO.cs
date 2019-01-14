using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HirePersonality.Database.DataContract.Job
{
    public class ReceiveJobRAO
    {
        [Key]
        public int JobEntityId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Company { get; set; }

        [Required]
        public string Desc { get; set; }

        [Required]
        public string Compensation { get; set; }

        [Required]
        public string Hours { get; set; }

        [Required]
        public string DesiredPersonality { get; set; }

        [Required]
        public int OwnerId { get; set; }
    }
}
