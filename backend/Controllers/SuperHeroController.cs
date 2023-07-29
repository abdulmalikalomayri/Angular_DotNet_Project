using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            return new List<SuperHero>
            {
                new SuperHero
                {
                    Name = "Batman",
                    FirstName = "Bruce",
                    LastName = "Wayne",
                    Place = "Gothm City",
                }
            };

        }
    }
}
