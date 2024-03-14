using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pets.API.Entities;

namespace Pets.API.Controllers
{
    [ApiController]
    public class VaccinesController : BaseController
    {
        // GET: api/<VaccinesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VaccinesController>/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Vaccine), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public string ObterVacina(int id)
        {
            
            return "value";
        }

        // POST api/<VaccinesController>
        [HttpPost]
        public void CriarVacina([FromBody] string value)
        {
        }

        // PUT api/<VaccinesController>/5
        [HttpPut("{id}")]
        public void AtualizarVacinas(int id, [FromBody] string value)
        {
            
        }
        
        // DELETE api/<VaccinesController>/5
        [HttpDelete("{id}")]
        public void DeletarVacinas(int id)
        {
        }
        
        // POST api/<VaccinesController>/5
    }
}
