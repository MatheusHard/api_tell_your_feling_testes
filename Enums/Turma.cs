using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WebApplication2_Wep_API.Enums
{
    public enum Turma
    {
        [Display(Name = "1ª Série")]
        PRIMEIRA_SERIE = 1,
        [Display(Name = "2ª Série")]
        SEGUNDA_SERIE = 2,
        [Display(Name = "3ª Série")]
        TERCEIRA_SERIE = 3,
    }
}
