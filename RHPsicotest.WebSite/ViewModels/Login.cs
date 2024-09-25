using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.ViewModels
{
    public class Login
    {
        [Display(Name = "Correo")]
        [Required(ErrorMessage = "El correo es obligatorio")]
        [EmailAddress(ErrorMessage = "Dirección de correo invalidad")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string Password { get; set; }
    }
}
