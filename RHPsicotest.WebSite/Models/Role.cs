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

        [Display(Name = "Permiso")]
        public int IdPermission { get; set; }

        [Display(Name = "Nombre")]
        public string RoleName { get; set; }

        [Display(Name = "Permiso")]
        public Permission Permission { get; set; }

        public virtual IEnumerable<Role_User> Role_Users { get; set; }

    }
}
