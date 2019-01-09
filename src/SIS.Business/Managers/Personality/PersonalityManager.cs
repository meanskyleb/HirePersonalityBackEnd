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

        public async Task<bool> CreatePersonality(CreatePersonalityDTO dto)
        {
            dto.PersonalityType = AssignPersonalityType(dto.PersonalityNumber);

            var rao = _mapper.Map<CreatePersonalityRAO>(dto);

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
            dto.PersonalityType = AssignPersonalityType(dto.PersonalityNumber);

            var rao = _mapper.Map<UpdatePersonalityRAO>(dto);

            if (await _repository.UpdatePersonality(rao))
                return true;

                throw new Exception();
            


        }

        public async Task<bool> DeletePersonality(int id)
        {
            if (await _repository.DeletePersonality(id))
                return true;

            return false;
        }

        //Helper Methods
        private int AssignPersonalityType(int personalityNumber)
        {
            if (personalityNumber >= -30 && personalityNumber < 5)
            {
                return 1;
            }
            else if (personalityNumber >= 5 && personalityNumber < 10)
            {
                return 2;
            }
            else if (personalityNumber >= 10 && personalityNumber < 15)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }

    }
}
