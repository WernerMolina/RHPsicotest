using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace RHPsicotest.WebSite.ViewModels.User
{
    public class UserVM
    {
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "El nombre es requerido")]
        [IgnoreDataMember]
        public string Password { get; set; }
    }
}
