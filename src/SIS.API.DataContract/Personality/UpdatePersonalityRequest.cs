using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.API.DataContract.Personality
{
    public class UpdatePersonalityRequest
    {
        public int Design { get; set; }
        public int Problem { get; set; }
        public int Picture { get; set; }
        public int Minutiae { get; set; }
        public int Leadership { get; set; }
        public int Teamwork { get; set; }
        public int Conversation { get; set; }
        public int Technical { get; set; }
        public int Relationship { get; set; }
        public int Independent { get; set; }
        public int PublicSpeaking { get; set; }
        public int Quick { get; set; }
        public int OwnerId { get; set; }

    }
}
