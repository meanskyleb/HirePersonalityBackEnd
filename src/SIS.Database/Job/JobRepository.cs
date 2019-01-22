using AutoMapper;
using HirePersonality.Database.DataContract.Job;
using HirePersonality.Database.Entities.Job;
using HirePersonality.Database.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using HirePersonality.Database.Entities.People;
using System.Linq;

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

        public async Task<IEnumerable<ReceiveJobRAO>> GetJob()
        {
            var query = await _context.JobTableAccess.ToArrayAsync();

            var rao = _mapper.Map<IEnumerable<ReceiveJobRAO>>(query);


            return rao;
        }

        public async Task<IEnumerable<ReceiveJobRAO>> GetJobByType(int personalityType)
        {
            var query = await _context.JobTableAccess.Where(e => e.DesiredPersonality == personalityType).ToArrayAsync();

            var rao = _mapper.Map<IEnumerable<ReceiveJobRAO>>(query);


            return rao;
        }

        public async Task<ReceiveJobRAO> GetJob(int id)
        {
            var entity = await _context
                .JobTableAccess
                .SingleAsync(e => e.JobEntityId == id);

            var rao = _mapper.Map<ReceiveJobRAO>(entity);

            return rao;

        }

        public async Task<bool> UpdateJob(UpdateJobRAO rao)
        {
            var entity = await _context
                .JobTableAccess
                .SingleOrDefaultAsync(e => e.JobEntityId == rao.JobEntityId);
            if (rao.Name != null)
            {
                entity.Name = rao.Name;
            }
            if (rao.Company != null)
            {
                entity.Company = rao.Company;
            }
            if (rao.Desc != null)
            {
                entity.Desc = rao.Desc;
            }
            if (rao.Compensation != null)
            {
                entity.Compensation = rao.Compenstaion;
            }
            if (rao.Hours != null)
            {
                entity.Hours = rao.Hours;
            }
            if (rao.DesiredPersonality != null)
            {
                entity.DesiredPersonality = rao.DesiredPersonality;
            }

            return _context.SaveChanges() == 1;
        }

        public async Task<bool> DeleteJob(int id)
        {
            var entity = await _context
                .JobTableAccess
                .SingleOrDefaultAsync(e => e.JobEntityId == id);

            _context.Remove(entity);

            return _context.SaveChanges() == 1;


        }
    }
}
