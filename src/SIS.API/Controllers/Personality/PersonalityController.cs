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
    [Authorize]
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
        public async Task<IActionResult> PostPersonality(CreatePersonalityRequest request)
        {
            var dto = _mapper.Map<CreatePersonalityDTO>(request);

            if (await _manager.CreatePersonality(dto))
                return StatusCode(201);
            
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("Display")]
        [ActionName("Display")]
        public async Task<IActionResult> GetPersonality()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            } 

            var dto = await _manager.GetPersonality();

            var request = 
                _mapper.Map<IEnumerable<ReceivePersonalityRequest>>(dto);

            return Ok(request);
        }

        [HttpGet]
        [Route("id")]
        [ActionName("id")]
        public async Task<IActionResult> GetPersonalityById(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var dto = await _manager.GetPersonality(id);

            var request =
                _mapper.Map<ReceivePersonalityRequest>(dto);

            return Ok(request);
        }
 
        [HttpPut]
        public async Task<IActionResult> UpdatePersonality(UpdatePersonalityRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dto = _mapper.Map<UpdatePersonalityDTO>(request);

            if (await _manager.UpdatePersonality(dto))
                return StatusCode(202);
            
            else
                return StatusCode(303);
        }
        [Authorize]
        [HttpDelete]
        public async Task<IActionResult> DeletePersonality(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (await _manager.DeletePersonality(id))
                return StatusCode(217);
            else
                return StatusCode(303);
        }
    }
}