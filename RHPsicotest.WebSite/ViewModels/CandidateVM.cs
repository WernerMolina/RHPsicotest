using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.ViewModels
{
    public class CandidateVM
    {
        [Display(Name = "Rol")]
        [Required(ErrorMessage = "El Rol es requerido")]
        public int IdRole { get; set; }

        [Display(Name = "Puesto")]
        [Required(ErrorMessage = "El Puesto es requerido")]
        public int IdPosition { get; set; }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "El Correo es requerido")]
        public string Email { get; set; }

        [Display(Name = "Cotraseña")]
        [Required(ErrorMessage = "La Contraseña es requerida")]
        public string Password { get; set; }
    }
}
