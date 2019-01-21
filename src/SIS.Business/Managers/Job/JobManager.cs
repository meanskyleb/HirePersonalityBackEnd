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

        public async Task<IEnumerable<ReceiveJobDTO>> GetJob()
        {
            var rao = await _repository.GetJob();

            var dto = _mapper.Map<IEnumerable<ReceiveJobDTO>>(rao);

            return dto;
        }

        public async Task<IEnumerable<ReceiveJobDTO>> GetJobByType(int personalityType)
        {
            var rao = await _repository.GetJobByType(personalityType);

            var dto = _mapper.Map<IEnumerable<ReceiveJobDTO>>(rao);

            return dto;
        }

        public async Task<ReceiveJobDTO> GetJob(int id)
        {
            var rao = await _repository.GetJob(id);

            var dto = _mapper.Map<ReceiveJobDTO>(rao);

            return dto;
        }

        public async Task<bool> UpdateJob(UpdateJobDTO dto)
        {

            var rao = _mapper.Map<UpdateJobRAO>(dto);

            if (await _repository.UpdateJob(rao))
                return true;

            throw new Exception();
        }

        public async Task<bool> DeleteJob(int id)
        {
            if (await _repository.DeleteJob(id))
                return true;

            return false;
        }
    }
}
