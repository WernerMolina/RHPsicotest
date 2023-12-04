using RHPsicotest.WebSite.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace RHPsicotest.WebSite.ViewModels
{
    public class RoleUpdateVM
    {
        public int IdRole { get; set; }

        [StringLength(50, ErrorMessage = "El máximo de carácteres es 50")]
        [Display(Name = "Nombre del Rol")]
        [Required(ErrorMessage = "Requerido")]
        public string RoleName { get; set; }

        public List<int> PermissionsId { get; set; }
    }
}
