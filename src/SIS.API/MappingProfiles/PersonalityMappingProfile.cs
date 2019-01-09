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
            CreateMap<CreatePersonalityRequest, CreatePersonalityDTO>();
            CreateMap<CreatePersonalityDTO, CreatePersonalityRAO>();
            CreateMap<CreatePersonalityRAO, PersonalityEntity>();

            CreateMap<PersonalityEntity, ReceivePersonalityRAO>();
            CreateMap<ReceivePersonalityRAO, ReceivePersonalityDTO>();
            CreateMap<ReceivePersonalityDTO, ReceivePersonalityRequest>();

            CreateMap<UpdatePersonalityRequest, UpdatePersonalityDTO>();
            CreateMap<UpdatePersonalityDTO, UpdatePersonalityRAO>();
            CreateMap<UpdatePersonalityRAO, PersonalityEntity>();
        }
    }
}
