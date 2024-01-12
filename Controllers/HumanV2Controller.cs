using Microsoft.AspNetCore.Mvc;
using Sorting.Data;

namespace Sorting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("2")]
    public class HumanV2Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHumans()
        {
            var humans = SeedData.GetHumans();
            return Ok(humans);
        }

        [HttpGet("sortByName")]
        public ActionResult SortByName(bool ascending = true)
        {
            var sortedHumans = SeedData.SortByName(ascending);

            return Ok(sortedHumans);
        }
    }
}
