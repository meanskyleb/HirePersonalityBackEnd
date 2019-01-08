using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HirePersonality.Database.DataContract.Personality
{
    public interface IPersonalityRepository
    {
        Task<bool> CreatePersonality(PersonalityCreateRAO rao);
    }
}
