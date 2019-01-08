using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HirePersonality.Database.DataContract.Application
{
    public interface IApplicationRepository
    {
        Task<bool> CreateApplication(ApplicationCreateRAO applicationCreateRAO, Guid ApplicationGuid);
        Task<IEnumerable<ApplicationListItemRAO>> GetAllApplications();
    }
}
