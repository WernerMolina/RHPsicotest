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

        public string PermissionName { get; set; }

        public string PermissionNamePolicy { get; set; }

        public string Assigned { get; set; }

        [InverseProperty(nameof(Permission_Role.Permission))]
        public virtual IEnumerable<Permission_Role> Roles { get; set; }

    }
}
