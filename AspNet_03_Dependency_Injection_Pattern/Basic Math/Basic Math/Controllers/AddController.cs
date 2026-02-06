using Basic_Math.Interfaces;
using Basic_Math.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Basic_Math.Controllers
{
    [Route("api/add")]
    [ApiController]
    public class AddController : ControllerBase
    {

        private readonly IMath _mathService;

        public AddController(IMath mathService)
        {
            _mathService = mathService;
        }

        [HttpPost]
        public IActionResult Add([FromBody] MathParameter data)
        {
            var result = _mathService.Add(data.a, data.b);
            return Ok($"{data.a} + {data.b} = {result}");
        }
    }
}
