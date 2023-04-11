using WebApplication2_Wep_API.Enums;

namespace WebApplication2_Wep_API.Models
{
    public class RespostaViewModel : BaseViewModel
    {
        public Turma Turma { get; set; }
        public Guid PerguntaId { get; set; }
        public Guid AlunoId { get; set; }
        public StatusEnvio StatusEnvio { get; set; }
        public string Erros { get; set; }
        public RespostaCodigo RespostaCodigo { get; set; }
        public PerguntaTipo PerguntaTipo { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string EnderecoIp { get; set; }


    }
}