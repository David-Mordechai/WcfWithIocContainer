using Microsoft.AspNetCore.Mvc;
using ServicesLibrary.Core;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly IExampleService _exampleService;

        public ExampleController(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _exampleService.GetData(1);

            return Ok(result);
        }
    }
}