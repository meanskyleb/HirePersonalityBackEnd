using AutoMapper;
using HirePersonality.Business.DataContract.Personality;
using HirePersonality.Database.DataContract.Personality;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HirePersonality.Business.Managers.Personality
{
    public class PersonalityManager : IPersonalityManager
    {
        private readonly IMapper _mapper;
        private readonly IPersonalityRepository _repository;

        public PersonalityManager(IMapper mapper, IPersonalityRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<bool> CreatePersonality(PersonalityCreateDTO dto)
        {
            var rao = _mapper.Map<PersonalityCreateRAO>(dto);

            if(await _repository.CreatePersonality(rao))
                return true;

            throw new Exception();
        }
    }
}
