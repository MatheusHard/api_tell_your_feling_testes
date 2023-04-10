using Microsoft.AspNetCore.Mvc;
using WebApplication2_Wep_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2_Wep_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

     
        
        
        // GET: api/<UsuarioController>
        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> Get()
        {

            var lista = getUsuarios();

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
        public void Post([FromBody] string value)
        {
        }
        // POST api/<UsuarioController>
        [HttpPost("Login")]
        public ActionResult Login([FromBody] Usuario model)
        {
             var lista = getUsuarios();

            var usuarioLogado = lista.FirstOrDefault(u => u.Email == model.Email);

            if (usuarioLogado == null)
                return BadRequest("Usuario nao encontrado!!!");
            if(!usuarioLogado.Ativo)
                return BadRequest("Usuario desativado");
            if (model.Password != usuarioLogado.Password || model.Email != usuarioLogado.Email)
                return BadRequest("Verifique suas credencias!!!");
            else
                return Ok(usuarioLogado);
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
        private IEnumerable<Usuario> getUsuarios() {

            List<Usuario> usuarios = new List<Usuario>();
                     
            Usuario u1 = new Usuario {
                                    Ativo = true, Email= "matheus@gmail.com", Nome = "Luiz Silva", Password = "40bd001563085fc35165329ea1ff5c5ecbdbbeef", 
                                    Id = Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e"), Cpf = "05698754521", DataDeNascimento = DateTime.MinValue,
                                    EscolaId = Guid.Parse("7fab3195-ba9d-4ad6-8dac-2167a8aa75f1"), TurmaId = Guid.Parse("9cf1efca-40cc-4f87-a40b-a531167de3eb")
            };
            Usuario u2 = new Usuario 
                                    {Ativo = false, Email = "cururu@gmail.com", Nome = "Luana Costa", Password = "125454", 
                                     Id = Guid.Parse("7c9e6679-7425-40de-944b-e07fc1f90ae7"), Cpf = "05668554521", DataDeNascimento = DateTime.MinValue,
                                    EscolaId = Guid.Parse("7fab3195-ba9d-4ad6-8dac-2167a8aa75f1"), TurmaId = Guid.Parse("9cf1efca-40cc-4f87-a40b-a531167de3eb")
            };
            usuarios.Add(u1);
            usuarios.Add(u2);

            return usuarios;
    }
    }
}
