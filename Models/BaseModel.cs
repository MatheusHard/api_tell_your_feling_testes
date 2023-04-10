namespace WebApplication2_Wep_API.Models
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public Boolean Ativo { get; set; }
    }
}
