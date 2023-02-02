using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.DTOs
{
    public class CandidateSendDTO
    {
        [Required(ErrorMessage = "El Correo es Obligatorio")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La Contraseña es Obligatoria")]
        public string Password { get; set; }
    }
}
