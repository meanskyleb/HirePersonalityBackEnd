using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using HirePersonality.API.DataContract.Application;
using HirePersonality.Business.DataContract.Application.DTOs;
using HirePersonality.Business.DataContract.Application.Interfaces;
using System.Security.Claims;
using System.Threading.Tasks;

namespace HirePersonality.API.Controllers.Application
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IUserApplicationManager _applicationCreateManager;
        private readonly IMapper _mapper;

        public ApplicationController(IUserApplicationManager applicationCreateManager, IMapper mapper)
        {
            _applicationCreateManager = applicationCreateManager;
            _mapper = mapper;
        }

        [HttpPost] 
        public async Task<IActionResult> PostApplication(ApplicationCreateRequest applicationCreateRequest)
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(400);
            }
            var identityClaimNum = int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value); 

            var dto = _mapper.Map<ApplicationCreateDTO>(applicationCreateRequest);
            dto.OwnerId = identityClaimNum;

            var created = await _applicationCreateManager.CreateApplication(dto);

            if (created)
                return StatusCode(201); //TODO: Return URL of new resource

            return StatusCode(500);
        }
    }
}

