using AutoMapper;
using HirePersonality.API.DataContract.Job;
using HirePersonality.Business.DataContract.Job;
using HirePersonality.Database.DataContract.Job;
using HirePersonality.Database.Entities.Job;
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

            CreateMap<JobEntity, ReceiveJobRAO>();
            CreateMap<ReceiveJobRAO, ReceiveJobDTO>();
            CreateMap<ReceiveJobDTO, ReceiveJobRequest>();

        }
    }
}
