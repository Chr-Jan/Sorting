using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sorting.Data;

namespace Sorting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersion("3")]
    public class HumanV3Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult GetHumans()
        {
            var humans = SeedData.GetHumans();
            return Ok(humans);
        }

        [HttpGet("sortByName")]
        public IActionResult SortByName(bool accendent = true) 
        {
            var sortByName = SeedData.SortByName(accendent);
            return Ok(sortByName);
        }

        [HttpGet("sortByAge")]
        public IActionResult SortByAge(bool ascending = true) 
        {
            var sortByAge = SeedData.SortByAge(ascending);
            return Ok(sortByAge);
        }
    }
}
