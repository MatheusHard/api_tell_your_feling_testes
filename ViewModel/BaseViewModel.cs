namespace WebApplication2_Wep_API.Models
{
    public class BaseViewModel
    {
        public Guid Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public Boolean Ativo { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string EnderecoIp { get; set; }

    }
}
