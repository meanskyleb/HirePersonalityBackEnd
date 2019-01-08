using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HirePersonality.Database.DataContract.Job
{
    public interface IJobRepository
    {
        Task<bool> CreateJob(JobCreateRAO rao);
    }
}
