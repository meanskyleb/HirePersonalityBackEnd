using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HirePersonality.Database.DataContract.Personality
{
    public interface IPersonalityRepository
    {
        Task<bool> CreatePersonality(CreatePersonalityRAO rao);
        Task<IEnumerable<ReceivePersonalityRAO>> GetPersonality();
        Task<ReceivePersonalityRAO> GetPersonality(int id);
        bool DeletePersonality(int id);
        Task<bool> UpdatePersonality(UpdatePersonalityRAO rao);
        Task<int> GetPersonalityType(int id);
    }
}
