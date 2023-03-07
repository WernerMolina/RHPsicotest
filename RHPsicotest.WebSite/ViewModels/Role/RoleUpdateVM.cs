using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RHPsicotest.WebSite.ViewModels.Role
{
    public class RoleUpdateVM
    {
        public int IdRole { get; set; }

        [Display(Name = "Nombre del Rol")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string RoleName { get; set; }
    }
}
