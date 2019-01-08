using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HirePersonality.API.MappingProfiles
{
    public class JobMappingProfile : Profile
    {
        public JobMappingProfile()
        {
            CreateMap<JobCreateRequest, JobCreateDTO>();
            CreateMap<JobCreateDTO, JobCreateRAO>();
            CreateMap<JobCreateRAO, JobEntity>();
        }
    }
}
