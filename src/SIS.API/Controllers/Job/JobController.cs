using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HirePersonality.API.DataContract.Job;
using HirePersonality.Business.DataContract.Job;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HirePersonality.API.Controllers.Job
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IJobManager _manager;

        public JobController(IMapper mapper, IJobManager manager)
        {
            _mapper = mapper;
            _manager = manager;
        }

        [HttpPost]
        public async Task<IActionResult> PostJob(JobCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }

            var dto = _mapper.Map<JobCreateDTO>(request);

            if (await _manager.CreateJob(dto))
                return StatusCode(201);

            throw new Exception();
        }

        [HttpGet]
        [Route("Display")]
        [ActionName("Display")]
        public async Task<IActionResult> GetJob()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dto = await _manager.GetJob();

            var request =
                _mapper.Map<IEnumerable<ReceiveJobRequest>>(dto);

            return Ok(request);
        }
        
        [HttpGet]
        [Route("id")]
        [ActionName("id")]
        public async Task<IActionResult> GetJobById(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var dto = await _manager.GetJob(id);

            var request =
                _mapper.Map<ReceiveJobRequest>(dto);

            return Ok(request);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePersonality(UpdateJobRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var dto = _mapper.Map<UpdateJobDTO>(request);

            if (await _manager.UpdateJob(dto))
                return StatusCode(202);

            else
                return StatusCode(303);
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteJob(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (await _manager.DeleteJob(id))
                return StatusCode(217);
            else
                return StatusCode(303);
        }
    }

}