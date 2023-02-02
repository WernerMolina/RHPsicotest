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

        [Display(Name = "Nombre del Rol")]
        public string RoleName { get; set; }

        [Display(Name = "Usuarios")]
        [InverseProperty(nameof(Role_User.Role))]
        public virtual IEnumerable<Role_User> Users { get; set; }

        [Display(Name = "Permisos")]
        [InverseProperty(nameof(Permission_Role.Role))]
        public virtual IEnumerable<Permission_Role> Permissions { get; set; }
        
        [InverseProperty(nameof(Candidate.Role))]
        public virtual IEnumerable<Candidate> EmailUsers { get; set; }
    }
}
