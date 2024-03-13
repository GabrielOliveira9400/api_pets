using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public string Get(int id)
        {
            try
            {
                var pet = _petService.GetPet(id);
                return pet.Name;
            }
            catch (Exception e)
            {
                return e.Message;
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
        public void Delete(int id)
        {
        }
    }
}
