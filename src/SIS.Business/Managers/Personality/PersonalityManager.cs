using AutoMapper;
using HirePersonality.Business.DataContract.Personality;
using HirePersonality.Business.Engines;
using HirePersonality.Database.DataContract.Personality;
using Microsoft.AspNet.Identity;
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
        private readonly PersonalityEngine _personalityEngine;

        public PersonalityManager(IMapper mapper, IPersonalityRepository repository, PersonalityEngine personalityEngine)
        {
            _mapper = mapper;
            _repository = repository;
            _personalityEngine = personalityEngine;
        }

        public async Task<bool> CreatePersonality(CreatePersonalityDTO dto)
        {
            var  dtoAnalyzed = _personalityEngine.SurveyAnalysis(dto);
 
            var rao = _mapper.Map<CreatePersonalityRAO>(dtoAnalyzed);

            if(await _repository.CreatePersonality(rao))
                return true;

            throw new Exception();
        }

        public async Task<IEnumerable<ReceivePersonalityDTO>> GetPersonality()
        {
            var rao = await _repository.GetPersonality();

            var dto = _mapper.Map<IEnumerable<ReceivePersonalityDTO>>(rao);

            return dto;
        }

        public async Task<ReceivePersonalityDTO> GetPersonality(int id)
        {
            var rao = await _repository.GetPersonality(id);

            var dto = _mapper.Map<ReceivePersonalityDTO>(rao);

            return dto;
        }

        public async Task<bool> UpdatePersonality(UpdatePersonalityDTO dto)
        {
            var dtoAnalyzed = _personalityEngine.SurveyAnalysis(dto);

            var rao = _mapper.Map<UpdatePersonalityRAO>(dto);

            if (await _repository.UpdatePersonality(rao))
            {
                return true;
            }
                throw new Exception();
            


        }

        public bool DeletePersonality(int id)
        {
            if (_repository.DeletePersonality(id))
                return true;

            return false;
        }

        public async Task<int> GetPersonalityType(int id)
        {
            var personalityType = await _repository.GetPersonalityType(id);
                return personalityType;
        }
        //Helper Methods
       

    }
}
