using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HirePersonality.Database.DataContract.Job
{
    public interface IJobRepository
    {
        Task<bool> CreateJob(JobCreateRAO rao);
        Task<IEnumerable<ReceiveJobRAO>> GetJob();
        Task<IEnumerable<ReceiveJobRAO>> GetJobByType(int personalityType);
        Task<ReceiveJobRAO> GetJob(int id);
        Task<bool> DeleteJob(int id);
        Task<bool> UpdateJob(UpdateJobRAO rao);
    }
}
