using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApplication2_Wep_API.Enums
{
    public enum PerguntaTipo
    {

        [Display(Name = "Família")]
        FAMILIA = 0,
        [Display(Name = "Saúde")]
        SAUDE = 1,
        [Display(Name = "Escola")]
        ESCOLA = 2,
        [Display(Name = "Professores")]
        PROFESSORES= 3,
        [Display(Name = "Estudos")]
        ESTUDOS = 4,
        [Display(Name = "Colegas")]
        COLEGAS = 5
        
    }
}
