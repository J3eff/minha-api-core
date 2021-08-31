using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MinhaAPICore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet] // Atributos
        public ActionResult<IEnumerable<string>> ObterTodos()
        {
            var valores = new string[] { "value1", "value1" };

            if (valores.Length < 1)
                return BadRequest();

            return Ok(valores);
        }

        [HttpGet("obter-valores")]
        public IEnumerable<string> ObterValores()
        {
            var valores = new string[] { "value1", "value1" };

            if (valores.Length < 5000)
                return null;

            return valores;
        }

        // GET api/values/obter-por-id/5
        [HttpGet("obter-por-id/{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(typeof(Product), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult Post(Product product)
        {
            // Quando temos um tipo complexo não precisamo informa o FromBody
            // FromBody - diz que value esta vindo dentro do corpo do meu Request Http
            if (product.Id == 0) return BadRequest();

            // add no banco

            //return Ok(product); retorna 200 por isso utilizamos CreatedAtAction, pois ele retorna o 201.
            return CreatedAtAction(nameof(Post), product);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put([FromRoute] int id, [FromForm] Product value)
        {
            // FromRoute - informa que este id esta vindo da rota, porem como esta explicito no HttpPut não precisa
            // FromForm - esta dizendo que este dados esta vindo atravêz de um form.
        }

        // DELETE api/value/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    public class Product
    {
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
