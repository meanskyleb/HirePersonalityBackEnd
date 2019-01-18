using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HirePersonality.Business.DataContract.Personality
{
    public interface IPersonalityManager
    {
        Task<bool> CreatePersonality(CreatePersonalityDTO dto);
        Task<IEnumerable<ReceivePersonalityDTO>> GetPersonality();
        Task<ReceivePersonalityDTO> GetPersonality(int id);
        Task<bool> UpdatePersonality(UpdatePersonalityDTO dto);
        bool DeletePersonality(int id);
        Task<int> GetPersonalityType(int ownerId);
    }
}
