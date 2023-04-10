using Microsoft.AspNetCore.Mvc;
using WebApplication2_Wep_API.Models;

namespace WebApplication2_Wep_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RespostaController : ControllerBase
    {
        // GET: api/<UsuarioController>
        [HttpGet]
        public ActionResult<IEnumerable<Resposta>> Get()
        {

            var lista = GetRespostas();

            return Ok(lista);
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsuarioController>
        [HttpPost]
        public void Post([FromBody] IEnumerable<Resposta> respostas)
        {
            var lista = respostas;
        }
       

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        private IEnumerable<Resposta> GetRespostas()
        {

            List<Resposta> lista = new List<Resposta>();

            Resposta u1 = new Resposta
            {
                Id = Guid.Parse("0d8d15be-6396-4541-a1a2-9323f66d0db7"),
                PerguntaId = Guid.Parse("c1bf252f-2b6b-4adb-848a-bd50b8963c32"),
                AlunoId = Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e"),
                Codigo = Enums.Turma.PRIMEIRA_SERIE,
                

            };
            Resposta u2 = new Resposta
            {
                Id = Guid.Parse("dddf4386-054d-4b27-bf1e-f7c174f034e5"),
                PerguntaId = Guid.Parse("2427adad-4f64-40c4-b4d5-313a1044619f"),
                AlunoId = Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e"),
                Codigo = Enums.Turma.PRIMEIRA_SERIE,

            };
            lista.Add(u1);
            lista.Add(u2);

            return lista;
        }
    }
}

