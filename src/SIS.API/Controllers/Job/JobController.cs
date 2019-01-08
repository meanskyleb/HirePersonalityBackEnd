using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using HirePersonality.API.DataContract.Job;
using HirePersonality.Business.DataContract.Job;
using Microsoft.AspNetCore.Mvc;

namespace HirePersonality.API.Controllers.Job
{
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
    }
}