using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApplication2_Wep_API.Enums
{
    public enum RespostaCodigo
    {
        [Display(Name = "Muito Triste")]
        MUITO_TRISTE = 0,
        [Display(Name = "Triste")]
        TRISTE = 1,
        [Display(Name = "Normal")]
        NORMAL = 2,
        [Display(Name = "Feliz")]
        FELIZ = 3,
        [Display(Name = "Muito feliz")]
        MUITO_FELIZ = 4,

    }
}
