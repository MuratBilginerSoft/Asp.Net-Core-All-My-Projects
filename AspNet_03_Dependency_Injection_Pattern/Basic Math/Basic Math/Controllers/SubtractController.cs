using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Basic_Math.Interfaces;
using Basic_Math.Models;

namespace Basic_Math.Controllers
{
    [Route("api/subtract")]
    [ApiController]
    public class SubtractController : ControllerBase
    {
        private readonly IMath _mathService;

        public SubtractController(IMath mathService)
        {
            _mathService = mathService;
        }

        [HttpPost]
        public IActionResult Subtract([FromBody] MathParameter data)
        {
            var result = _mathService.Subtract(data.a, data.b);
            return Ok($"{data.a} - {data.b} = {result}");
        }
    }
}
