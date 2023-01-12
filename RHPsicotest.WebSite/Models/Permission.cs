using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace RHPsicotest.WebSite.Models
{
    [Table("Permission")]
    public class Permission
    {
        [Key]
        public int IdPermission { get; set; }

        [Display(Name = "Módulo")]
        public int IdModule { get; set; }

        [Display(Name = "Nombre")]
        public string PermissionName { get; set; }

        [Display(Name = "Módulo")]
        public virtual Module Module { get; set; }

        public virtual IEnumerable<Role> Roles { get; set; }

    }
}
