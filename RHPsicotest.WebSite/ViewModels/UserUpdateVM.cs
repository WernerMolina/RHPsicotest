using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.ViewModels
{
    public class UserUpdateVM
    {
        public int IdUser { get; set; }

        [StringLength(25, ErrorMessage = "El máximo de carácteres es 25")]
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Requerido")]
        public string Name { get; set; }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "Requerido")]
        [EmailAddress(ErrorMessage = "Dirección de correo invalidad")]
        public string Email { get; set; }

        [StringLength(20, ErrorMessage = "El máximo de carácteres es 20")]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        public List<int> RolesId { get; set; }
    }
}
