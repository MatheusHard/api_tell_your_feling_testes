using Microsoft.AspNetCore.Mvc;
using WebApplication2_Wep_API.Models;

namespace WebApplication2_Wep_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var lista = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();

            return lista;
        }
        [HttpGet("ObterPorId/{id:int}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }
        [HttpGet("GetTodos")]
        public ActionResult<IEnumerable<string>> GetTodos()
        {
            var valores = new string[] { "um", "doi", "trei" };
            if(valores.Length > 5)
            {
                return BadRequest("Erro");

            }
            return Ok(valores);
        }
        [HttpPost]
        public ActionResult Post([FromBody] WeatherForecast model)
        {
            if (model.Id <= 0) {
            
            return BadRequest();
            }
            return CreatedAtAction("POST", model);
        }


    }
}