using WebApplication2_Wep_API.Enums;

namespace WebApplication2_Wep_API.Models
{
    public class Resposta : BaseModel
    {
        public Turma Codigo { get; set; }
        public Guid PerguntaId { get; set; }
        public Guid AlunoId{ get; set; }

    }
}