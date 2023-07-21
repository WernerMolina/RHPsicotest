using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.ViewModels
{
    public class CandidateVM
    {
        [Display(Name = "Rol")]
        [Required(ErrorMessage = "Requerido")]
        public int IdRole { get; set; }

        [Display(Name = "Puesto")]
        [Required(ErrorMessage = "Requerido")]
        public int IdPosition { get; set; }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "Requerido")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Requerido")]
        public string Password { get; set; }
    }
}
