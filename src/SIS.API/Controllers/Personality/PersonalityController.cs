using System;
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

        public PersonalityController(IMapper mapper) 
        {
                _mapper = mapper;
        }

        [HttpPost]
        public async Task<IActionResult> PostPersonality(PersonalityCreateRequest request)
        {
            var dto = _mapper.Map<PersonalityCreateDTO>(request);

            //Logic for personalities go here.
            return Ok();
        }
    }
}