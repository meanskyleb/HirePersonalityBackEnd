using AutoMapper;
using HirePersonality.API.DataContract.Application;
using HirePersonality.Business.DataContract.Application.DTOs;
using HirePersonality.Database.DataContract.Application;
using HirePersonality.Database.Entities.Application;

namespace HirePersonality.API.MappingProfiles
{
    public class ApplicationMappingProfile : Profile
    {
        public ApplicationMappingProfile()
        {
            //<-- Registration-oriented
            CreateMap<ApplicationCreateRequest, ApplicationCreateDTO>(); 
            CreateMap<ApplicationCreateDTO, ApplicationCreateRAO>();     
            CreateMap<ApplicationCreateRAO, ApplicationEntity>();
            CreateMap<ContactRAO, ContactEntity>();
            CreateMap<DemographicRAO, DemographicEntity>();
            CreateMap<EducationRAO, EducationEntity>();
            CreateMap<ExperienceRAO, ExperienceEntity>();
        }
    }
}
