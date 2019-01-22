using HirePersonality.Business.DataContract.Personality;
using System;
using System.Collections.Generic;
using System.Text;

namespace HirePersonality.Business.Engines
{
     public class PersonalityEngine
    {
        public CreatePersonalityDTO SurveyAnalysis(CreatePersonalityDTO dto)
        {
            dto.PersonalityNumber = 0 -
                dto.Conversation + dto.Independent + dto.Picture + dto.PublicSpeaking + dto.Quick + dto.Leadership + dto.Problem
                - dto.Minutiae - dto.Technical - dto.Design - dto.Teamwork - dto.Relationship;

            dto.PersonalityType = AssignPersonalityType(dto.PersonalityNumber);

            return dto;
        }
        public UpdatePersonalityDTO SurveyAnalysis(UpdatePersonalityDTO dto)
        {
            dto.PersonalityNumber = 0 -
                dto.Conversation + dto.Independent + dto.Picture + dto.PublicSpeaking + dto.Quick + dto.Leadership + dto.Problem
                - dto.Minutiae - dto.Technical - dto.Design - dto.Teamwork - dto.Relationship;

            dto.PersonalityType = AssignPersonalityType(dto.PersonalityNumber);

            return dto;
        }


        private int AssignPersonalityType(int personalityNumber)
        {
            if (personalityNumber >= -30 && personalityNumber < 0)
            {
                return 1; //Entry-Level
            }
            else if (personalityNumber >= 0 && personalityNumber < 10)
            {
                return 2; //Technically-minded
            }
            else if (personalityNumber >= 10 && personalityNumber < 20)
            {
                return 3; //Analytical
            }
            else
            {
                return 4; //Born-Leader
            }
        }
        //TODO: Gather Criteria for the Personality Test, 12 questions.
        //TODO: Write logic to pull this data into a comparative matrix
        //TODO: Write More logic to separate this data into what is most important to the person filling out the survey.
        //TODo: Write logic for the 4 different personality types and how they carry weight based on certain answers.
    }
}
