using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HirePersonality.Business.DataContract.Job
{
    public interface IJobManager
    {
        Task<bool> CreateJob(JobCreateDTO dto);
    }
}
