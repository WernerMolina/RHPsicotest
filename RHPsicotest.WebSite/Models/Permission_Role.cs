using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RHPsicotest.WebSite.Models
{
    [Table("Permission_Role")]
    public class Permission_Role
    {
        [Key]
        public int IdPermission { get; set; }

        [Key]
        public int IdRole { get; set; }

        [ForeignKey(nameof(IdPermission))]
        [InverseProperty(nameof(Models.Permission.Roles))]
        public Permission Permission { get; set; }

        [ForeignKey(nameof(IdRole))]
        [InverseProperty(nameof(Models.Role.Permissions))]
        public Role Role { get; set; }
    }
}
