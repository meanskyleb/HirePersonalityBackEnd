using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HirePersonality.Business.DataContract.Job
{
    public interface IJobManager
    {
        Task<bool> CreateJob(JobCreateDTO dto);
        Task<IEnumerable<ReceiveJobDTO>> GetJob();
        Task<ReceiveJobDTO> GetJob(int id);
        Task<bool> UpdateJob(UpdateJobDTO dto);
        Task<bool> DeleteJob(int id);
    }
}
