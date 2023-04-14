using Microsoft.AspNetCore.Mvc;
using WebApplication2_Wep_API.Models;
using AutoMapper;
using WebApplication2_Wep_API.Mappers;
using WebApplication2_Wep_API.Enums;

namespace WebApplication2_Wep_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RespostaController : ControllerBase

    {
        

        // GET: api/<UsuarioController>
        [HttpGet]
        public ActionResult<IEnumerable<RespostaViewModel>> Get()
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
        public ActionResult Post([FromBody] IEnumerable<RespostaViewModel> respostas)
        {
            
            var lista = respostas;
            List<Resposta> response = new List<Resposta>(); 
            
            foreach (RespostaViewModel resposta in respostas)
            {
                //Initializing AutoMapper
                var mapper = MapperConfig.InitializeAutomapper();



                Resposta mapeado = mapper.Map<Resposta>(resposta);


                //Simualar o ADD
                //retorno = applicationRespota.AtualizarOuInserir(mapeado);
                int retorno = 1;

                if(retorno == 1)
                {
                    mapeado.StatusEnvio = StatusEnvio.ENVIADO;
                }
                else
                {
                    mapeado.StatusEnvio = StatusEnvio.ERRO_NO_ENVIO;
                    mapeado.Erros = "Ocorream alguns erros";
                }
                response.Add(mapeado);


            }
           return Ok(response);
        }
       

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] RespostaViewModel model)
        {
            //Initializing AutoMapper
            var mapper = MapperConfig.InitializeAutomapper();

            

            Resposta mapeado = mapper.Map<Resposta>(model);

        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
        private IEnumerable<RespostaViewModel> GetRespostas()
        {

            List<RespostaViewModel> lista = new List<RespostaViewModel>();

            RespostaViewModel u1 = new RespostaViewModel
            {
                Id = Guid.Parse("0d8d15be-6396-4541-a1a2-9323f66d0db7"),
                PerguntaId = Guid.Parse("c1bf252f-2b6b-4adb-848a-bd50b8963c32"),
                AlunoId = Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e"),
                Turma = Enums.Turma.PRIMEIRA_SERIE,
                RespostaCodigo = RespostaCodigo.FELIZ,
                Erros = "",
                DataCadastro = DateTime.Now,
                EnderecoIp = "192.168.0.6",
                Latitude = "1254.221252",
                Longitude = "55415",
                StatusEnvio = StatusEnvio.A_ENVIAR,
                PerguntaTipo = PerguntaTipo.COLEGAS,



            };
            RespostaViewModel u2 = new RespostaViewModel
            {
                Id = Guid.Parse("dddf4386-054d-4b27-bf1e-f7c174f034e5"),
                PerguntaId = Guid.Parse("2427adad-4f64-40c4-b4d5-313a1044619f"),
                AlunoId = Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e"),
                Turma = Enums.Turma.PRIMEIRA_SERIE,
                RespostaCodigo = RespostaCodigo.FELIZ,
                Erros = "",
                DataCadastro = DateTime.Now,
                EnderecoIp = "192.168.0.6",
                Latitude = "1254.ew221252",
                Longitude = "55415",
                StatusEnvio = StatusEnvio.ENVIADO,
                PerguntaTipo = PerguntaTipo.PROFESSORES,

            };
            lista.Add(u1);
            lista.Add(u2);

            return lista;
        }
    }
}

