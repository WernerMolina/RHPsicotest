using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.ViewModels
{
    public class RoleVM
    {
        [StringLength(50, ErrorMessage = "El máximo de carácteres es 50")]
        [Display(Name = "Nombre del Rol")]
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string RoleName { get; set; }

        public List<int> PermissionsId { get; set; }
    }
}
