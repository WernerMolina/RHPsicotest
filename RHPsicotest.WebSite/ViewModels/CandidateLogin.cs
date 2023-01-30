using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.ViewModels
{
    public class CandidateLogin
    {
        public string Username { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Contraseña")]
        public string Password { get; set; }
    }
}
