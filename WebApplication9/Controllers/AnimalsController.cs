using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Results;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApplication9.Models;

namespace WebApplication9.Controllers
{
    [ODataRoutePrefix("Animals")]
    public class AnimalsController : ODataController
    {
        [HttpGet]
        public ActionResult<IQueryable<Animal>> Get()
        {
            List<Animal> animals = new List<Animal> { new Dog(), new Cat() };
            return this.Ok(animals.AsQueryable()); 
        }

        [HttpPost]
        public IActionResult Post([FromBody] Animal animal)
        {
            return new CreatedODataResult<Animal>(animal);
        }
    }
}
