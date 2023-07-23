using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace RHPsicotest.WebSite.ViewModels
{
    public class UserVM
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "Requerido")]
        public string Name { get; set; }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "Requerido")]
        [EmailAddress(ErrorMessage = "Dirección de correo invalidad")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Requerido")]
        public string Password { get; set; }

        public List<int> RolesId { get; set; }
    }
}
