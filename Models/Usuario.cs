namespace WebApplication2_Wep_API.Models
{
    public class Usuario : BaseModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email{ get; set; }
        public string Password { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Foto { get; set; }
        public string Fone { get; set; }
        public Guid EscolaId { get; set; }
        public Guid TurmaId { get; set; }

    }
}
