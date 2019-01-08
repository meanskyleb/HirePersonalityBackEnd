using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HirePersonality.API.DataContract.Personality;
using HirePersonality.Business.DataContract.Personality;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HirePersonality.API.Controllers.Personality
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]

    public class PersonalityController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IPersonalityManager _manager;

        public PersonalityController(IMapper mapper, IPersonalityManager manager) 
        {
                _mapper = mapper;
                _manager = manager;
        }

        [HttpPost]
        public async Task<IActionResult> PostPersonality(PersonalityCreateRequest request)
        {
            var dto = _mapper.Map<PersonalityCreateDTO>(request);

            //Logic for personalities go here.
            if (dto.PersonalityNumber >=-30 && dto.PersonalityNumber < 5)
            {
                dto.PersonalityType = 1;
            }
            else if (dto.PersonalityNumber >=5 && dto.PersonalityNumber < 10)
            {
                dto.PersonalityType = 2;
            }
            else if (dto.PersonalityNumber >= 10 && dto.PersonalityNumber < 15)
            {
                dto.PersonalityType = 3;
            }
            else
            {
                dto.PersonalityType = 4;
            }
            if (await _manager.CreatePersonality(dto))
                return StatusCode(201);
            
            throw new NotImplementedException();
        }
        [HttpGet]
        public async Task<IEnumerable<ReceivePersonalityRequest>> GetPersonality()
        {
            var request = _mapper.Map<IEnumerable<ReceivePersonalityRequest>>(
                _manager.GetPersonality()
                );

            return request;
        }
    }
}