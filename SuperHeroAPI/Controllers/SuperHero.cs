using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    public class SuperHeroController : ControllerBase
    {
        [HttpGet]
        // to see the sample in swagger, you need an ActionResult NOT the interface
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            var heroes = new List<SuperHero>
            {
                new SuperHero {
                    Id = 1,
                    Name = "Spider Man",
                    FirstName = "Peter",
                    LastName = "Parker",
                    Place = "New York City"
                }
            };

            return Ok(heroes);
        }
    }
}

