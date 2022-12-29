using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.Models
{
    public class UserLogin
    {
        [Required(ErrorMessage = "El Email es Obligatorio")]
        [RegularExpression(@"^[^@]+@[^@]+\.[a-zA-Z]{2,}$", ErrorMessage = "El Correo no es válido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La Password es Obligatoria")]
        public string Password { get; set; }
    }
}
