using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.ViewModels
{
    public class UserUpdateVM
    {
        public int IdUser { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Requerido")]
        public string Name { get; set; }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "Requerido")]
        [EmailAddress(ErrorMessage = "Dirección de correo invalidad")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        public List<int> RolesId { get; set; }
    }
}
