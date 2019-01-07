using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HirePersonality.API.Controllers.Job
{
    public class JobController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}