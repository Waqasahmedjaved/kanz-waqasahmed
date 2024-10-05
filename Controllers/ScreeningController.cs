using kanz_waqasahmed.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace kanz_waqasahmed.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ScreeningController : ControllerBase
    {
        private readonly IScreeningService _screeningService;

        public ScreeningController(IScreeningService screeningService)
        {
            _screeningService = screeningService;
        }

        [HttpGet("{number}")]
        public IActionResult GetScreeningResult(int number)
        {
            var result = _screeningService.GetScreeningResult(number);
            return Ok(new { results = result });
        }
    }
}
