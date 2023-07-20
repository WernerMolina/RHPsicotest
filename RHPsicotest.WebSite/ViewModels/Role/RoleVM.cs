using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.ViewModels.Role
{
    public class RoleVM
    {
        [Display(Name = "Nombre del Rol")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string RoleName { get; set; }

        public List<int> PermissionsId { get; set; }
    }
}
