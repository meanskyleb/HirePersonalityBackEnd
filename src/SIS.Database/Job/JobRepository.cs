using AutoMapper;
using HirePersonality.Database.DataContract.Job;
using HirePersonality.Database.Entities.Job;
using HirePersonality.Database.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HirePersonality.Database.Job
{
    public class JobRepository : IJobRepository
    {
        private readonly SISContext _context;
        private readonly IMapper _mapper;

        public JobRepository(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreateJob(JobCreateRAO rao)
        {
            var entity = _mapper.Map<JobEntity>(rao);

            _context.JobTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;
        }
    }
}
