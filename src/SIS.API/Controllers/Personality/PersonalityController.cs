using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HirePersonality.API.DataContract.Personality;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HirePersonality.API.Controllers.Personality
{
    [AllowAnonymous]
    [Route("api/[controller]")]
    [ApiController]

    public class PersonalityController : Controller
    {
        [HttpPost]
        public async Task<IActionResult> PostPersonality(PersonalityCreateRequest personalityCreateRequest)
        {


            return Ok();
        }
    }
}