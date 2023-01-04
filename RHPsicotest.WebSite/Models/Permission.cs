using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.Models
{
    [Table("Permission")]
    public class Permission
    {
        [Key]
        public int IdPermission { get; set; }

        public int IdModule { get; set; }

        public string PermissionName { get; set; }

        public virtual Module Module { get; set; }

    }
}
