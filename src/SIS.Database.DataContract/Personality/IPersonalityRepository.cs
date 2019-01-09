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
        Task<ReceivePersonalityRAO> GetPersonalityAsync(int id);
        Task<DeletePersonalityRAO> DeletePersonality(int id);
        Task<UpdatePersonalityRAO> UpdatePersonality(int id);
    }
}
