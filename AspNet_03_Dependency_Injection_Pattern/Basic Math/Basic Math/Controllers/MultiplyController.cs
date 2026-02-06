using Basic_Math.Interfaces;
using Basic_Math.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Basic_Math.Controllers
{
    [Route("api/multiply")]
    [ApiController]
    public class MultiplyController : ControllerBase
    {

        private readonly IMath _mathService;

        public MultiplyController(IMath mathService)
        {
            _mathService = mathService;
        }

        [HttpPost]
        public IActionResult Multiply([FromBody] MathParameter data)
        {
            var result = _mathService.Multiply(data.a, data.b);
            return Ok($"{data.a} * {data.b} = {result}");
        }

    }
}
