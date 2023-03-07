using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RHPsicotest.WebSite.Models
{
    [Table("Role")]
    public class Role
    {
        [Key]
        public int IdRole { get; set; }

        public string RoleName { get; set; }

        [InverseProperty(nameof(Role_User.Role))]
        public virtual IEnumerable<Role_User> Users { get; set; }

        [InverseProperty(nameof(Permission_Role.Role))]
        public virtual IEnumerable<Permission_Role> Permissions { get; set; }
        
        [InverseProperty(nameof(Models.Candidate.Role))]
        public virtual IEnumerable<Candidate> Candidate { get; set; }
    }
}
