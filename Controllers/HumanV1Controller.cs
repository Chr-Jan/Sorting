using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sorting.Data;

namespace Sorting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("1")]
    public class HumanV1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHumans()
        {
            var humans = SeedData.GetHumans();
            return Ok(humans);
        }
    }
}
