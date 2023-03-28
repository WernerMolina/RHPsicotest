using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.ViewModels.Candidate
{
    public class CandidateSendVM
    {
        [Required(ErrorMessage = "Requerido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Requerido")]
        public string Password { get; set; }
    }
}
