using Basic_Math.Interfaces;
using Basic_Math.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Basic_Math.Controllers
{
    [Route("api/divide")]
    [ApiController]
    public class DivideController : ControllerBase
    {
        private readonly IMath _mathService;

        public DivideController(IMath mathService)
        {
            _mathService = mathService;
        }

        [HttpPost]
        public IActionResult Divide([FromBody] MathParameter data)
        {
            var result = _mathService.Divide(data.a, data.b);
            return Ok($"{data.a} / {data.b} = {result}");
        }

    }
}
