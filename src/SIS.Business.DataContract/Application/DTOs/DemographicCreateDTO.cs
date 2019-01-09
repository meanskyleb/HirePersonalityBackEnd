using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.Business.DataContract.Application.DTOs
{
    public class DemographicCreateDTO
    {
        public string Gender { get; set; }
        public string Ethnicity { get; set; }
        public bool Married { get; set; }
    }
}
