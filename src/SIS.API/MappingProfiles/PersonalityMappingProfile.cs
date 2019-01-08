using AutoMapper;
using HirePersonality.API.DataContract.Personality;
using HirePersonality.Business.DataContract.Personality;
using HirePersonality.Database.DataContract.Personality;
using HirePersonality.Database.Entities.Personality;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HirePersonality.API.MappingProfiles
{
    public class PersonalityMappingProfile : Profile
    {
       public PersonalityMappingProfile()
        {
            CreateMap<PersonalityCreateRequest, PersonalityCreateDTO>();
            CreateMap<PersonalityCreateDTO, PersonalityCreateRao>();
            CreateMap<PersonalityCreateRAO, PersonalityEntity>();
        }
    }
}
