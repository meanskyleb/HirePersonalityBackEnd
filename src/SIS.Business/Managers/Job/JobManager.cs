using AutoMapper;
using HirePersonality.Business.DataContract.Job;
using HirePersonality.Database.DataContract.Job;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HirePersonality.Business.Managers.Job
{
    public class JobManager : IJobManager
    {
        private readonly IMapper _mapper;
        private readonly IJobRepository _repository;

        public JobManager(IMapper mapper, IJobRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<bool> CreateJob(JobCreateDTO dto)
        {
            var rao = _mapper.Map<JobCreateRAO>(dto);

            if (await _repository.CreateJob(rao))
                return true;

            throw new NotImplementedException();
        }
    }
}
