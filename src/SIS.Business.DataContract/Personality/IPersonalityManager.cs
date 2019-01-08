using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HirePersonality.Business.DataContract.Personality
{
    public interface IPersonalityManager
    {
        Task<bool> CreatePersonality(PersonalityCreateDTO dto);
        Task<IEnumerable<ReceivePersonalityDTO>> GetPersonality();
    }
}
