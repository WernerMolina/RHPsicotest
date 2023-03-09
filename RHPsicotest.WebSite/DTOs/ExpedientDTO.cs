using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.DTOs
{
    public class ExpedientDTO
    {
        public int IdExpedient { get; set; }

        [Display(Name = "DUI")]
        public string DUI { get; set; }

        [Display(Name = "Nombres")]
        public string Names { get; set; }

        [Display(Name = "Apellidos")]
        public string Lastnames { get; set; }

        [Display(Name = "Correo")]
        public string Email { get; set; }

        [Display(Name = "Puesto")]
        public string Position { get; set; }
    }
}
