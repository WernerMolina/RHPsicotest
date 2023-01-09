using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RHPsicotest.WebSite.Models
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int IdRole { get; set; }

        public int IdPermission { get; set; }

        public string RoleName { get; set; }

        public Permission Permission { get; set; }

        public virtual IEnumerable<Role_User> Role_Users { get; set; }

    }
}
