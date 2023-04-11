using System.ComponentModel.DataAnnotations;

namespace WebApplication2_Wep_API.Enums
{
     public enum StatusEnvio
    {
        [Display(Name = "À ENVIAR")]
        A_ENVIAR = 0,
        [Display(Name = "ENVIADO")]
        ENVIADO = 1,
        [Display(Name = "ERRO NO ENVIO")]
        ERRO_NO_ENVIO = 2,
    }
}
