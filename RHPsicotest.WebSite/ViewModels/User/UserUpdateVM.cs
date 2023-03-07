using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace RHPsicotest.WebSite.ViewModels.User
{
    public class UserUpdateVM
    {
        public int IdUser { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Name { get; set; }

        [Display(Name = "Correo")]
        [Required(ErrorMessage = "El nombre es requerido")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        public string Password { get; set; }
    }
}
