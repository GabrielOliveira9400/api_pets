using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pets.API.Entities;
using Pets.API.Interfaces.Services;

namespace Pets.API.Controllers
{
    
    [ApiController]
    public class PetsController : BaseController
    {
        private readonly IPetService _petService;
    
        public PetsController(
            IPetService petService
        )
        {
            _petService = petService;
        }
        
        // GET: api/<PetsController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PetsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var pet = _petService.GetPet(id);
                return Ok(pet);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
        
        [HttpGet("details/{id}")]
        [ProducesResponseType(typeof(Pet), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(Vaccine), StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public IActionResult GetPetDetails(int id)
        {
            try
            {
                var pet = _petService.GetPetDetails(id);
                return Ok(pet.Result);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }

        // POST api/<PetsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PetsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PetsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var result = _petService.removePet(id);
                return Ok(result);
            }
            catch (Exception e)
            {
                return NotFound(e);
            }
        }
        
    }
}
