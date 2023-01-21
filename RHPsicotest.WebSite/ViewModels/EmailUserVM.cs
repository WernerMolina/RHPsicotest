using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.ViewModels
{
    public class EmailUserVM
    {
        public int IdRole { get; set; }

        [Required(ErrorMessage = "El Puesto es Obligatorio")]
        public int IdPuesto { get; set; }

        [Required(ErrorMessage = "El Correo es Obligatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La Contraseña es Obligatoria")]
        public string Password { get; set; }
    }
}
